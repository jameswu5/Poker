using System;
using Poker.Core;
using Poker.Player;
using Poker.UI;

namespace Poker;

public class Game
{
    public Table table;
    public TableUI tableUI;

    public List<Core.Player> players;
    public List<PlayerUI> playerUIs;

    private FoldButton foldButton;
    private CallButton callButton;
    private RaiseButton raiseButton;

    private Slider slider;

    public Game(List<string> playerNames, int startingChips = 200, int smallBlind = 1, int bigBlind = 2)
    {
        // Slider
        slider = new Slider(Settings.Slider.PosX, Settings.Slider.PosY, Settings.Slider.Length, Settings.Slider.IsHorizontal);

        // Create buttons
        foldButton = (FoldButton) MakeChoiceButton("Fold");
        callButton = (CallButton) MakeChoiceButton("Call");
        raiseButton = (RaiseButton) MakeChoiceButton("Raise");

        Pot pot = new();
        players = new();
        playerUIs = new();

        // For now just stick with humans
        foreach (string name in playerNames)
        {
            CreatePlayer(name, startingChips, pot, Core.Player.Type.Human);
        }

        table = new Table(players, pot, smallBlind, bigBlind);
        tableUI = new TableUI(table);
    }

    public void StartGame()
    {
        table.NewRound();
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

    // This isn't strictly needed but is more convenient
    private void MakeMove(Core.Action action)
    {
        table.MakeMove(action);
    }

    /// <summary>
    /// Creates a player and UI and adds it to the game.
    /// </summary>
    private void CreatePlayer(string name, int chips, Pot pot,  Core.Player.Type type)
    {
        Core.Player player = type switch
        {
            Core.Player.Type.Human => new Human(name, chips, pot, callButton, raiseButton),
            _ => throw new Exception($"Invalid player type: {type}"),
        };

        player.PlayAction += MakeMove;

        players.Add(player);
        playerUIs.Add(new PlayerUI(player, playerUIs.Count));
    }

    private void ExecuteButtonAction(ButtonAction buttonAction)
    {
        Console.WriteLine($"{buttonAction.choice} {buttonAction.amount}");

        if (players[table.playerToMove] is Human player)
        {
            switch (buttonAction.choice)
            {
                case "Fold":
                    player.Decided(new Fold());
                    break;
                case "Call":
                    player.Decided(new Call());
                    break;
                case "Raise":
                    player.Decided(new Raise(buttonAction.amount));
                    break;
                default:
                    throw new Exception($"Invalid choice: {buttonAction.choice}");
            }
        }
    }
}