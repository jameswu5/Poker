using System;
using System.Collections.Generic;
using Poker.Core;

namespace Poker.Experiment;

public class Simulation
{
    // 3D array to hold hole card strength results
    private readonly int[,,] holeCardStrengthResults = new int[13, 13, 2]; // [wins, losses]
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

        int row = -1;
        int col = -1;

        bool offsuit = suit1 != suit2;
        if (offsuit)
        {
            // Smaller one gets the row, larger one gets the column
            row = Math.Min(rankIndex1, rankIndex2);
            col = Math.Max(rankIndex1, rankIndex2);
        }
        else
        {
            row = Math.Max(rankIndex1, rankIndex2);
            col = Math.Min(rankIndex1, rankIndex2);
        }

        return (row, col); // Placeholder for suited/offsuit handling
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