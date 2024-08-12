
namespace Poker.UI;

public class ButtonAction
{
    public string choice;
    public int amount;

    public ButtonAction(string choice, int amount = 0)
    {
        this.choice = choice;
        this.amount = amount;
    }
}