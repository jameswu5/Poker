using System;
using System.Collections.Generic;
using System.Linq;
using Poker.Core;

namespace Poker.Experiment;

public class Simulation
{
    private readonly Dealer dealer;

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

    public void Simulate(int players, int rounds)
    {
        int[,,] results = new int[13, 13, 2];

        for (int round = 0; round < rounds; round++)
        {
            int verbose = 10000;
            if (round % verbose == verbose - 1)
            {
                Console.WriteLine($"Simulating round {round + 1} / {rounds}");
            }

            SimulateRound(players, results);
        }

        // Compute win rates
        List<(string hand, int wins, int losses, double winRate)> handWinRates = new();

        for (int row = 0; row < 13; row++)
        {
            for (int col = 0; col < 13; col++)
            {
                string hand = IndicesToString(row, col);

                int wins = results[row, col, 0];
                int losses = results[row, col, 1];
                double winRate = wins / (double)(wins + losses) * 100.0;
                handWinRates.Add((hand, wins, losses, winRate));
            }
        }

        // Sort by win rate descending, then by wins
        handWinRates.Sort((a, b) =>
        {
            int cmp = b.winRate.CompareTo(a.winRate);
            if (cmp == 0)
            {
                int cmp2 = b.wins.CompareTo(a.wins);
                if (cmp2 == 0)
                {
                    return a.losses.CompareTo(b.losses);
                }
                
                return cmp2;
            }
            return cmp;
        });

        // Display results
        int rank = 1;
        Console.WriteLine("\n=== Hole Card Win Rates ===");
        foreach (var (hand, wins, losses, winRate) in handWinRates)
        {
            Console.WriteLine($"{rank}. {hand}: {winRate:F2}% [W:{wins} L:{losses}]");
            rank++;
        }
    }

    private void SimulateRound(int players, int[,,] results)
    {
        dealer.Reset();

        // Deal hole cards to the players
        int[,] holeCards = new int[players, 2];
        for (int i = 0; i < players * 2; i++)
        {
            holeCards[i / 2, i % 2] = dealer.DealCard();
        }

        // Deal community cards
        int[] communityCards = new int[7];
        for (int i = 0; i < 5; i++)
        {
            communityCards[i] = dealer.DealCard();
        }

        int[] strengths = new int[players];
        for (int p = 0; p < players; p++)
        {
            communityCards[5] = holeCards[p, 0];
            communityCards[6] = holeCards[p, 1];
            strengths[p] = Evaluate.Evaluate.EvaluateHand(communityCards);
        }

        // Determine winner(s)
        int maxStrength = strengths.Min();
        for (int p = 0; p < players; p++)
        {
            var (row, col) = GetHoleCardIndices(holeCards[p, 0], holeCards[p, 1]);

            if (strengths[p] == maxStrength)
            {
                results[row, col, 0]++;
            }
            else
            {
                results[row, col, 1]++;
            }
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