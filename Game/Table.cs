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

        // Preflop
        PlayBettingRound(Increment(button, 3)); // under the gun starts

        // The flop
        dealer.DealFlop(this);
        PlayBettingRound(Increment(button, 1)); // small blind starts

        // Deal the turn
        dealer.DealTurn(this);
        PlayBettingRound(Increment(button, 1));

        // Deal the river
        dealer.DealRiver(this);
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

        do
        {
            int index = startIndex;
            for (int i = 0; i < NumOfPlayers; i++)
            {
                Player player = players[index];
                if (!player.isActive) continue;

                Action action = player.GetDecision();
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
                        break;
                }

                index = Increment(index);
            }
        }
        while (MoreBettingNeeded());
    }

    /// <summary>
    /// Checks if more betting is required (i.e. not all active players bet evenly)
    /// </summary>
    /// <returns></returns>
    private bool MoreBettingNeeded()
    {
        List<int> activeBets = new();
        foreach (Player player in players)
        {
            if (player.isActive)
            {
                activeBets.Add(player.BetChips);
            }
        }

        // return whether all elements in activeBets are the same
        return activeBets.Distinct().Count() > 1;
    }

    /// <summary>
    /// Determine the winner(s) and distribute the chips accordingly
    /// </summary>
    private void DistributeChips()
    {
        List<Player> winners = new(); // we might have multiple winners
        int bestHandEvaluation = int.MaxValue;

        foreach (Player player in players)
        {
            if (!player.isActive) continue;

            // if this is preflop, we have a winner as soon as we see an active player
            if (communityCards.Count == 0)
            {
                winners.Add(player);
                break;
            }

            int evaluation = EvaluateHand(player.hand, communityCards);
            if (evaluation < bestHandEvaluation)
            {
                winners.Clear();
                winners.Add(player);
                bestHandEvaluation = evaluation;
            }
            else if (evaluation == bestHandEvaluation)
            {
                winners.Add(player);
            }
        }

        // Distribute the chips - this only works in event of no side pot
        int winnings = pot.Total / winners.Count;
        foreach (Player winner in winners)
        {
            winner.AddChips(winnings);
        }

        // TODO: Implement side pots
    }

    /// <summary>
    /// Increments the index by some value while not going out of range
    /// </summary>
    private int Increment(int index, int value = 1) => (index + value) % NumOfPlayers;

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
}