using System;
using Raylib_cs;

namespace Poker.UI;

public static class Settings
{
    public const int ScreenWidth = 1080;
    public const int ScreenHeight = 720;
    public static readonly Color ScreenColour = new(41, 40, 35, 255);

    public static class Palette
    {
        public static readonly Color White = new(255, 255, 255, 255);
    }
}