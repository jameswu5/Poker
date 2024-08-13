using System;

namespace Poker.Player;

public class Human : Core.Player
{
    UI.CallButton callButton;
    UI.RaiseButton raiseButton;

    public Human(string name, int chips, Core.Pot pot, UI.CallButton callButton, UI.RaiseButton raiseButton) : base(name, chips, pot)
    {
        this.callButton = callButton;
        this.raiseButton = raiseButton;
    }

    public override void TurnToMove()
    {
        isActive = true;

        // Update button amounts
        callButton.UpdateAmount(GetAmountToCall());
        raiseButton.Reset(GetAmountToCall() + 1, chips);
    }

    public override void Update() {}
}