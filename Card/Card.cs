using System;
using System.Collections.Generic;

namespace Poker;

public static class Card
{
    // These are stored as 32-bit integers
    // +--------+--------+--------+--------+
    // |xxxbbbbb|bbbbbbbb|cdhsrrrr|xxpppppp|
    // +--------+--------+--------+--------+
    // p = prime number of rank (deuce=2, three=3, four=5, ... , ace=41)
    // r = rank of card (deuce=0, three=1, four=2, five=3, ... , ace=12)
    // cdhs = suit of card (bit turned on based on suit of card)
    // b = bit turned on depending on rank of card

    public static readonly int[] Primes = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41};
    public static readonly Dictionary<char, int> RankMap = new()
    {
        {'2', 0},
        {'3', 1},
        {'4', 2},
        {'5', 3},
        {'6', 4},
        {'7', 5},
        {'8', 6},
        {'9', 7},
        {'T', 8},
        {'J', 9},
        {'Q', 10},
        {'K', 11},
        {'A', 12}
    };

    public static readonly Dictionary<char, int> SuitMap = new()
    {
        {'S', 0b0001},
        {'H', 0b0010},
        {'D', 0b0100},
        {'C', 0b1000}
    };

    public static readonly Dictionary<int, char> RankMapReverse = new()
    {
        {0, '2'},
        {1, '3'},
        {2, '4'},
        {3, '5'},
        {4, '6'},
        {5, '7'},
        {6, '8'},
        {7, '9'},
        {8, 'T'},
        {9, 'J'},
        {10, 'Q'},
        {11, 'K'},
        {12, 'A'}
    };

    public static readonly Dictionary<int, char> SuitMapReverse = new()
    {
        {0b0001, 'S'},
        {0b0010, 'H'},
        {0b0100, 'D'},
        {0b1000, 'C'}
    };

    public static readonly Dictionary<char, char> SuitDisplayMap = new()
    {
        {'S', '♠'},
        {'H', '♥'},
        {'D', '♦'},
        {'C', '♣'}
    };

    public static char GetSuit(int card)
    {
        return SuitMapReverse[(card >> 12) & 0xF];
    }

    public static char GetRank(int card)
    {
        return RankMapReverse[(card >> 8) & 0xF];
    }

    public static int CreateCard(char rank, char suit)
    {
        int card = 0;

        card |= 1 << RankMap[rank];
        card <<= 4;

        card |= SuitMap[suit];
        card <<= 4;

        card |= RankMap[rank];
        card <<= 8;

        card |= Primes[RankMap[rank]];

        return card;
    }

    public static void Display(int card)
    {
        char rank = RankMapReverse[(card >> 8) & 0xF];
        char suit = SuitMapReverse[(card >> 12) & 0xF];

        Console.Write($"{rank}{SuitDisplayMap[suit]}  ");
    }

    public static string GetString(int card)
    {
        char rank = RankMapReverse[(card >> 8) & 0xF];
        char suit = SuitMapReverse[(card >> 12) & 0xF];

        return $"{rank}{SuitDisplayMap[suit]}";
    }
}