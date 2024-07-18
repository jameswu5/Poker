using System;
using System.Collections.Generic;

namespace Poker;

public class CardCollection
{
    private static readonly char[] Ranks = {'2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K', 'A'};
    private static readonly char[] Suits = {'S', 'H', 'D', 'C'};

    public List<uint> cards;

    public CardCollection()
    {
        cards = new List<uint>();
    }

    public void Add(uint card)
    {
        cards.Add(card);
    }

    public uint Peek()
    {
        return cards[^1];
    }

    public uint Pop()
    {
        uint card = Peek();
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
        foreach (uint card in cards)
        {
            Card.Display(card);
        }
    }
}