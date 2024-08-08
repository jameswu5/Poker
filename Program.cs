using System;
using System.Collections.Generic;
using Raylib_cs;
using static Raylib_cs.Raylib;
using static Poker.UI.Settings;

namespace Poker;

public class Program
{
    public static void Main()
    {
        // Cases.CheckAllCardHands(7);
        // RunGame();
        RunGameWithUI();
    }

    public static void RunGame()
    {
        Core.Pot pot = new();
        List<Core.Player> players = new()
        {
            new Core.Player("Alice", 200, pot),
            new Core.Player("Bob", 200, pot),
            new Core.Player("Charlie", 200, pot)
        };

        Core.Table table = new(players, pot, 1, 2);
        table.PlayRound();
    }

    public static void RunGameWithUI()
    {
        InitWindow(ScreenWidth, ScreenHeight, "Poker");
        SetTargetFPS(60);


        while (!WindowShouldClose())
        {
            BeginDrawing();
            ClearBackground(ScreenColour);



            EndDrawing();
        }
        CloseWindow();
    }
}