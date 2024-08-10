using System;
using Poker.Core;
using Poker.UI;

namespace Poker;

public class Game
{
    public Table table;
    public TableUI tableUI;

    private readonly int smallBlind;
    private readonly int bigBlind;

    public Game(List<string> playerNames, int startingChips = 200, int smallBlind = 1, int bigBlind = 2)
    {
        this.smallBlind = smallBlind;
        this.bigBlind = bigBlind;

        Pot pot = new();
        List<Player> players = new();
        foreach (string name in playerNames)
        {
            players.Add(new Player(name, startingChips, pot));
        }
        table = new Table(players, pot, smallBlind, bigBlind);
        tableUI = new TableUI(table);
    }

    public void Display()
    {
        tableUI.Display();
    }

    public void Update()
    {
        Display();
    }
}