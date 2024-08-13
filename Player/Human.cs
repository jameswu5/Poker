using System;

namespace Poker.Player;

public class Human : Core.Player
{
    public Human(string name, int chips, Core.Pot pot) : base(name, chips, pot) {}

    public override void TurnToMove()
    {
        isActive = true;
    }

    public override void Update() {}
}