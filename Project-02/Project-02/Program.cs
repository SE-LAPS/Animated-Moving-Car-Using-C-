using System;
using System.Threading;

namespace AnimatedCarInRoad
{
    class Program
    {
        static void Main(string[] args)
        {
            DrawAnimatedCar();
        }

        static void DrawAnimatedCar()
        {
            int xPos = 0;
            while (true)
            {
                Console.Clear();
                DrawRoad();
                DrawCar(xPos);
                xPos++;

                if (xPos >= Console.WindowWidth)
                {
                    xPos = 0;
                }
                Thread.Sleep(100);
            }
        }

        static void DrawCar(int xPos)
        {
            Console.SetCursorPosition(xPos, 12);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("     ______");
            Console.SetCursorPosition(xPos, 13);
            Console.WriteLine("    /   |  \\");
            Console.SetCursorPosition(xPos, 14);
            Console.WriteLine("___/    |   \\___");
            Console.SetCursorPosition(xPos, 15);
            Console.WriteLine("|     -----     |");
            Console.SetCursorPosition(xPos, 16);
            Console.WriteLine("|   __    __    |");
            Console.SetCursorPosition(xPos, 17);
            Console.WriteLine("---|__|--|__|---");
        }


        static void DrawRoad()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("|-----______|   |--__|  |_____-------|   |-----______|   |--__|   |-----______|   |--__|  |_____-------|   |-----______|   |--__|   |-----______|   |--__|  |_____-------|   |-----______|   |--__|\n\n\n");
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n===============================================");
        }
    }
}