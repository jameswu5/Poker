using System;
using System.Collections.Generic;

namespace Poker.Core;

public class Pot
{
    public Dictionary<Player, int> pot;

    public int Total => pot.Values.Sum();

    public Pot()
    {
        pot = new();
    }

    public void AddChips(Player player, int amount)
    {
        if (!pot.ContainsKey(player))
        {
            pot[player] = 0;
        }

        pot[player] += amount;
    }

    public List<Pot> GetSidePots()
    {
        // sidePots will be in decreasing order based on how many people can collect this
        Pot clone = Clone();

        List<Pot> sidePots = new();

        int total = Total;
        while (total > 0)
        {
            Pot sidePot = new();
            int minBet = pot.Values.Min();
            foreach (Player player in clone.pot.Keys)
            {
                sidePot.AddChips(player, minBet);
                clone[player] -= minBet;
                total -= minBet;
                if (clone[player] == 0)
                {
                    clone.pot.Remove(player);
                }
            }
            sidePots.Add(sidePot);
        }

        return sidePots;
    }

    // Indexer
    public int this[Player player]
    {
        get { return pot.ContainsKey(player) ? pot[player] : 0; }
        set { pot[player] = value; }
    }

    public void Reset()
    {
        pot.Clear();
    }

    public bool Contains(Player player)
    {
        return pot.ContainsKey(player);
    }

    public Pot Clone()
    {
        Pot clone = new();
        foreach (Player player in pot.Keys)
        {
            clone.AddChips(player, pot[player]);
        }
        return clone;
    }

    public override string ToString()
    {
        return $"Pot: {Total}";
    }
}