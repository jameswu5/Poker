using System;
using System.Collections.Generic;

namespace Poker.Game;

public class Pot
{
    public Dictionary<string, int> pot;

    public int Total => pot.Values.Sum();

    public Pot()
    {
        pot = new();
    }

    public void AddChips(Player player, int amount)
    {
        if (!pot.ContainsKey(player.name))
        {
            pot[player.name] = 0;
        }

        pot[player.name] += amount;
    }

    // Indexer
    public int this[string name]
    {
        get { return pot.ContainsKey(name) ? pot[name] : 0; }
        set { pot[name] = value; }
    }

    public void Reset()
    {
        pot.Clear();
    }

    public override string ToString()
    {
        return $"Pot: {Total}";
    }
}