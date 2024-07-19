using System;
using System.Collections.Generic;

namespace Poker.Evaluate;

public static class Evaluate
{
    public static bool IsFlush(int[] cards)
    {
        // Checks if all the cards have the same suit
        int key = 0xF000;
        for (int i = 0; i < cards.Length; i++)
        {
            key &= cards[i] & 0xF000;
        }
        return key > 0;
    }

    public static int GetFlushValue(int[] cards)
    {
        if (cards.Length != 5)
        {
            throw new ArgumentException("There must be 5 cards");
        }

        int key = 0;

        for (int i = 0; i < 5; i++)
        {
            key |= cards[i];
        }

        key >>= 16;

        return Lookup.FlushLookup[key];
    }

    public static int GetPrimeKey(int[] rankIndices)
    {
        int key = 1;
        for (int i = 0; i < rankIndices.Length; i++)
        {
            key *= (int) Card.Primes[rankIndices[i]];
        }
        return key;
    }
}