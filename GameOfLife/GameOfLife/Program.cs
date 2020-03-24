using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace GameOfLife
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Convay’s Game of Life!");
            bool[,] grid = new bool[20, 20];
            grid[1, 1] = true;
            grid[1, 2] = true;
            grid[1, 3] = true;
            DisplayGrid(grid, 0);
            const int FPS = 24; // Frames per second
            for(int i = 1; i < 100; i++)
            {
                Thread.Sleep(1000/FPS);
                grid = CalculateNewGeneration(grid);
                DisplayGrid(grid, i);
                if (AliveCellsInGrid(grid) <= 0)
                    break;
            }
        }

        private static bool[,] CalculateNewGeneration(bool[,] grid)
        {
            bool[,] newGrid = new bool[20, 20];
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    int AliveNeighbours = GetAliveNeighboursCount(x, y, grid);
                    if (grid[x, y] == true)
                    {
                        newGrid[x, y] = AliveNeighbours == 2;
                    }
                    else
                    {
                        newGrid[x, y] = AliveNeighbours == 3;
                    }
                }

            }
            return newGrid;
        }

        private static void DisplayGrid(bool[,] grid, int generationNumber)
        {
            Console.Clear();
            int aliveCells = 0;
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    Console.Write(grid[x, y] ? "X" : ".");
                    if (grid[x, y])
                        aliveCells++;
                }
                Console.WriteLine("");
            }
            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Generation number: {generationNumber}");
        }

        private static int AliveCellsInGrid(bool[,] grid)
        {
            int aliveCells = 0;
            for (int x = 0; x < 20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    if (grid[x, y])
                        aliveCells++;
                }
            }
            return aliveCells;
        }

        public static int GetAliveNeighboursCount(int x,int y,bool [,] grid)
        {
            int count = 0;
            int n = 20;
            if (grid[(x - 1 + n) % n, (y - 1 + n) % n] == true)
                count++;
            if (grid[x, (y - 1 + n) % n] == true)
                count++;
            if (grid[(x + 1)%n, (y - 1 + n) % n] == true)
                count++;
            if (grid[(x - 1 + n) % n, y] == true)
                count++;
            if (grid[(x + 1) % n, y] == true)
                count++;
            if (grid[(x - 1 + n) % n, (y + 1) % n] == true)
                count++;
            if (grid[x, (y + 1) % n] == true)
                count++;
            if (grid[(x + 1) % n, (y + 1) % n] == true)
                count++;
            return count;
        }
    }
}
