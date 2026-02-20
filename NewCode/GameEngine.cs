using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Snake;

public class GameEngine
{
    private Snake snake;
    private Food food;
    private GameState state;
    private Random random;

    public GameEngine(int screenWidth, int screenHeight)
    {
        snake = new Snake(screenWidth, screenHeight);
        food = new Food();
        state = new GameState();
        random = new Random();
        RegenerateFood(screenWidth, screenHeight);
    }

    public void Update(Direction direction, int screenWidth, int screenHeight)
    {
        // move snake
        snake.Move(direction);

        // check for wall collision
        if (IsOutOfBounds(snake.Head, screenWidth, screenHeight))
        {
            state.EndGame();
            return;
        }

        // check for self collision
        if (snake.CheckSelfCollision())
        {
            state.EndGame();
            return;
        }

        // check for food collision
        if (CheckFoodCollision())
        {
            state.EatFood();
            RegenerateFood(screenWidth, screenHeight);
        }
        else
        {
            // if no food eaten, trim the body to maintain the current length
            snake.TrimBody(state.Score);
        }
    }

    private bool CheckFoodCollision()
    {
        return snake.Head.X == food.Position.X &&
               snake.Head.Y == food.Position.Y;
    }

    private bool IsOutOfBounds(Position pos, int width, int height)
    {
        return pos.X == 0 || pos.X == width - 1 ||
               pos.Y == 0 || pos.Y == height - 1;
    }

    private void RegenerateFood(int maxX, int maxY)
    {
        food.Regenerate(random, maxX, maxY);
    }

    // Getters
    public Snake GetSnake() => snake;
    public Food GetFood() => food;
    public GameState GetState() => state;
}