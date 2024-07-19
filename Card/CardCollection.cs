using System;
using System.Collections.Generic;

namespace Poker;

public class CardCollection
{
    private static readonly char[] Ranks = {'2', '3', '4', '5', '6', '7', '8', '9', 'T', 'J', 'Q', 'K', 'A'};
    private static readonly char[] Suits = {'S', 'H', 'D', 'C'};

    public List<int> cards;

    public CardCollection()
    {
        cards = new List<int>();
    }

    public void Add(int card)
    {
        cards.Add(card);
    }

    public int Peek()
    {
        return cards[^1];
    }

    public int Pop()
    {
        int card = Peek();
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
        foreach (int card in cards)
        {
            Card.Display(card);
        }
    }
}