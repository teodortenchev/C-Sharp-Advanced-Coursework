﻿using FoodShortage.Core;

namespace FoodShortage
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine();
            engine.Run();
        }
    }
}
