using System;
using System.Collections.Generic;

namespace Poker.Game;

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

    public Table(List<Player> players, Pot pot, int smallBlind, int bigBlind)
    {
        this.players = players;
        dealer = new();
        this.pot = pot;
        communityCards = new();

        this.smallBlind = smallBlind;
        this.bigBlind = bigBlind;
        button = 0;
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
            player.isActive = true;
        }
        pot.Reset();
    }

    // For now, we assume the round goes to the end
    public void PlayRound()
    {
        // Reset the table
        Reset();

        // Small blind and big blind + deal cards
        PayBlinds();
        dealer.DealHoleCards(players);

        DisplayTable();

        // Preflop
        PlayBettingRound(Increment(button, 3)); // under the gun starts

        // The flop
        Console.WriteLine("\n--THE FLOP--");
        dealer.DealFlop(this);
        DisplayTable();
        PlayBettingRound(Increment(button, 1)); // small blind starts


        // Deal the turn
        Console.WriteLine("\n--THE TURN--");
        dealer.DealTurn(this);
        DisplayTable();
        PlayBettingRound(Increment(button, 1));


        // Deal the river
        Console.WriteLine("\n--THE RIVER--");
        dealer.DealRiver(this);
        DisplayTable();
        PlayBettingRound(Increment(button, 1));

        // Determine the winner(s) and distribute chips
        DistributeChips();

        // Pass the button
        button = Increment(button);
    }

    private void PayBlinds()
    {
        players[Increment(button, 1)].AddToPot(smallBlind);
        players[Increment(button, 2)].AddToPot(bigBlind);
    }

    /// <summary>
    /// Plays a betting round with startIndex starting the betting
    /// </summary>
    public void PlayBettingRound(int startIndex)
    {
        // Get people with moves to play
        int peopleWithMoves = players.Count(player => player.isActive & !player.IsAllIn);
        if (peopleWithMoves < 2) return;

        int index = startIndex;
        int target = Decrement(startIndex); // if we reach this index, we're done

        while (index != target)
        {
            Player player = players[index];
            if (player.isActive)
            {
                Action action = player.GetDecision(this);
                switch (action)
                {
                    case Fold _:
                        player.Fold();
                        break;
                    case Call _:
                        player.Call(players.Where(player => player.isActive).ToList());
                        break;
                    case Raise raise:
                        player.Raise(raise.amount);
                        target = Decrement(index);
                        break;
                }

            }
            index = Increment(index);
        }
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
        PriorityQueue<List<Player>, int> playersByHandStrength = new();

        Dictionary<int, List<Player>> playersHandStrength = new();
        foreach (Player player in players)
        {
            if (!player.isActive) continue;

            int handStrength = EvaluateHand(player.hand, communityCards);
            if (!playersHandStrength.ContainsKey(handStrength))
            {
                playersHandStrength[handStrength] = new();
            }

            playersHandStrength[handStrength].Add(player);
        }

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

    /// <summary>
    /// Increments the index by some value while not going out of range
    /// </summary>
    private int Increment(int index, int value = 1) => (index + value) % NumOfPlayers;

    private int Decrement(int index, int value = 1) => (index - value + NumOfPlayers) % NumOfPlayers;

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


    private void DisplayTable()
    {
        Console.WriteLine();
        Console.WriteLine($"Pot: {pot.Total}");
        Console.WriteLine($"{string.Join(", ", communityCards.Select(Card.GetString))}");
        Console.WriteLine();
    }

    public override string ToString()
    {
        return $"Pot: {pot.Total}\nCards: {string.Join(", ", communityCards.Select(Card.GetString))}";
    }
}