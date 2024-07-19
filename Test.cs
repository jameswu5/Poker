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
        int c2 = Card.CreateCard('2', 'S');
        int c3 = Card.CreateCard('3', 'S');
        int c4 = Card.CreateCard('4', 'S');
        int c5 = Card.CreateCard('5', 'S');
        int c6 = Card.CreateCard('6', 'S');
        int c7 = Card.CreateCard('7', 'S');
        int c8 = Card.CreateCard('8', 'S');
        int c9 = Card.CreateCard('9', 'S');
        int ct = Card.CreateCard('T', 'S');
        int cj = Card.CreateCard('J', 'S');
        int cq = Card.CreateCard('Q', 'S');
        int ck = Card.CreateCard('K', 'S');
        int ca = Card.CreateCard('A', 'S');
    }

    public static void CheckUnique()
    {
        Console.WriteLine(Evaluate.Lookup.UniqueLookup[3968]); // should be 1601
        Console.WriteLine(Evaluate.Lookup.UniqueLookup[47]); // should be 7462
    }

    public static void CheckDistinctPairs()
    {
        for (int i = 0; i < 13*12; i++)
        {
            Console.WriteLine($"{Evaluate.Lookup.DistinctPairs[i][0]} {Evaluate.Lookup.DistinctPairs[i][1]}");
        }
    }

    public static void CheckHandEvaluation()
    {
        // Generate random hand
        CardCollection deck = new();
        deck.CreateStandardDeck();
        deck.Shuffle();
        int[] hand = new int[5] {deck.Pop(), deck.Pop(), deck.Pop(), deck.Pop(), deck.Pop()};

        foreach (int card in hand)
        {
            Card.Display(card);
        }
        Console.WriteLine(Evaluate.Evaluate.GetHandValue(hand));

    }
}