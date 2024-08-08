using System;
using Raylib_cs;

namespace Poker.UI;

public class TableUI
{
    private readonly Game.Table table;

    public TableUI(Game.Table table)
    {
        this.table = table;
    }

    public void Display()
    {
        DisplayEmptyTable();
        DisplayCommunityCards();
    }

    private void DisplayEmptyTable()
    {
        throw new NotImplementedException();
    }

    private void DisplayCommunityCards()
    {
        throw new NotImplementedException();
    }
}