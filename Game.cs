using System;
using Poker.Core;
using Poker.UI;

namespace Poker;

public class Game
{
    public Table table;
    public TableUI tableUI;

    public List<Player> players;
    public List<PlayerUI> playerUIs;

    private readonly int smallBlind;
    private readonly int bigBlind;

    public Game(List<string> playerNames, int startingChips = 200, int smallBlind = 1, int bigBlind = 2)
    {
        this.smallBlind = smallBlind;
        this.bigBlind = bigBlind;

        Pot pot = new();
        players = new();
        playerUIs = new();
        for (int i = 0; i < playerNames.Count; i++)
        {
            Player player = new(playerNames[i], startingChips, pot);
            players.Add(player);
            playerUIs.Add(new PlayerUI(player, i));
        }
        table = new Table(players, pot, smallBlind, bigBlind);
        tableUI = new TableUI(table);
    }

    public void Display()
    {
        tableUI.Display();
        foreach (PlayerUI playerUI in playerUIs)
        {
            playerUI.Display();
        }
    }

    public void Update()
    {
        Display();
    }
}