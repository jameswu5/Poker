using System;
using System.Collections.Generic;

namespace Poker.Evaluate;

public static class Lookup
{
    public const int MaxStraightFlush = 10;
    public const int MaxFourOfAKind = 156 + MaxStraightFlush;
    public const int MaxFullHouse = 156 + MaxFourOfAKind;
    public const int MaxFlush = 1277 + MaxFullHouse;
    public const int MaxStraight = 10 + MaxFlush;
    public const int MaxThreeOfAKind = 858 + MaxStraight;
    public const int MaxTwoPair = 858 + MaxThreeOfAKind;
    public const int MaxOnePair = 2860 + MaxTwoPair;
    public const int MaxHighCard = 1277 + MaxOnePair;

    public static readonly int[][] DistinctPairs;
    public static readonly int[] Straights;

    // Key: OR of the ranks of the cards
    public static readonly int[] FlushLookup; // Stores the values of flushes
    public static readonly int[] UniqueLookup; // Stores the values of five unique cards

    // Stores the values of 4 of a kind, full house, 3 of a kind, 2 pair, 1 pair
    // Key: product of primes of ranks of the cards
    public static readonly Dictionary<int, int> RepeatedLookup; 

    // Initialise Lookup tables
    static Lookup()
    {
        Straights = new int[]
        {
            0b1111100000000, // A high straight
            0b0111110000000,
            0b0011111000000,
            0b0001111100000,
            0b0000111110000,
            0b0000011111000,
            0b0000001111100,
            0b0000000111110,
            0b0000000011111,
            0b1000000001111, // 5 high straight
        };
        DistinctPairs = GetDistinctPairs();
        FlushLookup = GetFlushLookup();
        UniqueLookup = GetUniqueLookup();
        RepeatedLookup = GetRepeatedLookup();
    }

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

    private static int[] GetFlushLookup()
    {
        int[] flushes = new int[7937];

        for (int i = 0; i < 10; i++)
        {
            flushes[Straights[i]] = i + 1;
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

        for (int i = 0; i < 10; i++)
        {
            unique[Straights[i]] = i + MaxFlush + 1;
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
            int key = Evaluate.GetPrimeKeyFromRanks(new int[] {quad, quad, quad, quad, kicker});

            repeated[key] = score;
            score--;
        }

        // Full house
        score = MaxFullHouse;
        for (int i = 0; i < DistinctPairs.Length; i++)
        {
            int trip = DistinctPairs[i][0];
            int pair = DistinctPairs[i][1];
            int key = Evaluate.GetPrimeKeyFromRanks(new int[] {trip, trip, trip, pair, pair});

            repeated[key] = score;
            score--;
        }

        // 3 of a kind
        score = MaxStraight + 1; // Score of highest 3 of a kind (AAAKQ)

        for (int trip = 12; trip >= 0; trip--)
        {
            for (int kicker1 = 12; kicker1 >= 0; kicker1--)
            {
                for (int kicker2 = kicker1 - 1; kicker2 >= 0; kicker2--)
                {
                    if (trip == kicker1 || trip == kicker2) continue;
                    int key = Evaluate.GetPrimeKeyFromRanks(new int[] {trip, trip, trip, kicker1, kicker2});
                    repeated[key] = score;
                    score++;
                }
            }
        }

        // 2 pair
        score = MaxThreeOfAKind + 1; // Score of highest 2 pair (AAKKQ)
        for (int pair1 = 12; pair1 >= 0; pair1--)
        {
            for (int pair2 = pair1 - 1; pair2 >= 0; pair2--)
            {
                for (int kicker = 12; kicker >= 0; kicker--)
                {
                    if (kicker == pair1 || kicker == pair2) continue;

                    int key = Evaluate.GetPrimeKeyFromRanks(new int[] {pair1, pair1, pair2, pair2, kicker});
                    repeated[key] = score;
                    score++;
                }
            }
        }

        // 1 pair
        score = MaxTwoPair + 1; // Score of highest 1 pair (AAKQJ)
        for (int pair = 12; pair >= 0; pair--)
        {
            for (int kicker1 = 12; kicker1 >= 0; kicker1--)
            {
                for (int kicker2 = kicker1 - 1; kicker2 >= 0; kicker2--)
                {
                    for (int kicker3 = kicker2 - 1; kicker3 >= 0; kicker3--)
                    {
                        if (kicker1 == pair || kicker2 == pair || kicker3 == pair) continue;

                        int key = Evaluate.GetPrimeKeyFromRanks(new int[] {pair, pair, kicker1, kicker2, kicker3});
                        repeated[key] = score;
                        score++;
                    }
                }
            }
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