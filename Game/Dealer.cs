using System;
using System.Collections.Generic;

namespace Poker.Game;

public class Dealer
{
    public CardCollection deck;

    public Dealer()
    {
        deck = new();
        Reset();
    }

    /// <summary>
    /// Deal a card from the deck.
    /// This card is removed from the deck and returned.
    /// </summary>
    public int DealCard()
    {
        return deck.Pop();
    }

    public void DealHoleCards(IEnumerable<Player> players)
    {
        foreach (Player player in players)
        {
            player.AddCard(DealCard());
            player.AddCard(DealCard());
        }
    }

    public void DealCommunityCards(int cardsToDeal, Table table)
    {
        for (int i = 0; i < cardsToDeal; i++)
        {
            int card = DealCard();
            // add this to the table (not implemented yet)
        }
    }

    public void DealFlop(Table table) => DealCommunityCards(3, table);

    public void DealTurn(Table table) => DealCommunityCards(1, table);

    public void DealRiver(Table table) => DealCommunityCards(1, table);

    /// <summary>
    /// Reset the deck of cards to a full, shuffled deck of 52 cards.
    /// </summary>
    public void Reset()
    {
        deck.CreateStandardDeck();
        deck.Shuffle();
    }
}