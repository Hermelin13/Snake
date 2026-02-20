using System;

namespace Snake;

public class InputHandler
{
    private DateTime lastUpdateTime;

    public InputHandler()
    { 
        lastUpdateTime = DateTime.Now;
    }

    public Direction GetDirection(Direction currentDirection)
    { 
        Direction newDirection = currentDirection;

        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);

            // check if the key is an arrow key and not opposite to current direction
            if (CanChangeDirection(key.Key, currentDirection))
            {
                newDirection = ConvertKeyToDirection(key.Key);
            }
        }

        return newDirection;
    }

    private bool CanChangeDirection(ConsoleKey key, Direction current)
    { 
        return (key == ConsoleKey.UpArrow && current != Direction.Down) ||
             (key == ConsoleKey.DownArrow && current != Direction.Up) ||
             (key == ConsoleKey.LeftArrow && current != Direction.Right) ||
             (key == ConsoleKey.RightArrow && current != Direction.Left);
    }

    private Direction ConvertKeyToDirection(ConsoleKey key)
    {
        return key switch
        {
            ConsoleKey.UpArrow => Direction.Up,
            ConsoleKey.DownArrow => Direction.Down,
            ConsoleKey.LeftArrow => Direction.Left,
            ConsoleKey.RightArrow => Direction.Right,
            _ => Direction.Right
        };
    }

    public bool ShouldUpdateGame(int gameTickMs)
    { 
        var now = DateTime.Now;
        if (now.Subtract(lastUpdateTime).TotalMilliseconds >= gameTickMs)
        {
            lastUpdateTime = now;
            return true;
        }

        return false;
    }
}