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

        // Preflop
        dealer.DealHoleCards(players);
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

        // Determine the winner
        DistributeChips();

        // Pass the button
        button = Increment(button);
    }

    /// <summary>
    /// Plays a betting round with startIndex starting the betting
    /// </summary>
    public void PlayBettingRound(int startIndex)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Determine the winner(s) and distribute the chips accordingly
    /// </summary>
    public void DistributeChips()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// Increments the index by some value while not going out of range
    /// </summary>
    private int Increment(int index, int value = 1) => (index + value) % NumOfPlayers;
}