using System;
using System.Collections.Generic;

namespace Poker.Evaluate;

public static class Evaluate
{
    public enum HandStrength { HighCard, OnePair, TwoPair, ThreeOfAKind, Straight, Flush, FullHouse, FourOfAKind, StraightFlush }

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

    public static bool IsDistinct(int[] cards)
    {
        int seen = 0;
        foreach (int card in cards)
        {
            int rank = (card >> 16) & 0xFFFF;
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

    public static List<int[]> GetCombinations(int[] cards, int n)
    {
        List<int[]> result = new List<int[]>();
        GenerateCombinations(cards, n, 0, new List<int>(), result);
        return result;
    }

    private static void GenerateCombinations(int[] cards, int n, int startIndex, List<int> cur, List<int[]> result)
    {
        if (cur.Count == n)
        {
            result.Add(cur.ToArray());
            return;
        }

        for (int i = startIndex; i < cards.Length; i++)
        {
            cur.Add(cards[i]);
            GenerateCombinations(cards, n, i + 1, cur, result);
            cur.RemoveAt(cur.Count - 1);
        }
    }

    private static int GetHandValue(int[] cards)
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

    public static int EvaluateHand(int[] cards)
    {
        if (cards.Length < 5)
        {
            throw new ArgumentException("There must be at least 5 cards");
        }

        List<int[]> hands = GetCombinations(cards, 5);
        int bestHandValue = 10000;
        // int[] bestHand = new int[5];

        foreach (int[] hand in hands)
        {
            int handValue = GetHandValue(hand);
            if (handValue < bestHandValue)
            {
                bestHandValue = handValue;
                // bestHand = hand;
            }
        }

        return bestHandValue;
    }


    public static HandStrength ClassifyHand(int handValue)
    {
        if (handValue <= Lookup.MaxStraightFlush) { return HandStrength.StraightFlush; }
        if (handValue <= Lookup.MaxFourOfAKind) { return HandStrength.FourOfAKind; }
        if (handValue <= Lookup.MaxFullHouse) { return HandStrength.FullHouse; }
        if (handValue <= Lookup.MaxFlush) { return HandStrength.Flush; }
        if (handValue <= Lookup.MaxStraight) { return HandStrength.Straight; }
        if (handValue <= Lookup.MaxThreeOfAKind) { return HandStrength.ThreeOfAKind; }
        if (handValue <= Lookup.MaxTwoPair) { return HandStrength.TwoPair; }
        if (handValue <= Lookup.MaxOnePair) { return HandStrength.OnePair; }
        return HandStrength.HighCard;
    }

}