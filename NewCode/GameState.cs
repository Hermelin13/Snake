using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Snake;

public class GameState
{
    public int Score { get; set; }
    public bool IsGameOver { get; set; }
    public const int InitialScore = 5;

    public GameState()
    {
        Score = InitialScore;
        IsGameOver = false;
    }

    public void EatFood()
    {
        Score++;
    }

    public void EndGame()
    {
        IsGameOver = true;
    }
}