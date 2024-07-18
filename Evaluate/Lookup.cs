using System;
using System.Collections.Generic;

namespace Poker.Evaluate;

public static class Lookup
{

    public static int[] FlushLookup;

    // Initialise Lookup tables
    static Lookup()
    {

    }


    private static int[] GetFlushLookup()
    {
        int[] flushes = new int[7937];
        return flushes;
    }

    // Bit hack from http://www-graphics.stanford.edu/~seander/bithacks.html#NextBitPermutation
    public static uint GetNextBitPermutation(uint v)
    {
        uint t = v | (v - 1);
        return (t + 1) | (((~t & (uint)-(int)~t) - 1) >> (BitScanForward(v) + 1));
    }

    // Code taken from my chess project
    private static int BitScanForward(uint data)
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