using System;
using System.Collections.Generic;

namespace Poker.Game;

public abstract class Action {}

public class Fold : Action
{
    public override string ToString()
    {
        return "Fold";
    }
}

public class Call : Action
{
    public override string ToString()
    {
        return "Call";
    }
}

public class Raise : Action
{
    public int amount;

    public Raise(int amount)
    {
        this.amount = amount;
    }

    public override string ToString()
    {
        return $"Raise {amount}";
    }
}