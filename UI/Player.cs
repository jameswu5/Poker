using System;
using Raylib_cs;

namespace Poker.UI;

public class PlayerUI
{
    public Core.Player player;
    public int seat; // for now only 0 or 1, as we only support 2 players

    public PlayerUI(Core.Player player, int seat)
    {
        this.player = player;
        this.seat = seat;

        if (seat < 0 || seat > 1)
        {
            throw new Exception("Invalid seat number, only support 2 players.");
        }
    }

    public void Display()
    {
        DisplayPlayerCards(seat == 0);
        DisplayPlayerStack();
    }

    private void DisplayPlayerCards(bool showCards)
    {
        int[][] positions = seat == 0 ? Settings.Card.PlayerHoleCardPositions : Settings.Card.BotHoleCardPositions;

        for (int i = 0; i < player.hand.cards.Count; i++)
        {
            Image img = showCards ? Card.GetImage(player.hand[i]) : Card.back;
            int x = positions[i][0];
            int y = positions[i][1];
            img.Draw(x, y);
        }
    }

    private void DisplayPlayerStack()
    {
        string text = $"Stack: {player.chips}";
        int posY = seat == 0 ? Settings.ScreenHeight - Settings.Card.HoleCardPaddingY : 0;
        Text.DisplayCentralText(text, Settings.FontSize, 0, posY, Settings.ScreenWidth, Settings.Card.HoleCardPaddingY, Settings.Palette.White);
    }
}