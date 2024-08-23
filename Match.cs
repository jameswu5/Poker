using System;
using Raylib_cs;
using static Poker.UI.Settings.Match;

namespace Poker;

public class Match
{
    public Core.Player[] players;
    public int[] wins;
    public int matches;

    public Match(List<Core.Player> players, int matches)
    {
        this.players = players.ToArray();
        wins = new int[players.Count];
        this.matches = matches;
    }

    public void Display()
    {
        for (int i = 0; i < players.Length; i++)
        {
            UI.Text.DisplayLeftText($"{players[i].name}: {wins[i]}", FontSize, ResultPositions[i][0], ResultPositions[i][1], Colour);
        }
    }

    public void PrintResults()
    {
        for (int i = 0; i < players.Length; i++)
        {
            Console.WriteLine($"{players[i].name}: {wins[i]}");
        }
    }
}