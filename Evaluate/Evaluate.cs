using System;
using System.Collections.Generic;

namespace Poker.Evaluate;

public static class Evaluate
{
    private static bool IsFlush(int[] cards)
    {
        // Checks if all the cards have the same suit
        int key = 0xF000;
        for (int i = 0; i < cards.Length; i++)
        {
            key &= cards[i] & 0xF000;
        }
        return key > 0;
    }

    private static bool IsDistinct(int[] cards)
    {
        int seen = 0;
        foreach (int card in cards)
        {
            int rank = card & 0xFF00;
            if ((seen & rank) > 0) return false;
            seen |= rank;
        }
        return true;
    }

    public static int GetPrimeKeyFromRanks(int[] rankIndices)
    {
        int key = 1;
        for (int i = 0; i < rankIndices.Length; i++)
        {
            key *= Card.Primes[rankIndices[i]];
        }
        return key;
    }

    private static int GetLookupKeyFromCards(int[] cards)
    {
        int key = 0;

        for (int i = 0; i < cards.Length; i++)
        {
            key |= cards[i];
        }

        key >>= 16;

        return key;
    }

    private static int GetPrimeKeyFromCards(int[] cards)
    {
        int key = 1;
        for (int i = 0; i < cards.Length; i++)
        {
            key *= cards[i] & 0xFF;
        }
        return key;
    }

    public static int GetHandValue(int[] cards)
    {
        if (cards.Length != 5)
        {
            throw new ArgumentException("There must be 5 cards");
        }

        // Check if there is a flush
        if (IsFlush(cards))
        {
            int key = GetLookupKeyFromCards(cards);
            return Lookup.FlushLookup[key];
        }

        // Check if cards are distinct
        if (IsDistinct(cards))
        {
            int key = GetLookupKeyFromCards(cards);
            return Lookup.UniqueLookup[key];
        }

        int primeKey = GetPrimeKeyFromCards(cards);
        return Lookup.RepeatedLookup[primeKey];
    }
}