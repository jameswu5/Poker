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
        uint c2 = Card.CreateCard('2', 'S');
        uint c3 = Card.CreateCard('3', 'S');
        uint c4 = Card.CreateCard('4', 'S');
        uint c5 = Card.CreateCard('5', 'S');
        uint c6 = Card.CreateCard('6', 'S');
        uint c7 = Card.CreateCard('7', 'S');
        uint c8 = Card.CreateCard('8', 'S');
        uint c9 = Card.CreateCard('9', 'S');
        uint ct = Card.CreateCard('T', 'S');
        uint cj = Card.CreateCard('J', 'S');
        uint cq = Card.CreateCard('Q', 'S');
        uint ck = Card.CreateCard('K', 'S');
        uint ca = Card.CreateCard('A', 'S');
        Console.WriteLine(Evaluate.Evaluate.GetFlushValue(new uint[] {c9, cj, cq, ck, ca})); // should be 323
    }
}