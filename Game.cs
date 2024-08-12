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

    private FoldButton foldButton;
    private CallButton callButton;
    private RaiseButton raiseButton;

    private Slider slider;

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

        // Slider
        slider = new Slider(Settings.Slider.PosX, Settings.Slider.PosY, Settings.Slider.Length, Settings.Slider.IsHorizontal);

        // Create buttons
        foldButton = (FoldButton) MakeChoiceButton("Fold");
        callButton = (CallButton) MakeChoiceButton("Call");
        raiseButton = (RaiseButton) MakeChoiceButton("Raise");

    }

    public void Display()
    {
        tableUI.Display();
        foreach (PlayerUI playerUI in playerUIs)
        {
            playerUI.Display();
        }
        foldButton.Render();
        callButton.Render();
        raiseButton.Render();

        slider.Render();
    }

    public void Update()
    {
        Display();
    }

    private Button MakeChoiceButton(string choice)
    {
        int[][] bp = Settings.Button.ButtonPositions;

        Button button = choice switch
        {
            "Fold" => new FoldButton(bp[0][0], bp[0][1]),
            "Call" => new CallButton(bp[1][0], bp[1][1]),
            "Raise" => new RaiseButton(bp[2][0], bp[2][1], slider),
            _ => throw new Exception($"Invalid choice: {choice}"),
        };

        ButtonAction buttonAction = new ButtonAction(choice);
        button.action = buttonAction;
        button.OnClick += () => ExecuteButtonAction(buttonAction);
        return button;
    }

    private void ExecuteButtonAction(ButtonAction buttonAction)
    {
        Console.WriteLine($"{buttonAction.choice} {buttonAction.amount}");
    }
}