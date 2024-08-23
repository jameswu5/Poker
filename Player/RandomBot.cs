using System;

namespace Poker.Player;

public class RandomBot : Bot
{
    public const string Name = "RandomBot";

    public const int FoldPercentage = 20;

    private readonly Random rng;

    public RandomBot(int chips, Core.Pot pot) : base(Name, chips, pot)
    {
        rng = new();
    }

    public override void ChooseMove()
    {
        // For now, choose a random move between fold and call
        int choice = rng.Next(100);
        if (choice < FoldPercentage)
        {
            chosenMove = new Core.Fold();
        }
        else
        {
            chosenMove = new Core.Call(GetAmountToCall());
        }
        moveFound = true;
    }
}