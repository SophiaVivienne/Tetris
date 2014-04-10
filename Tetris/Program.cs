using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tetris
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.CursorVisible = false;

            Console.Title = "Tetris ||by: Sophie";

            Console.WriteLine("Irányítás:\n");
            Console.WriteLine("↑ - Letesz");
            Console.WriteLine("↓ - Lentebb visz"); 
            Console.WriteLine("→ - Jobbra visz");
            Console.WriteLine("← - Balra visz");
            Console.BackgroundColor = ConsoleColor.Blue;

            Console.ReadKey();
        }
    }
}
