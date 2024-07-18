using System;
using System.Collections.Generic;

namespace Poker;

public static class Test
{
    public static void TestCreateCard()
    {
        if (Card.CreateCard('K', 'D') != 0b00001000000000000100101100100101)
        {
            throw new Exception("King of Diamonds failed");
        }
        if (Card.CreateCard('5', 'S') != 0b00000000000010000001001100000111)
        {
            throw new Exception("Five of Spades failed");
        }
        if (Card.CreateCard('J', 'C') != 0b00000010000000001000100100011101)
        {
            throw new Exception("Jack of Clubs failed");
        }
        Console.WriteLine("All tests passed.");
    }

    public static void TestStandardDeck()
    {
        CardCollection deck = new();
        deck.CreateStandardDeck();
        deck.Shuffle();
        deck.Display();
    }

    public static void CheckFlush()
    {
        ulong c1 = Card.CreateCard('2', 'S');
        ulong c2 = Card.CreateCard('3', 'S');
        ulong c3 = Card.CreateCard('4', 'S');
        ulong c4 = Card.CreateCard('5', 'S');
        ulong c5 = Card.CreateCard('6', 'S');
        ulong c6 = Card.CreateCard('7', 'S');
        ulong c7 = Card.CreateCard('8', 'H');
        ulong[] cards = {c1, c2, c3, c4, c5, c6};
        Console.WriteLine(Evaluate.Evaluate.IsFlush(cards));
    }

    public static void CheckNextBitSequence()
    {
        uint cur = 0b11111;
        for (int i = 0; i < 50; i++)
        {
            cur = Evaluate.Lookup.GetNextBitPermutation(cur);
            Console.WriteLine(Convert.ToString(cur, 2).PadLeft(32, '0'));
        }
    }

}