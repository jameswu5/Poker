using System;
using System.Collections.Generic;

namespace Poker.Core;

public abstract class Action
{
    public int amount;

    public Action(int amount)
    {
        this.amount = amount;
    }
}

public class Fold : Action
{
    public Fold() : base(0) {}

    public override string ToString()
    {
        return "Fold";
    }
}

public class Call : Action
{
    public Call(int amount) : base(amount) {}

    public override string ToString()
    {
        return amount switch
        {
            -1 => "All In",
            0 => "Check",
            _ => $"Call {amount}",
        };
    }
}

public class Raise : Action
{
    public Raise(int amount) : base(amount) {}

    public override string ToString()
    {
        return $"Raise {amount}";
    }
}