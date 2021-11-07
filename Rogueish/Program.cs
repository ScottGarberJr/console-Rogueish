using System;
using Rogueish.logic;

namespace Rogueish
{
    class Program
    {
        static void Main(string[] args)
        {
            
            GameSetup();
            FrameLoop();
        }

        static void GameSetup()
        {
            Console.WriteLine("ROGUE-ISH");// later can be updateScreen() and updateUI()
        }

        static void FrameLoop()
        {
            ConsoleKey input;
            bool quit = false;
            do
            {
                input = Console.ReadKey(true).Key;
                

                Console.Clear();
                Console.WriteLine("ROGUE-ISH");// later can be updateScreen() and updateUI()

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
                    Console.WriteLine("up");//later these instead call some action()
                    break;
                case ConsoleKey.A:
                    Console.WriteLine("left");//later these instead call some action()
                    break;
                case ConsoleKey.S:
                    Console.WriteLine("down");//later these instead call some action()
                    break;
                case ConsoleKey.D:
                    Console.WriteLine("right");//later these instead call some action()
                    break;
                case ConsoleKey.Spacebar:
                    Console.WriteLine("Attack");//later these instead call some action()
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

