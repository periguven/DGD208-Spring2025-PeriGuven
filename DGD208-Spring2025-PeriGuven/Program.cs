﻿using DGD208_Spring2025_PeriGuven;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        Game game = new Game();
        await game.GameLoop();
    }
}
