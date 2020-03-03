using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Convay’s Game of Life!");
            bool[,] grid = new bool[20, 20];
            grid[1, 1] = true;
            for(int x= 0;x <20; x++)
            {
                for (int y = 0; y < 20; y++)
                {
                    if (grid[x, y] = false)
                    {
                        Console.Write("X");
                    }

                    else if (grid[x,y] = true)
                    {
                        Console.Write(".");
                    }

                }
                Console.WriteLine("");
            }
        }
    }
}
