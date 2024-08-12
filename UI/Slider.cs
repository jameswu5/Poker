using System;
using Raylib_cs;
using static Poker.UI.Settings.Slider;

namespace Poker.UI;

public class Slider
{
    private enum SliderState
    {
        Idle,
        Dragging
    }

    private readonly int posX;
    private readonly int posY;
    private readonly int length;
    private readonly bool isHorizontal;
    private double val; // 0 to 1

    private bool activated;
    private SliderState state;

    public Slider(int posX, int posY, int length, bool isHorizontal, double val = 0)
    {
        this.posX = posX;
        this.posY = posY;
        this.length = length;
        this.isHorizontal = isHorizontal;
        this.val = val;

        activated = true;
        state = SliderState.Idle;
    }

    public void Render()
    {
        Display();

        if (!activated) return;

        if (state == SliderState.Idle)
        {
            if (Raylib.IsMouseButtonPressed(0) && IsHovered(Raylib.GetMouseX(), Raylib.GetMouseY()))
            {
                state = SliderState.Dragging;
            }
        }
        else if (state == SliderState.Dragging)
        {
            if (Raylib.IsMouseButtonReleased(0))
            {
                state = SliderState.Idle;
            }
            else
            {
                if (isHorizontal)
                {
                    val = (Raylib.GetMouseX() - posX) / (double) length;
                }
                else
                {
                    val = 1 - ((Raylib.GetMouseY() - posY) / (double) length);
                }

                // Clip
                val = Math.Max(0, val);
                val = Math.Min(1, val);
            }
        }
    }

    private bool IsHovered(int x, int y)
    {
        if (isHorizontal)
        {
            return x >= posX && x <= posX + length && y >= posY - Radius + Thickness / 2 && y <= posY + Radius + Thickness / 2;
        }
        else
        {
            return x >= posX - Radius + Thickness / 2 && x <= posX + Radius + Thickness / 2 && y >= posY && y <= posY + length;
        }
    }

    public void Display()
    {
        if (isHorizontal)
        {
            Raylib.DrawRectangle(posX, posY, length, Thickness, Colour);
            Raylib.DrawRectangle(posX, posY, (int)(length * val), Thickness, FilledColour);
            Raylib.DrawCircle(posX + (int)(length * val), posY + Thickness / 2, Radius, FilledColour);
        }
        else
        {
            Raylib.DrawRectangle(posX, posY, Thickness, length, Colour);
            Raylib.DrawRectangle(posX, posY + length - (int)(length * val), Thickness, (int)(length * val), FilledColour);
            Raylib.DrawCircle(posX + Thickness / 2, posY + length - (int)(length * val), Radius, FilledColour);
        }
    }
}