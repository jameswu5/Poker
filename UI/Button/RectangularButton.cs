using System;
using Raylib_cs;

namespace Poker.UI;

/// <summary>
/// An invisible button with rectangular hitboxes.
/// </summary>
public class RectangularButton : Button
{
    protected readonly int posX;
    protected readonly int posY;
    protected readonly int height;
    protected readonly int width;

    public RectangularButton(int posX, int posY, int width, int height, string? name = null, string? text = null, Color? textColour = null, int? fontSize = null) : base(name, text, textColour, fontSize)
    {
        this.posX = posX;
        this.posY = posY;
        this.height = height;
        this.width = width;
    }

    protected override bool IsHovered(float x, float y) => x >= posX && x <= posX + width && y >= posY && y <= posY + height;

    protected override void PressedDisplay()
    {
        HoverDisplay();
        Raylib.DrawRectangle(posX, posY, width, height, Settings.Palette.Pressed);
    }

    protected override void DisplayText()
    {
        if (text.Length == 0) return;
        Text.DisplayCentralText(text, fontSize, posX, posY, width, height, textColour);
    }
}