
using System;
using Raylib_cs;
using static Raylib_cs.Raylib;
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
    private int minBet;
    private int maxBet;
    private readonly Slider slider;

    public RaiseButton(int posX, int posY, Slider slider) : base(posX, posY, Settings.Button.Width, Settings.Button.Height, White, Beige, Black, "Raise", "Raise", Settings.FontSize)
    {
        // placeholder values
        minBet = 0;
        maxBet = 200;
        this.slider = slider;
    }

    public void UpdateAmount(int amount)
    {
        action.amount = amount;
        text = $"Raise [{amount}]";
    }

    protected override void Display()
    {
        UpdateAmount((int)(minBet + (maxBet - minBet) * slider.val));
        DrawRectangle(posX, posY, width, height, colour);
        DisplayText();
    }

    protected override void HoverDisplay()
    {
        UpdateAmount((int)(minBet + (maxBet - minBet) * slider.val));
        DrawRectangle(posX, posY, width, height, hoverColour);
        DisplayText();
    }
}