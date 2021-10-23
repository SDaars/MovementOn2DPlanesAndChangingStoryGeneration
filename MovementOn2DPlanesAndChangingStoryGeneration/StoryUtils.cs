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
                case 0:
                    terrainfile = @".\TerrainStories\Grasslands.txt";
                    break;
                case 1:
                    terrainfile = @".\TerrainStories\Forest.txt";
                    break;
                case 2:
                    terrainfile = @".\TerrainStories\Desert.txt";
                    break;
                case 3:
                    terrainfile = @".\TerrainStories\Tundra.txt";
                    break;
                case 4:
                    terrainfile = @".\TerrainStories\City.txt";
                    break;
                case 5:
                    terrainfile = @".\TerrainStories\Swamp.txt";
                    break;
                case 6:
                    terrainfile = @".\TerrainStories\Blight.txt";
                    break;
                case 7:
                    terrainfile = @".\TerrainStories\Pixie.txt";
                    break;

                default:
                    Console.WriteLine("Defaulted file path. Possible errors in TerrainChecker method.");
                    terrainfile = @".\TerrainStories\Grasslands.txt";
                    break;
            }
            Console.WriteLine(terrainfile);

            //Performing actions with file contents
            using (StreamReader storystream = new StreamReader(terrainfile))
            {
                Random randnum = new Random();

                //Moving to random line, must implement total line calculator before use
                /*for (int i = 0; i < 1; i++)
                {

                    Console.WriteLine(storystream.ReadLine());
                }*/

                //Interpreting story type
                string longformstory = storystream.ReadLine();
                char storytype = longformstory[0];
                string storycontent;

                switch (storytype)
                {
                    case 'A':
                        storycontent = (longformstory.Replace("\"", "")).Substring(1);
                        Console.WriteLine(storycontent);
                        break;
                    default:
                        Console.WriteLine("Defaulted story. Possible errors in defined story type for story:\n" + longformstory);
                        break;
                }
                    
                }
            }
        }
    }
