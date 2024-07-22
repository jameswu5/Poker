using System;
using System.Collections.Generic;

namespace Poker;

public static class Cases
{
    private static readonly List<int[]> HandAndValue; // [card1, card2, card3, card4, card5, value]
    private const string filePath = "Test/5_card_hands.csv"; // taken from https://github.com/HenryRLee/PokerHandEvaluator

    static Cases()
    {
        HandAndValue = Get5CardHands();
    }
    
    private static List<int[]> Get5CardHands()
    {
        List<int[]> hands = new();

        try
        {
            using (StreamReader reader = new(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] values = line.Split(',');
                    int[] hand = new int[6];
                    for (int i = 0; i < 5; i++)
                    {
                        hand[i] = Card.CreateCard(values[i][0], values[i][1]);
                    }
                    hand[5] = int.Parse(values[5]);
                    hands.Add(hand);
                }
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }

        return hands;
    }

    public static void CheckAll5CardHands()
    {
        int errors = 0;
        int cases = HandAndValue.Count;

        for (int i = 0; i < HandAndValue.Count; i++)
        {
            int[] hand = HandAndValue[i];
            int handValue = Evaluate.Evaluate.EvaluateHand(hand[..5]);
            if (handValue != hand[5])
            {
                Console.Write("Hand ");
                Card.Display(hand[0]);
                Card.Display(hand[1]);
                Card.Display(hand[2]);
                Card.Display(hand[3]);
                Card.Display(hand[4]);
                Console.WriteLine($"failed (expected {hand[5]}, got {handValue}).");
                errors++;
            }
        }

        Console.WriteLine($"{cases - errors} passed out of {cases} cases.");
    }
}