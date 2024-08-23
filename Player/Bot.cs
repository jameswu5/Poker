using System;
using System.Threading;

namespace Poker.Player;

public abstract class Bot : Core.Player
{
    protected bool moveFound;
    protected Core.Action chosenMove;

    public Bot(string name, int chips, Core.Pot pot) : base(name, chips, pot)
    {
        moveFound = false;
        chosenMove = new Core.Null();
    }

    public static Bot GetBotFromBotType(Type type, int chips, Core.Pot pot)
    {
        return type switch
        {
            Type.RandomBot => new RandomBot(chips, pot),
            Type.Human => throw new Exception("Tried to create a bot with Player.Type.Human"),
            _ => throw new NotImplementedException()
        };
    }

    public override void TurnToMove()
    {
        isActive = true;
        moveFound = false;
        Thread backgroundThread = new(ChooseMove);
        backgroundThread.Start();
    }

    public override void Update()
    {
        if (!isActive) return;

        if (moveFound)
        {
            moveFound = false;
            Decided(chosenMove);
        }
    }

    public abstract void ChooseMove();
}