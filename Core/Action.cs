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

public class Null : Action
{
    public Null() : base(0) {}

    public override string ToString()
    {
        return "Null";
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
        return amount == 0 ? "Check" : $"Call";
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