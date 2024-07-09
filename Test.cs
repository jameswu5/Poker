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
}