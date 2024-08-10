using System;

namespace Poker.UI;

public static class Card
{
    public static readonly List<Image> images;
    public static readonly Image back;

    public static readonly Dictionary<char, int> SuitMap = new()
    {
        { 'S', 0 },
        { 'H', 1 },
        { 'C', 2 },
        { 'D', 3 }
    };

    public static readonly Dictionary<char, int> RankMap = new()
    {
        { 'A', 0 },
        { '2', 1 },
        { '3', 2 },
        { '4', 3 },
        { '5', 4 },
        { '6', 5 },
        { '7', 6 },
        { '8', 7 },
        { '9', 8 },
        { 'T', 9 },
        { 'J', 10 },
        { 'Q', 11 },
        { 'K', 12 },
    };

    static Card()
    {
        images = new List<Image>();
        for (int i = 1; i <= 52; i++)
        {
            string path = $"img/cards/{i}.png";
            images.Add(new Image(path, Settings.Card.Width, Settings.Card.Height));
        }

        back = new Image("img/cards/back.png", Settings.Card.Width, Settings.Card.Height);
    }

    public static Image GetImage(int card)
    {
        char rank = Poker.Card.GetRank(card);
        char suit = Poker.Card.GetSuit(card);

        return images[SuitMap[suit] * 13 + RankMap[rank]];
    }
}