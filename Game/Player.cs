using System;
using System.Collections.Generic;

namespace Poker.Game;

public class Player
{
    public string name;
    public int chips;
    public CardCollection hand;
    public bool isActive;

    public Pot pot;

    public bool IsAllIn => isActive & chips == 0;
    public int BetChips => pot[name];

    public Player(string name, int chips, Pot pot)
    {
        this.name = name;
        this.chips = chips;
        hand = new CardCollection();
        isActive = true;
        this.pot = pot;
    }

    public void AddChips(int amount)
    {
        chips += amount;
    }

    public int TryMakeBet(int amount) => Math.Min(amount, chips);

    public int AddToPot(int amount)
    {
        amount = TryMakeBet(amount);
        pot.AddChips(this, amount);
        chips -= amount;
        return amount;
    }

    public Action Fold()
    {
        isActive = false;
        return new Fold();
    }

    public Action Call(List<Player> activePlayers)
    {
        if (IsAllIn)
        {
            return new Call();
        }

        int highestBet = activePlayers.Max(player => player.BetChips);
        int amountToCall = highestBet - BetChips;
        AddToPot(amountToCall);
        return new Call();
    }

    /// <summary>
    /// Raise the bet to a certain amount.
    /// </summary>
    /// <param name="amount">Amount the bet is raised to</param>
    public Action Raise(int amount)
    {
        AddToPot(amount);
        return new Raise(amount);
    }

    /// <summary>
    /// Bot logic can come here. Return a decision based on the current state of the game.
    /// </summary>
    public Action GetDecision()
    {
        throw new NotImplementedException();
    }

    public void AddCard(int card)
    {
        hand.Add(card);
    }

    public override string ToString()
    {
        return $"{name} ({chips})";
    }
}