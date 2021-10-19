using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MovementOn2DPlanesAndChangingStoryGeneration
{
    class StoryUtils
    {
        public static void StoryGeneration(int terrain)
        {
            //Will grab a random story according to the terrain and give options. Will interact with inventory when implemented.

            string terrainfile;

            switch (terrain)
            {
                case 1:
                    terrainfile = @".\TerrainStories\Grasslands.txt";
                    break;
                case 2:
                    terrainfile = @".\TerrainStories\Forest.txt";
                    break;
                case 3:
                    terrainfile = @".\TerrainStories\Desert.txt";
                    break;
                case 4:
                    terrainfile = @".\TerrainStories\Tundra.txt";
                    break;
                case 5:
                    terrainfile = @".\TerrainStories\City.txt";
                    break;
                case 6:
                    terrainfile = @".\TerrainStories\Swamp.txt";
                    break;
                case 7:
                    terrainfile = @".\TerrainStories\Blight.txt";
                    break;
                case 8:
                    terrainfile = @".\TerrainStories\Pixie.txt";
                    break;

                default:
                    terrainfile = @".\TerrainStories\Grasslands.txt";
                    break;
            }

            using (StreamReader storystream = new StreamReader(terrainfile))
            {
                Random randnum = new Random();
                Console.WriteLine(storystream.ReadLine());
            }
        }
    }
}
