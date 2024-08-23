using System;
using Raylib_cs;

namespace Poker.UI;

public static class Settings
{
    public const int ScreenWidth = 1080;
    public const int ScreenHeight = 720;
    public static readonly Color ScreenColour = Palette.Black;

    public const int FontSize = 28;

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

        public static readonly Color Pressed = new(0, 0, 0, 50);
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

        // Calculate positions of each player hole card (not the border box)
        public const int HoleCardPaddingY = 60;
        private const int LeftCardWidthPercent = 40;
        private const int LeftCardWidth = Width * LeftCardWidthPercent / 100;
        private const int HoleCardWidth = LeftCardWidth + Width;

        public static readonly int[][] PlayerHoleCardPositions = new int[][]
        {
            new int[] {(ScreenWidth - HoleCardWidth) / 2, ScreenHeight - Height - HoleCardPaddingY},
            new int[] {(ScreenWidth - HoleCardWidth) / 2 + LeftCardWidth, ScreenHeight - Height - HoleCardPaddingY},
        };

        public static readonly int[][] BotHoleCardPositions = new int[][]
        {
            new int[] {(ScreenWidth - HoleCardWidth) / 2, HoleCardPaddingY},
            new int[] {(ScreenWidth - HoleCardWidth) / 2 + LeftCardWidth, HoleCardPaddingY},
        };
    }

    public static class Button
    {
        public const int Width = 180;
        public const int Height = 50;
        public const int HeightPadding = 20;

        public const int BottomPadding = 40;
        public const int SidePadding = 100;

        // Calculate positions of each button
        public const int PosX = ScreenWidth - Width - SidePadding;
        public const int PosY = ScreenHeight - BottomPadding - 3 * Height - 2 * HeightPadding;

        public static readonly int[][] ButtonPositions = new int[][]
        {
            new int[] {PosX, PosY},
            new int[] {PosX, PosY + Height + HeightPadding},
            new int[] {PosX, PosY + 2 * (Height + HeightPadding)},
        };
    }

    public class Slider
    {
        public const int PosX = ScreenWidth - Button.SidePadding / 2;
        public const int PosY = Button.PosY;
        public const int Length = 3 * Button.Height + 2 * Button.HeightPadding;
        public const bool IsHorizontal = false;
        public const int Thickness = 6;
        public const int Radius = 8;
        public static readonly Color Colour = Palette.White;
        public static readonly Color FilledColour = Palette.Gold;
    }

    public class Table
    {
        // Define the box in which the text is to be centred
        public const int PotFontSize = 32;
        public const int PotPosX = 0;
        public const int PotPosY = ScreenHeight / 2 - Card.Height / 2;
        public static readonly int PotWidth = Card.CommunityCardPositions[0][0] - Card.Border;
        public static readonly int PotHeight = Card.Height;


        // Button positions
        public const int ButtonRadius = 20;
        public static readonly Color ButtonColour = Palette.Gold;
        private const int Padding = 15;
        private static readonly int ButtonCentreX = Card.PlayerHoleCardPositions[1][0] + Card.Width + Padding + ButtonRadius;
        public static readonly int[][] ButtonCentres = new int[][]
        {
            new int[] {ButtonCentreX, Card.PlayerHoleCardPositions[0][1] + ButtonRadius},
            new int[] {ButtonCentreX, Card.BotHoleCardPositions[0][1] + ButtonRadius},
        };

        public const int TurnBarPadding = 10;
        public const int TurnBarWidth = 5;
    }

    public class Match
    {
        public const int PosX = 50;
        public const int PosY = 50;
        public const int Padding = 20;
        public const int FontSize = 28;
        public static readonly Color Colour = Palette.White;

        public static readonly int[][] ResultPositions = new int[][]
        {
            new int[] {PosX, PosY},
            new int[] {PosX, PosY + FontSize + Padding}
        };
    }
}