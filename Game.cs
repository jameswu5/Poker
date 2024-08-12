using System;
using Poker.Core;
using Poker.UI;
using static Poker.UI.Settings.Palette;

namespace Poker;

public class Game
{
    public Table table;
    public TableUI tableUI;

    public List<Player> players;
    public List<PlayerUI> playerUIs;

    private readonly int smallBlind;
    private readonly int bigBlind;

    private List<Button> buttons;

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

        // Create buttons
        int[][] bp = Settings.Button.ButtonPositions;
        buttons = new()
        {
            new HoverButton(bp[0][0], bp[0][1], Settings.Button.Width, Settings.Button.Height, White, Beige, Black, "Fold", "Fold", Settings.FontSize),
            new HoverButton(bp[1][0], bp[1][1], Settings.Button.Width, Settings.Button.Height, White, Beige, Black, "Call", "Call", Settings.FontSize),
            new HoverButton(bp[2][0], bp[2][1], Settings.Button.Width, Settings.Button.Height, White, Beige, Black, "Raise", "Raise", Settings.FontSize),
        };
    }

    public void Display()
    {
        tableUI.Display();
        foreach (PlayerUI playerUI in playerUIs)
        {
            playerUI.Display();
        }
        foreach (Button button in buttons)
        {
            button.Render();
        }
    }

    public void Update()
    {
        Display();
    }
}