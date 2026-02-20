using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Snake;

public class Snake
{
    public Position Head { get; set; }
    public List<Position> Body { get; private set; }
    public ConsoleColor Color { get; private set; }

    public Snake(int screenWidth, int screenHeight)
    {
        Head = new Position(screenWidth / 2, screenHeight / 2);
        Body = new List<Position>();
        Color = ConsoleColor.Red;
    }

    public void Move(Direction direction)
    {
        // Automaically grow the body by adding the current head position to the body list
        Body.Insert(0, new Position(Head.X, Head.Y));

        // Move the head in the specified direction
        switch (direction)
        {
            case Direction.Up:
                Head.Y--;
                break;
            case Direction.Down:
                Head.Y++;
                break;
            case Direction.Left:
                Head.X--;
                break;
            case Direction.Right:
                Head.X++;
                break;
        }
    }

    public void TrimBody(int maxLength)
    {
        while (Body.Count >= maxLength)
            Body.RemoveAt(Body.Count - 1);
    }

    public bool CheckSelfCollision()
    {
        return Body.Any(segment => segment.X == Head.X && segment.Y == Head.Y);
    }
}