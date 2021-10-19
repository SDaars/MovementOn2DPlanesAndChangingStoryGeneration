using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MovementOn2DPlanesAndChangingStoryGeneration
{
    class BoardFunctions
    {
        const int BoardSize = 11;
        //Movement planes
        int x { get; set; } = 6;
        int y { get; set; } = 6;

        public void BoardGeneration(string name)
        {
            //Generating Terrain
            //Possible Terrains: Grassland, Forest, Desert, Tundra, City, Swamp, Blight, Pixie
            using (StreamWriter BoardStream = new StreamWriter("GameBoard.txt"))
            {
                Random ranterrain = new Random();
                int interval = 0;
                while (interval < BoardSize)
                {
                    for (int i = 0; i < BoardSize; i++)
                    {
                        int randnum = ranterrain.Next(7);
                        BoardStream.Write(randnum);
                    }
                    BoardStream.Write("\n");
                    interval++;
                }
            }

            Console.WriteLine("This is the gameboard:");
            using (StreamReader BoardReader = new StreamReader("GameBoard.txt"))
            {
                int count = 0;
                string line;
                while ((line = BoardReader.ReadLine()) != null)
                {
                    count++;
                    Console.WriteLine(line);
                }
            }

        }

        private int TerrainChecker()
        {
            //Will check the terrain and return an int for the other methods to use. 
            using (StreamReader BoardReader = new StreamReader("GameBoard.txt"))
            {
                for (int i = 1; i < y; i++)
                {
                    BoardReader.ReadLine();
                }
                string boardrow = BoardReader.ReadLine();

                Console.WriteLine(boardrow[(x - 1)]);
                return boardrow[x];
            }
        }

        public void Movement(char direction) //out string story, out char storytype)
        {
            //Movement block
            switch (direction)
            {
                case 'N':
                    Console.WriteLine("Going North...");
                    y--;
                    break;
                case 'S':
                    Console.WriteLine("Going South...");
                    y++;
                    break;
                case 'E':
                    Console.WriteLine("Going East...");
                    x--;
                    break;
                case 'W':
                    Console.WriteLine("Going West...");
                    x++;
                    break;
            }
            int terrain = TerrainChecker();
            StoryUtils.StoryGeneration(terrain);

        }
    }
}

