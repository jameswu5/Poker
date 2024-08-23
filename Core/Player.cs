using System;
using System.Collections.Generic;

namespace Poker.Core;

public abstract class Player
{
    public enum Type { Human, RandomBot };
    public event System.Action<Core.Action> PlayAction;
    public bool isActive;

    public string name;
    public int chips;
    public CardCollection hand;
    public bool stillPlaying;

    public Pot pot;

    public bool IsAllIn => stillPlaying & chips == 0;
    public int BetChips => pot[this];

    // Strictly speaking this is UI, but it's easier to keep it here
    public string actionText;

    public Player(string name, int chips, Pot pot)
    {
        this.name = name;
        this.chips = chips;
        hand = new CardCollection();
        stillPlaying = true;
        this.pot = pot;
        isActive = false;
        actionText = "";
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
        stillPlaying = false;
        return new Fold();
    }

    public Action Call()
    {
        if (IsAllIn)
        {
            return new Call(-1);
        }

        int amount = GetAmountToCall();
        AddToPot(amount);
        return new Call(amount);
    }

    public int GetAmountToCall()
    {
        int amount = pot.pot.Values.Max() - pot[this];
        return Math.Min(amount, chips);
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

    public void AddCard(int card)
    {
        hand.Add(card);
    }

    public abstract void TurnToMove();

    public abstract void Update();

    public void Decided(Action move)
    {
        isActive = false;
        actionText = $"{move}";
        PlayAction.Invoke(move);
    }

    public override string ToString()
    {
        return $"{name} ({chips})";
    }
}