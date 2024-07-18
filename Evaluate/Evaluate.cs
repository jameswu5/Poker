using System;
using System.Collections.Generic;

namespace Poker.Evaluate;

public static class Evaluate
{
    public static bool IsFlush(ulong[] cards)
    {
        // Checks if all the cards have the same suit
        ulong key = 0xF000;
        for (int i = 0; i < cards.Length; i++)
        {
            key &= cards[i] & 0xF000;
        }
        return key > 0;
    }
}