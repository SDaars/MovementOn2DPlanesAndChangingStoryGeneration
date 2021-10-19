using System;

namespace MovementOn2DPlanesAndChangingStoryGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Simulation...\n");
            //Create a 2D plane. For each increment/decrement on the X or Y axis, have a random story.
            //For specific places, give a predefined area story and options to interact with the surroundings.
            //Hold stories in a file

            BoardFunctions GameBoard = new BoardFunctions();
            GameBoard.BoardGeneration("Terqia");
            Console.WriteLine("You open your eyes to the bright blue sky. How did you get here? You get up, inspecting your surroundings.\nWhat direction do you go?");
            GameBoard.Movement('N');
            Console.ReadLine();
        }
    }
}
