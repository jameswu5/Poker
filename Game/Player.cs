using System;
using System.Collections.Generic;

namespace Poker.Game;

public class Player
{
    public string name;
    public int chips;
    public CardCollection hand;

    public bool isActive;

    public Player(string name, int chips)
    {
        this.name = name;
        this.chips = chips;
        hand = new CardCollection();
        isActive = true;
    }

    public void AddChips(int amount)
    {
        chips += amount;
    }

    public void Fold()
    {
        isActive = false;
        // might need to return some action here
    }

    public void Call()
    {
        throw new NotImplementedException();
    }

    public void Raise(int amount)
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