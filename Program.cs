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
        List<string> playerNames = new() { "Alice", "Beth", "Claire" };
        Game game = new(playerNames);
        game.table.PlayRound();
    }

    public static void RunGameWithUI()
    {
        InitWindow(ScreenWidth, ScreenHeight, "Poker");
        SetTargetFPS(60);

        List<string> playerNames = new() { "Alice", "Beth" };
        Game game = new(playerNames);

        while (!WindowShouldClose())
        {
            BeginDrawing();
            ClearBackground(ScreenColour);

            game.Display();

            EndDrawing();
        }
        CloseWindow();
    }
}