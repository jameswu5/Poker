
using System;
using static Poker.UI.Settings.Palette;

namespace Poker.UI;

public class FoldButton : HoverButton
{
    public FoldButton(int posX, int posY) : base(posX, posY, Settings.Button.Width, Settings.Button.Height, White, Beige, Black, "Fold", "Fold", Settings.FontSize) {}
}

public class CallButton : HoverButton
{
    public CallButton(int posX, int posY) : base(posX, posY, Settings.Button.Width, Settings.Button.Height, White, Beige, Black, "Call", "Check", Settings.FontSize) {}

    public void UpdateAmount(int amount)
    {
        action.amount = amount;
        text = amount == 0 ? "Check" : $"Call [{amount}]";
    }
}

public class RaiseButton : HoverButton
{
    public RaiseButton(int posX, int posY) : base(posX, posY, Settings.Button.Width, Settings.Button.Height, White, Beige, Black, "Raise", "Raise", Settings.FontSize) {}

    public void UpdateAmount(int amount)
    {
        action.amount = amount;
        text = $"Raise [{amount}]";
    }
}