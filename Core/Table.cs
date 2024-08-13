using System;
using System.Collections.Generic;

namespace Poker.Core;

public class Table
{
    public List<Player> players;
    public Dealer dealer;
    public Pot pot;

    public List<int> communityCards;

    public int button; // index of the player who has the button
    public int smallBlind;
    public int bigBlind;

    public int NumOfPlayers => players.Count;


    public enum Stage { Preflop, Flop, Turn, River, Showdown };
    public Stage stage;
    public int playerToMove;
    // index of the player who raised last / started betting round
    public int terminatingTarget;
    public int playersLeft;


    public Table(List<Player> players, Pot pot, int smallBlind, int bigBlind)
    {
        this.players = players;
        dealer = new();
        this.pot = pot;
        communityCards = new();

        this.smallBlind = smallBlind;
        this.bigBlind = bigBlind;
        button = 0;

        Reset();
    }

    public void AddCommunityCard(int card)
    {
        communityCards.Add(card);
    }

    public void Reset()
    {
        communityCards.Clear();
        foreach (Player player in players)
        {
            player.hand.Clear();
            player.stillPlaying = true;
        }
        pot.Reset();

        // button does not move

        playerToMove = 0;
        playersLeft = players.Count;
        terminatingTarget = -1;
        stage = Stage.Preflop;
    }

    /// <summary>
    /// Increments the index by some value while not going out of range
    /// </summary>
    private int Increment(int index, int value = 1) => (index + value) % NumOfPlayers;

    private void PayBlinds()
    {
        players[Increment(button, 1)].AddToPot(smallBlind);
        players[Increment(button, 2)].AddToPot(bigBlind);
    }

    private static int EvaluateHand(CardCollection hand, List<int> communityCards)
    {
        // Shallow copy hand.cards (which is fine as hand.cards contains only integers)
        List<int> evHand = hand.cards.ToList();
        foreach (int card in communityCards)
        {
            evHand.Add(card);
        }

        return Evaluate.Evaluate.EvaluateHand(evHand.ToArray());
    }

    /// <summary>
    /// Determine the winner(s) and distribute the chips accordingly
    /// </summary>
    private void DistributeChips()
    {
        Dictionary<Player, int> payouts = ComputePayout();
        foreach (KeyValuePair<Player, int> pair in payouts)
        {
            Console.WriteLine($"Player {pair.Key.name} wins {pair.Value}");
            pair.Key.AddChips(pair.Value);
        }
    }

    private Dictionary<Player, int> ComputePayout()
    {
        Dictionary<Player, int> payouts = new();

        // This whole code is so ugly
        Dictionary<int, List<Player>> playersHandStrength = new();
        foreach (Player player in players)
        {
            if (!player.stillPlaying) continue;

            int handStrength = EvaluateHand(player.hand, communityCards);
            if (!playersHandStrength.ContainsKey(handStrength))
            {
                playersHandStrength[handStrength] = new();
            }

            playersHandStrength[handStrength].Add(player);
        }

        // Sort
        PriorityQueue<List<Player>, int> playersByHandStrength = new();

        foreach (KeyValuePair<int, List<Player>> pair in playersHandStrength)
        {
            playersByHandStrength.Enqueue(pair.Value, pair.Key);
        }

        List<List<Player>> ranking = new();
        while (playersByHandStrength.Count > 0)
        {
            ranking.Add(playersByHandStrength.Dequeue());
        }

        List<Pot> sidePots = pot.GetSidePots();
        foreach (Pot sidePot in sidePots)
        {
            // for debugging purposes
            bool distributed = false;

            // Give side pot to player(s) with the best hand
            for (int i = 0; i < ranking.Count; i++)
            {
                List<Player> eligible = new();
                foreach (Player player in ranking[i])
                {
                    if (sidePot.Contains(player))
                    {
                        eligible.Add(player);
                    }
                }

                if (eligible.Count == 0) continue;

                int winnings = sidePot.Total / eligible.Count;
                foreach (Player player in eligible)
                {
                    if (!payouts.ContainsKey(player))
                    {
                        payouts[player] = 0;
                    }

                    payouts[player] += winnings;
                }

                distributed = true;
                break;
            }

            // if we get here, something has gone wrong
            if (!distributed)
            {
                throw new Exception("No eligible player in side pot");
            }
        }

        return payouts;
    }

    public void NewRound()
    {
        // Reset the table;
        Reset();

        // Pass the button
        button = Increment(button);

        // Small blind and big blind + deal cards
        PayBlinds();
        dealer.DealHoleCards(players);

        stage = Stage.Preflop;

        playerToMove = Increment(button, 3);
        terminatingTarget = playerToMove;

        players[playerToMove].TurnToMove();
    }

    // Handles all game logic, including transitions between and terminal states
    public void MakeMove(Action move)
    {
        switch (move)
        {
            case Fold _:
                players[playerToMove].Fold();
                playersLeft--;
                break;
            case Call _:
                players[playerToMove].Call(players.Where(player => player.stillPlaying).ToList());
                break;
            case Raise raise:
                players[playerToMove].Raise(raise.amount);
                terminatingTarget = playerToMove;
                break;
        }

        bool stageTransition = false;

        do
        {
            playerToMove = Increment(playerToMove);
            if (playerToMove == terminatingTarget)
            {
                // End of betting round
                terminatingTarget = -1;

                // Go to the next stage
                stageTransition = true;
                stage++;

                break;
            }
        }
        while (!players[playerToMove].stillPlaying);

        // end game early if there is only one player left
        if (playersLeft == 1)
        {
            // whoever playerToMove is pointing to is the winner
            players[playerToMove].AddChips(pot.Total);

            // start a new game
            NewRound();
            return;
        }

        if (stageTransition)
        {
            switch (stage)
            {
                case Stage.Flop:
                    dealer.DealFlop(this);
                    playerToMove = Increment(button, 1);
                    break;
                case Stage.Turn:
                    dealer.DealTurn(this);
                    playerToMove = Increment(button, 1);
                    break;
                case Stage.River:
                    dealer.DealRiver(this);
                    playerToMove = Increment(button, 1);
                    break;
                case Stage.Showdown:
                    DistributeChips();
                    NewRound();
                    return;
            }

            terminatingTarget = playerToMove;

            // Get first player who still is yet to fold
            while (!players[playerToMove].stillPlaying)
            {
                playerToMove = Increment(playerToMove);
            }
        }

        // Remind the player to move
        players[playerToMove].TurnToMove();
    }
}