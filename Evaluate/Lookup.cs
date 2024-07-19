using System;
using System.Collections.Generic;

namespace Poker.Evaluate;

public static class Lookup
{
    private const int MaxStraightFlushes = 10;
    private const int MaxFourOfAKind = 156 + MaxStraightFlushes;
    private const int MaxFullHouse = 156 + MaxFourOfAKind;
    private const int MaxFlush = 1277 + MaxFullHouse;
    private const int MaxStraight = 10 + MaxFlush;
    private const int MaxThreeOfAKind = 858 + MaxStraight;
    private const int MaxTwoPair = 858 + MaxThreeOfAKind;
    private const int MaxOnePair = 2860 + MaxTwoPair;
    private const int MaxHighCard = 1277 + MaxOnePair;

    public static readonly int[] FlushLookup; // Stores the values of flushes
    public static readonly int[] UniqueLookup; // Stores the values of five unique cards

    // Initialise Lookup tables
    static Lookup()
    {
        FlushLookup = GetFlushLookup();
        UniqueLookup = GetUniqueLookup();
    }

    public static void Init() {}

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