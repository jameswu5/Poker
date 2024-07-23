using System;
using System.Collections.Generic;

namespace Poker;

public static class Cases
{
    // Test cases taken from https://github.com/HenryRLee/PokerHandEvaluator/tree/develop/test
    private const string filePath5 = "Test/5_card_hands.csv";
    private const string filePath6 = "Test/6_card_hands.csv";
    private const string filePath7 = "Test/7_card_hands.csv";
    
    private static List<int[]> GetCardHands(int cards)
    {
        List<int[]> hands = new();
        string filePath = cards switch
        {
            5 => filePath5,
            6 => filePath6,
            7 => filePath7,
            _ => throw new Exception("Cards must be 5, 6 or 7."),
        };
        try
        {
            using (StreamReader reader = new(filePath))
            {
                while (!reader.EndOfStream)
                {
                    string? line = reader.ReadLine();
                    if (line == null) continue;
                    string[] values = line.Split(',');
                    int[] hand = new int[cards+1];
                    for (int i = 0; i < cards; i++)
                    {
                        hand[i] = Card.CreateCard(values[i][0], values[i][1]);
                    }
                    hand[cards] = int.Parse(values[cards]);
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

    public static void CheckAllCardHands(int cards)
    {
        List<int[]> handAndValue = GetCardHands(cards);

        int errors = 0;
        int cases = handAndValue.Count;

        for (int i = 0; i < handAndValue.Count; i++)
        {
            int[] hand = handAndValue[i];
            int handValue = Evaluate.Evaluate.EvaluateHand(hand[..cards]);
            if (handValue != hand[cards])
            {
                Console.Write("Hand ");
                for (int j = 0; j < cards; j++)
                {
                    Card.Display(hand[j]);
                }
                Console.WriteLine($"failed (expected {hand[cards]}, got {handValue}).");
                errors++;
            }
        }

        Console.WriteLine($"{cases - errors} passed out of {cases} cases.");
    }
}