using System;
using System.Collections.Generic;

namespace Poker.Evaluate;

public static class Evaluate
{
    public static bool IsFlush(uint[] cards)
    {
        // Checks if all the cards have the same suit
        ulong key = 0xF000;
        for (int i = 0; i < cards.Length; i++)
        {
            key &= cards[i] & 0xF000;
        }
        return key > 0;
    }

    public static int GetFlushValue(uint[] cards)
    {
        if (cards.Length != 5)
        {
            throw new ArgumentException("There must be 5 cards");
        }

        uint key = 0;

        for (int i = 0; i < 5; i++)
        {
            key |= cards[i];
        }

        key >>= 16;

        return Lookup.FlushLookup[key];
    }
}