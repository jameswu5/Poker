using System;
using System.Collections.Generic;

namespace Poker.Game;

public class Game
{
    public Table table;

    public int smallBlind;
    public int bigBlind;

    public Game(Table table, int smallBlind, int bigBlind)
    {
        // The table will contain implicitly the players and the pot
        this.table = table;
        this.smallBlind = smallBlind;
        this.bigBlind = bigBlind;
    }
}