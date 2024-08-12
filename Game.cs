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
        buttons = new()
        {
            MakeChoiceButton("Fold"),
            MakeChoiceButton("Call"),
            MakeChoiceButton("Raise")
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

    private Button MakeChoiceButton(string choice)
    {
        int[][] bp = Settings.Button.ButtonPositions;
        int index = choice switch
        {
            "Fold" => 0,
            "Call" => 1,
            "Raise" => 2,
            _ => throw new Exception($"Invalid choice: {choice}"),
        };
        ButtonAction buttonAction = new ButtonAction(choice);
        HoverButton button = new HoverButton(bp[index][0], bp[index][1], Settings.Button.Width, Settings.Button.Height, White, Beige, Black, choice, choice, Settings.FontSize);
        button.action = buttonAction;
        button.OnClick += () => ExecuteButtonAction(buttonAction);
        return button;
    }

    public void ExecuteButtonAction(ButtonAction buttonAction)
    {
        Console.WriteLine($"{buttonAction.choice} {buttonAction.amount}");
    }
}