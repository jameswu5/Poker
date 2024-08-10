using System;
using Raylib_cs;

namespace Poker.UI;

public static class Settings
{
    public const int ScreenWidth = 1080;
    public const int ScreenHeight = 720;
    public static readonly Color ScreenColour = Palette.Black;

    public static class Palette
    {
        public static Color ParseHexCode(string hexCode, int alpha = 255)
        {
            if (hexCode.Length != 6)
            {
                throw new Exception($"Colour code {hexCode} not of correct length.");
            }

            int r = Convert.ToInt32(hexCode.Substring(0, 2), 16);
            int g = Convert.ToInt32(hexCode.Substring(2, 2), 16);
            int b = Convert.ToInt32(hexCode.Substring(4, 2), 16);

            return new Color(r, g, b, alpha);
        }

        public static readonly Color White = ParseHexCode("f8f8f8");
        public static readonly Color Beige = ParseHexCode("faebcd");
        public static readonly Color Gold = ParseHexCode("f7c873");
        public static readonly Color Black = ParseHexCode("434343");

    }

    public static class Card
    {
        public const int Width = 100;
        public const int Height = 150;
        public const int Border = 8;
        public const int Spacing = 12;

        // Calculate positions of each community card (not the border box)

        private const int CCardPosX = ScreenWidth / 2 - Width / 2;
        private const int CCardPosY = ScreenHeight / 2 - Height / 2;
        private const int CCardSpacing = Width + Spacing + 2 * Border;

        public static readonly int[][] CommunityCardPositions = new int[][]
        {
            new int[] {CCardPosX - CCardSpacing * 2, CCardPosY},
            new int[] {CCardPosX - CCardSpacing, CCardPosY},
            new int[] {CCardPosX, CCardPosY},
            new int[] {CCardPosX + CCardSpacing, CCardPosY},
            new int[] {CCardPosX + CCardSpacing * 2, CCardPosY},
        };
    }
}