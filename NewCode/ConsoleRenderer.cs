using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Snake;

public class ConsoleRenderer
{
    private int screenWidth;
    private int screenHeight;

    public ConsoleRenderer(int width, int height)
    {
        screenWidth = width;
        screenHeight = height;
    }

    public void Setup()
    {
        Console.WindowHeight = screenHeight;
        Console.WindowWidth = screenWidth;
    }

    public void Clear()
    {
        Console.Clear();
    }
    
    public void DrawBorders()
    {
        // top and bottom borders
        DrawHorizontalLine(0);
        DrawHorizontalLine(screenHeight - 1);

        // left and right borders
        DrawVerticalLine(0);
        DrawVerticalLine(screenWidth - 1);
    }

    private void DrawHorizontalLine(int y)
    {
        Console.SetCursorPosition(0, y);
        for (int x = 0; x < screenWidth; x++)
            Console.Write(GameConfig.BORDER_CHAR);
    }

    private void DrawVerticalLine(int x)
    {
        for (int y = 0; y < screenHeight; y++)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(GameConfig.BORDER_CHAR);
        }
    }
    
    public void DrawSnake(Snake snake)
    {
        Console.ForegroundColor = snake.Color;

        // head
        Console.SetCursorPosition(snake.Head.X, snake.Head.Y);
        Console.Write(GameConfig.BODY_CHAR);

        // body
        foreach (var segment in snake.Body)
        {
            Console.SetCursorPosition(segment.X, segment.Y);
            Console.Write(GameConfig.BODY_CHAR);
        }
    }

    public void DrawFood(Food food)
    {
        Console.ForegroundColor = food.Color;
        Console.SetCursorPosition(food.Position.X, food.Position.Y);
        Console.Write(GameConfig.FOOD_CHAR);
    }

    public void DrawScore(int score)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.SetCursorPosition(0, screenHeight - 1);
        Console.Write($"Score: {score}");
    }

    public void DrawGameOver(int score)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.SetCursorPosition(screenWidth / 5, screenHeight / 2);
        Console.WriteLine($"Game Over! Score: {score}");
        Console.SetCursorPosition(screenWidth / 5, screenHeight / 2 + 1);
        Console.ReadKey();
    }

}