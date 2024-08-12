using System;
using System.Numerics;
using Raylib_cs;

namespace Poker.UI;

public static class Text
{
    private const string FontPath = "UI/fonts/Roboto-Bold.ttf";
    private static Font font = Raylib.LoadFont(FontPath);
    private const float spacing = 1f;

    /// <summary>
    /// Display text in the centre of the box defined by the parameters.
    /// </summary>
    public static void DisplayCentralText(string text, int fontSize, int posX, int posY, int width, int height, Color colour)
    {
        (int x, int y) = GetTextPositions(text, width, height, fontSize);
        Raylib.DrawTextEx(font, text, new Vector2(x + posX, y + posY), fontSize, spacing, colour);
    }

    /// <summary>
    /// Get the coordinates to display text in the centre of the box defined by the parameters.
    /// </summary>
    public static (int, int) GetTextPositions(string text, int width, int height, int fontSize)
    {
        Vector2 textSize = Raylib.MeasureTextEx(font, text, fontSize, spacing);
        int x = (width - (int)textSize.X) >> 1;
        int y = (height - (int)textSize.Y) >> 1;
        return (x, y);
    }
}