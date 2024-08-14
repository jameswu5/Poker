using System;
using Raylib_cs;

namespace Poker.UI;

public class TableUI
{
    private readonly Core.Table table;

    public TableUI(Core.Table table)
    {
        this.table = table;
    }

    public void Display()
    {
        DisplayEmptyTable();
        DisplayCommunityCards();
        DisplayPot();
    }

    private static void DisplayEmptyTable()
    {
        // draw the community card borders
        for (int i = 0; i < 5; i++)
        {
            int x = Settings.Card.CommunityCardPositions[i][0] - Settings.Card.Border;
            int y = Settings.Card.CommunityCardPositions[i][1] - Settings.Card.Border;
            int w = Settings.Card.Width + 2 * Settings.Card.Border;
            int h = Settings.Card.Height + 2 * Settings.Card.Border;
            Raylib.DrawRectangle(x, y, w, h, Settings.Palette.Gold);
        }

        // draw the community card positions
        for (int i = 0; i < 5; i++)
        {
            int x = Settings.Card.CommunityCardPositions[i][0];
            int y = Settings.Card.CommunityCardPositions[i][1];
            Raylib.DrawRectangle(x, y, Settings.Card.Width, Settings.Card.Height, Settings.Palette.Black);
        }
    }

    private void DisplayCommunityCards()
    {
        for (int i = 0; i < table.communityCards.Count; i++)
        {
            Image img = Card.GetImage(table.communityCards[i]);
            img.Draw(Settings.Card.CommunityCardPositions[i][0], Settings.Card.CommunityCardPositions[i][1]);
        }
    }

    private void DisplayPot()
    {
        Text.DisplayCentralText($"{table.pot}", Settings.Table.PotFontSize, Settings.Table.PotPosX, Settings.Table.PotPosY, Settings.Table.PotWidth, Settings.Table.PotHeight, Settings.Palette.White);
    }
}