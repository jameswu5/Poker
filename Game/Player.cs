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
    public int BetChips => pot[this];

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

    private int GetAmountToCall()
    {
        return pot.pot.Values.Max() - pot[this];
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
    /// Probably should change table to a state type.
    /// </summary>
    public virtual Action GetDecision(Table table)
    {
        // Barebones implementation
        Console.WriteLine();
        Console.Write($"{name} ({chips}) - ");
        hand.Display();
        int owe = GetAmountToCall();
        string oweString = owe == 0 ? "Check" : $"Call ({owe})";
        Console.WriteLine($"\n[1] Fold, [2] {oweString}, [3] Raise");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                return new Fold();
            case 2:
                return new Call();
            case 3:
                Console.WriteLine("How much do you want to raise?");
                int amount = int.Parse(Console.ReadLine());
                return new Raise(amount);
            default:
                throw new ArgumentException($"Invalid choice ({choice})");
        }
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