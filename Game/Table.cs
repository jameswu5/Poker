using System;
using System.Collections.Generic;

namespace Poker.Game;

public class Table
{
    public List<Player> players;
    public Dealer dealer;
    public Pot pot;

    public List<int> communityCards;

    public Table(List<Player> players, Pot pot)
    {
        this.players = players;
        dealer = new();
        this.pot = pot;
        communityCards = new();
    }

    public void AddCommunityCard(int card)
    {
        communityCards.Add(card);
    }
}