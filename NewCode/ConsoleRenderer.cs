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

}