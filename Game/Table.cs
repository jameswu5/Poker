using System;
using System.Collections.Generic;

namespace Poker.Game;

public class Table
{
    public List<Player> players;
    public Dealer dealer;

    public List<int> communityCards;

    public Table(List<Player> players)
    {
        this.players = players;
        dealer = new();
        communityCards = new();
    }

    public void AddCommunityCard(int card)
    {
        communityCards.Add(card);
    }
}