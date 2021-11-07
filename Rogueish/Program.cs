using System;
using Rogueish.logic;

namespace Rogueish
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Map map = GameSetup();
            map.Update();
            FrameLoop(ref map);
        }

        static Map GameSetup()
        {
            Console.WriteLine("ROGUE-ISH");// later can be updateScreen() and updateUI()
            return new Map("test");
        }

        static void FrameLoop(ref Map map)
        {
            ConsoleKey input;
            bool quit = false;
            do
            {
                input = Console.ReadKey(true).Key;
                

                Console.Clear();
                Console.WriteLine("ROGUE-ISH");// later can be updateScreen() and updateUI()
                map.Update();

                Controls(input, ref quit);
            }
            while (!quit);
        }

        static void Controls(ConsoleKey input, ref bool quit)
        {
            /*
             * Add keyboard inputs here and their corresponding action()
             */

            //ConsoleKeyInfo input = Console.ReadKey(true);
            switch (input)
            {
                case ConsoleKey.W:
                    Console.WriteLine("up");//tests input
                    break;
                case ConsoleKey.A:
                    Console.WriteLine("left");//tests input
                    break;
                case ConsoleKey.S:
                    Console.WriteLine("down");//tests input
                    break;
                case ConsoleKey.D:
                    Console.WriteLine("right");//tests input
                    break;
                case ConsoleKey.Spacebar:
                    Console.WriteLine("Attack");//tests input
                    break;
                case ConsoleKey.Escape://this control will terminate the main loop and end the game
                    quit = true;
                    break;
                default:
                    break;

            }
            //Console.WriteLine();
            
        }
    }

}

