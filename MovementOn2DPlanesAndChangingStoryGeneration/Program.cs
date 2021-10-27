using System;

namespace MovementOn2DPlanesAndChangingStoryGeneration
{
    class Program
    {
        static void StartGame()
        {
            BoardFunctions GameBoard = new BoardFunctions();
            GameBoard.BoardGeneration("Terqia");
            Console.WriteLine("You open your eyes to the bright blue sky. How did you get here? You get up, inspecting your surroundings.");

            string command;
            bool playState = true;
            while (playState == true)
            {
                Console.WriteLine("\nWhat direction do you go?");
                command = Console.ReadLine();
                if(command == "quit")
                {
                    playState = false;
                    break;
                }
                else
                {
                    try
                    {
                        Console.Clear();
                        GameBoard.Movement(command[0]);
                    }
                    catch
                    {
                        Console.WriteLine("\n\nYour input was invalid. Either a command was wrong, or you tried to go off the edge of the world.");
                    }
                }

            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Simulation...\n");

            int state = 0;
            while(state != 1 && state != 2)
            {
                try
                {
                    Console.WriteLine("Start (1)\nQuit (2)");
                    state = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Enter a valid input.");
                }
            }
            switch (state)
            {
                case 1:
                    StartGame();
                    break;
                case 2:
                    break;
            }
        }
    }
}
