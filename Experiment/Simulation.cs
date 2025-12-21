using System;
using System.Collections.Generic;
using Poker.Core;

namespace Poker.Experiment;

public class Simulation
{
    // 3D array to hold hole card strength results
    private readonly int[,,] holeCardStrengthResults = new int[13, 13, 3]; // [wins, draws, losses]
    private Dealer dealer;

    public Simulation()
    {
        dealer = new Dealer();
    }

    private static (int, int) GetHoleCardIndices(int card1, int card2)
    {
        // Extract ranks
        char rank1 = Card.GetRank(card1);
        char rank2 = Card.GetRank(card2);

        int rankIndex1 = Card.RankMap[rank1];
        int rankIndex2 = Card.RankMap[rank2];

        // Handle pockets
        if (rank1 == rank2)
        {
            return (rankIndex1, rankIndex1);
        }

        // Extract suits
        char suit1 = Card.GetSuit(card1);
        char suit2 = Card.GetSuit(card2);

        int row, col;

        bool offsuit = suit1 != suit2;
        if (offsuit)
        {
            // Smaller one gets the row, larger one gets the column
            row = Math.Min(rankIndex1, rankIndex2);
            col = Math.Max(rankIndex1, rankIndex2);
        }
        else
        {
            // Larger one gets the row, smaller one gets the column
            row = Math.Max(rankIndex1, rankIndex2);
            col = Math.Min(rankIndex1, rankIndex2);
        }

        return (row, col);
    }

    private static string IndicesToString(int row, int col)
    {
        if (row == col)
        {
            char rank = Card.RankMapReverse[row];
            return $"{rank}{rank}";
        }
        else if (row > col)
        {
            char rank1 = Card.RankMapReverse[row];
            char rank2 = Card.RankMapReverse[col];
            return $"{rank1}{rank2}s";
        }
        else
        {
            char rank1 = Card.RankMapReverse[col];
            char rank2 = Card.RankMapReverse[row];
            return $"{rank1}{rank2}o";
        }
    }

    public void SimulateRound(int runs)
    {
        dealer.Reset();

        // Deal hole cards to two players
        int card1a = dealer.DealCard();
        int card1b = dealer.DealCard();
        (int row1, int col1) = GetHoleCardIndices(card1a, card1b);
        string hand1 = IndicesToString(row1, col1);

        int card2a = dealer.DealCard();
        int card2b = dealer.DealCard();
        (int row2, int col2) = GetHoleCardIndices(card2a, card2b);
        string hand2 = IndicesToString(row2, col2);

        // Player 1 stats
        int wins = 0;
        int draws = 0;
        int losses = 0;

        for (int run = 0; run < runs; run++)
        {
            // Deal community cards
            int[] communityCards = new int[7];
            for (int i = 0; i < 5; i++)
            {
                communityCards[i] = dealer.DealCard();
            }

            // Evaluate hands
            communityCards[5] = card1a;
            communityCards[6] = card1b;

            int strength1 = Evaluate.Evaluate.EvaluateHand(communityCards);

            communityCards[5] = card2a;
            communityCards[6] = card2b;

            int strength2 = Evaluate.Evaluate.EvaluateHand(communityCards);

            if (strength1 < strength2)
                wins++;
            else if (strength1 == strength2)
                draws++;
            else
                losses++;

            // Put cards back in deck and shuffle
            for (int i = 0; i < 5; i++)
            {
                dealer.deck.Add(communityCards[i]);
            }
            dealer.deck.Shuffle();
        }

        if (wins > losses)
        {
            holeCardStrengthResults[row1, col1, 0]++; // win
            holeCardStrengthResults[row2, col2, 2]++; // loss
        }
        else if (wins == losses)
        {
            holeCardStrengthResults[row1, col1, 1]++; // draw
            holeCardStrengthResults[row2, col2, 1]++; // draw
        }
        else
        {
            holeCardStrengthResults[row1, col1, 2]++; // loss
            holeCardStrengthResults[row2, col2, 0]++; // win
        }

        // Display results
        Console.WriteLine($"{hand1} vs {hand2} => Wins: {wins}, Draws: {draws}, Losses: {losses}");
    }

    public void Test()
    {
        for (int i = 0; i < 26; i++)
        {
            int card1 = dealer.DealCard();
            int card2 = dealer.DealCard();
            
            var (row, col) = GetHoleCardIndices(card1, card2);
            string holeCardStr = IndicesToString(row, col);
            Console.Write("Dealt cards: ");
            Card.Display(card1);
            Card.Display(card2);
            Console.WriteLine($"=> Indices: ({row}, {col}) \t[{holeCardStr}]");
        }
    }

}