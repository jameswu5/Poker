using System;
using System.Collections.Generic;

namespace Poker.Evaluate;

public static class Lookup
{
    private const int MaxStraightFlush = 10;
    private const int MaxFourOfAKind = 156 + MaxStraightFlush;
    private const int MaxFullHouse = 156 + MaxFourOfAKind;
    private const int MaxFlush = 1277 + MaxFullHouse;
    private const int MaxStraight = 10 + MaxFlush;
    private const int MaxThreeOfAKind = 858 + MaxStraight;
    private const int MaxTwoPair = 858 + MaxThreeOfAKind;
    private const int MaxOnePair = 2860 + MaxTwoPair;
    private const int MaxHighCard = 1277 + MaxOnePair;

    public static readonly int[][] DistinctPairs;
    public static readonly int[][] DistinctTriples;
    public static readonly int[][] DistinctQuads;

    // Key: OR of the ranks of the cards
    public static readonly int[] FlushLookup; // Stores the values of flushes
    public static readonly int[] UniqueLookup; // Stores the values of five unique cards

    // Stores the values of 4 of a kind, full house, 3 of a kind, 2 pair, 1 pair
    // Key: product of primes of ranks of the cards
    public static readonly Dictionary<int, int> RepeatedLookup; 

    // Initialise Lookup tables
    static Lookup()
    {
        DistinctPairs = GetDistinctPairs();
        DistinctTriples = GetDistinctTriples();
        DistinctQuads = GetDistinctQuads();
        FlushLookup = GetFlushLookup();
        UniqueLookup = GetUniqueLookup();
        RepeatedLookup = GetRepeatedLookup();
    }

    public static void Init() {}

    private static int[][] GetDistinctPairs()
    {
        int[][] pairs = new int[13*12][];
        int index = 0;
        for (int i = 0; i < 13; i++)
        {
            for (int j = 0; j < 13; j++)
            {
                if (i == j) continue;
                pairs[index] = new int[2] {i, j};
                index++;
            }
        }
        return pairs;
    }

    private static int[][] GetDistinctTriples()
    {
        int[][] triples = new int[13*12*11][];
        int index = 0;
        for (int i = 0; i < 13; i++)
        {
            for (int j = 0; j < 13; j++)
            {
                for (int k = 0; k < 13; k++)
                {
                    if (i == j || i == k || j == k) continue;
                    triples[index] = new int[3] {i, j, k};
                    index++;
                }
            }
        }
        return triples;
    }

    private static int[][] GetDistinctQuads()
    {
        int[][] quads = new int[13*12*11*10][];
        int index = 0;
        for (int i = 0; i < 13; i++)
        {
            for (int j = 0; j < 13; j++)
            {
                for (int k = 0; k < 13; k++)
                {
                    for (int l = 0; l < 13; l++)
                    {
                        if (i == j || i == k || i == l || j == k || j == l || k == l) continue;
                        quads[index] = new int[4] {i, j, k, l};
                        index++;
                    }
                }
            }
        }
        return quads;
    }

    private static int[] GetFlushLookup()
    {
        int[] flushes = new int[7937];

        int[] straightFlushes = new int[]
        {
            0b1111100000000, // royal flush
            0b0111110000000,
            0b0011111000000,
            0b0001111100000,
            0b0000111110000,
            0b0000011111000,
            0b0000001111100,
            0b0000000111110,
            0b0000000011111,
            0b1000000001111, // 5 high straight flush
        };

        for (int i = 0; i < 10; i++)
        {
            flushes[straightFlushes[i]] = i + 1;
        }

        int current = 0b11111;
        int score = MaxFlush; // This is the score of the lowest flush (23457)

        while (current != 0b1111100000000)
        {
            current = GetNextBitPermutation(current);
            if (flushes[current] == 0)
            {
                flushes[current] = score;
                score--;
            }
        }

        return flushes;
    }

    private static int[] GetUniqueLookup()
    {
        int[] unique = new int[7937];

        int[] straights = new int[]
        {
            0b1111100000000, // royal flush
            0b0111110000000,
            0b0011111000000,
            0b0001111100000,
            0b0000111110000,
            0b0000011111000,
            0b0000001111100,
            0b0000000111110,
            0b0000000011111,
            0b1000000001111, // 5 high straight flush
        };

        for (int i = 0; i < 10; i++)
        {
            unique[straights[i]] = i + MaxFlush + 1;
        }

        int current = 0b11111;
        int score = MaxHighCard; // This is the score of the lowest high card hand (23457)

        while (current != 0b1111100000000)
        {
            current = GetNextBitPermutation(current);
            if (unique[current] == 0)
            {
                unique[current] = score;
                score--;
            }
        }

        return unique;
    }

    private static Dictionary<int, int> GetRepeatedLookup()
    {
        Dictionary<int, int> repeated = new();
        int score;

        // 4 of a kind
        score = MaxFourOfAKind;
        for (int i = 0; i < DistinctPairs.Length; i++)
        {
            int quad = DistinctPairs[i][0];
            int kicker = DistinctPairs[i][1];
            int key = Evaluate.GetPrimeKey(new int[] {quad, quad, quad, quad, kicker});

            repeated[key] = score;
            score--;
        }

        // Full house
        score = MaxFullHouse;
        for (int i = 0; i < DistinctPairs.Length; i++)
        {
            int trip = DistinctPairs[i][0];
            int pair = DistinctPairs[i][1];
            int key = Evaluate.GetPrimeKey(new int[] {trip, trip, trip, pair, pair});

            repeated[key] = score;
            score--;
        }

        // Three of a kind
        score = MaxThreeOfAKind;
        for (int i = 0; i < DistinctTriples.Length; i++)
        {
            int trip = DistinctTriples[i][0];
            int kicker1 = DistinctTriples[i][1];
            int kicker2 = DistinctTriples[i][2];
            int key = Evaluate.GetPrimeKey(new int[] {trip, trip, trip, kicker1, kicker2});

            if (repeated.ContainsKey(key)) continue;
            repeated[key] = score;
            score--;
        }

        // Two pair
        score = MaxTwoPair;
        for (int i = 0; i < DistinctTriples.Length; i++)
        {
            int pair1 = DistinctTriples[i][0];
            int pair2 = DistinctTriples[i][1];
            int kicker = DistinctTriples[i][2];
            int key = Evaluate.GetPrimeKey(new int[] {pair1, pair1, pair2, pair2, kicker});

            if (repeated.ContainsKey(key)) continue;
            repeated[key] = score;
            score--;
        }

        // One pair
        score = MaxOnePair;
        for (int i = 0; i < DistinctQuads.Length; i++)
        {
            int pair = DistinctQuads[i][0];
            int kicker1 = DistinctQuads[i][1];
            int kicker2 = DistinctQuads[i][2];
            int kicker3 = DistinctQuads[i][3];
            int key = Evaluate.GetPrimeKey(new int[] {pair, pair, kicker1, kicker2, kicker3});

            if (repeated.ContainsKey(key)) continue;
            repeated[key] = score;
            score--;
        }

        return repeated;
    }

    // Bit hack from http://www-graphics.stanford.edu/~seander/bithacks.html#NextBitPermutation
    public static int GetNextBitPermutation(int v)
    {
        int t = v | (v - 1);
        return (t + 1) | (((~t & -~t) - 1) >> (BitScanForward(v) + 1));
    }

    // Code taken from my chess project
    private static int BitScanForward(int data)
    {
        // There is no bit that is equal to 1
        if (data == 0) return -1;

        int n = 0;

        if ((data & 0xFFFF) == 0) { n += 16; data >>= 16; }
        if ((data & 0x00FF) == 0) { n += 8; data >>= 8; }
        if ((data & 0x000F) == 0) { n += 4; data >>= 4; }
        if ((data & 0x0003) == 0) { n += 2; data >>= 2; }
        if ((data & 0x0001) == 0) { n += 1; }

        return n;
    }
}