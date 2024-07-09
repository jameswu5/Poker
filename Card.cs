using System;
using System.Collections.Generic;

namespace Poker;

public static class Card
{
    // These are stored as 64-bit unsigned integers
    // +--------+--------+--------+--------+
    // |xxxbbbbb|bbbbbbbb|cdhsrrrr|xxpppppp|
    // +--------+--------+--------+--------+
    // p = prime number of rank (deuce=2, three=3, four=5, ... , ace=41)
    // r = rank of card (deuce=0, three=1, four=2, five=3, ... , ace=12)
    // cdhs = suit of card (bit turned on based on suit of card)
    // b = bit turned on depending on rank of card

    private static readonly ulong[] Primes = {2, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31, 37, 41};
    private static readonly Dictionary<char, ulong> RankMap = new()
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

    private static readonly Dictionary<char, ulong> SuitMap = new()
    {
        {'S', 0b0001},
        {'H', 0b0010},
        {'D', 0b0100},
        {'C', 0b1000}
    };

    private static readonly Dictionary<ulong, char> RankMapReverse = new()
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

    private static readonly Dictionary<ulong, char> SuitMapReverse = new()
    {
        {0b0001, 'S'},
        {0b0010, 'H'},
        {0b0100, 'D'},
        {0b1000, 'C'}
    };

    private static readonly Dictionary<char, char> SuitDisplayMap = new()
    {
        {'S', '♠'},
        {'H', '♥'},
        {'D', '♦'},
        {'C', '♣'}
    };

    public static ulong CreateCard(char rank, char suit)
    {
        ulong card = 0;

        card |= (ulong)1 << (int)RankMap[rank];
        card <<= 4;

        card |= SuitMap[suit];
        card <<= 4;

        card |= RankMap[rank];
        card <<= 8;

        card |= Primes[RankMap[rank]];

        return card;
    }

    public static void Display(ulong card)
    {
        char rank = RankMapReverse[(card >> 8) & 0xF];
        char suit = SuitMapReverse[(card >> 12) & 0xF];

        Console.WriteLine($"{rank}{SuitDisplayMap[suit]}");
    }
}