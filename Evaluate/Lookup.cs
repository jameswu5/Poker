using System;
using System.Collections.Generic;

namespace Poker.Evaluate;

public static class Lookup
{
    private const int StraightFlushes = 10;
    private const int Flushes = 1277;

    public static int[] FlushLookup;

    // Initialise Lookup tables
    static Lookup()
    {
        FlushLookup = GetFlushLookup();
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
        int score = StraightFlushes + Flushes; // This is the score of the lowest flush (23457)

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