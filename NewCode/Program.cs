using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace SnakeGame
{
    static class GameConfig
    {
        public const int WINDOW_WIDTH = 32;
        public const int WINDOW_HEIGHT = 16;
        public const int GAME_TICK_MS = 500;
        public const char BORDER_CHAR = '■';
        public const char BODY_CHAR = '■';
        public const char FOOD_CHAR = '■';
    }
    
    static void Main(string[] args)
    {
        // Inicialization
        var renderer = new ConsoleRenderer(GameConfig.WINDOW_WIDTH, GameConfig.WINDOW_HEIGHT);
        renderer.Setup();

        var engine = new GameEngine(GameConfig.WINDOW_WIDTH, GameConfig.WINDOW_HEIGHT);
        var inputHandler = new InputHandler();
        var direction = Direction.Right;
        
        // game loop
        while (!engine.GetState().IsGameOver)
        {
            renderer.Clear();
            renderer.DrawBorders();
            renderer.DrawSnake(engine.GetSnake());
            renderer.DrawFood(engine.GetFood());
            renderer.DrawScore(engine.GetState().Score);

            direction = inputHandler.GetDirection(direction);

            if (inputHandler.ShouldUpdateGame(GameConfig.GAME_TICK_MS))
            {
                engine.Update(direction, GameConfig.WINDOW_WIDTH, GameConfig.WINDOW_HEIGHT);
            }

            System.Threading.Thread.Sleep(10); // CPU friendly delay
        }

        renderer.DrawGameOver(engine.GetState().Score);
}