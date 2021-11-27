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
                    Console.Clear();
                    GameBoard.Movement(command[0]);
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
                    Console.WriteLine("\nStart (1)\nQuit (2)\n");
                    state = Int32.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("\nDo you not know your numbers?");
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
