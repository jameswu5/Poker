using System;
using System.Collections.Generic;

namespace Poker.Game;

public static class Game
{
    public static void Run()
    {
        Pot pot = new();
        List<Player> players = new()
        {
            new Player("Alice", 200, pot),
            new Player("Bob", 200, pot),
            new Player("Charlie", 200, pot)
        };

        Table table = new(players, pot, 1, 2);
        table.PlayRound();
    }
}