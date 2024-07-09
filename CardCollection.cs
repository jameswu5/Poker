using System;
using System.Collections.Generic;

namespace Poker;

public class CardCollection
{
    private static readonly char[] Ranks = {'2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K', 'A'};
    private static readonly char[] Suits = {'S', 'H', 'D', 'C'};

    public List<ulong> cards;

    public CardCollection()
    {
        cards = new List<ulong>();
    }

    public void Add(ulong card)
    {
        cards.Add(card);
    }

    public ulong Peek()
    {
        return cards[^1];
    }

    public ulong Pop()
    {
        ulong card = Peek();
        cards.RemoveAt(cards.Count - 1);
        return card;
    }

    public void Clear()
    {
        cards.Clear();
    }

    public void CreateStandardDeck()
    {
        Clear();
        foreach (char rank in Ranks)
        {
            foreach (char suit in Suits)
            {
                cards.Add(Card.CreateCard(rank, suit));
            }
        }
    }

    // Fisher-Yates shuffle
    public void Shuffle()
    {
        Random rng = new();
        for (int n = cards.Count - 1; n > 0; n--)
        {
            int k = rng.Next(n+1);
            (cards[n], cards[k]) = (cards[k], cards[n]);
        }
    }

    public void Display()
    {
        foreach (ulong card in cards)
        {
            Card.Display(card);
        }
    }
}