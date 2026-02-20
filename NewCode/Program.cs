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
}