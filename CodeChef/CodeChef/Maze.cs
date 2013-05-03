using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using CodeChef.Helper;

namespace CodeChef
{
    /*
     Problem Input is the Maze."C:\Users\ldsouza\documents\visual studio 2010\Projects\ConsoleApplication2\ConsoleApplication2\File\Maze.txt"
     * Get all the paths from start to finish and the shortest path.
     */
    class Maze
    {
        static string[] data;
        static string filename = @"C:\Users\ldsouza\documents\visual studio 2010\Projects\ConsoleApplication2\ConsoleApplication2\File\Maze10X10.txt";
        public static void MazeProblem()
        {
            data = FileReader.ReadFileToStringArray(filename);

            Position start = GetStartPoint(data);

            Travel(start);

            Console.Read();
     
        }

        private static bool Travel(Position currposi,TravelRoute route=TravelRoute.Down)
        {
            var nextposition = currposi;
            if ((currposi.x < 0) || (currposi.x >= data.Length) || (currposi.y < 0) || (currposi.y >= data[0].Length))           
            {
                //Console.WriteLine("Wall");
                return false;
            }
            if (data[currposi.x][currposi.y].CompareTo('0')==0)
                return false;
            if (data[currposi.x][currposi.y].CompareTo('f') == 0)
            {
                Console.WriteLine("Completed at psoition [{0},{1}]",currposi.x,currposi.y);
                return true;
            }
                
            if ((data[currposi.x][currposi.y].CompareTo('1') == 0)||(data[currposi.x][currposi.y].CompareTo('s') == 0))
            {
                Console.WriteLine("{0},{1}",currposi.x,currposi.y);
                if (route != TravelRoute.Up)
                {
                    if (currposi.x < data.Length)
                        if (Travel(new Position { x = currposi.x + 1, y = currposi.y }, TravelRoute.Down)) return true;
                }
                if (route != TravelRoute.Left)
                {
                    if (currposi.y < data[0].Length)
                        if (Travel(new Position { x = currposi.x, y = currposi.y + 1 }, TravelRoute.Right)) return true;
                }
                if (route != TravelRoute.Right)
                {
                    if (currposi.y > 0)
                        if (Travel(new Position { x = currposi.x, y = currposi.y - 1 }, TravelRoute.Left)) return true;
                }
                if (route != TravelRoute.Down)
                {
                    if (currposi.x > 0)
                        if (Travel(new Position { x = currposi.x - 1, y = currposi.y },TravelRoute.Up)) return true;
                }
            }
            return false;
        }

        private static Position GetStartPoint(string[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToLower().Contains('s'))
                {
                    return new Position { x = i, y = input[i].ToLower().IndexOf('s') };
                }
            }
            return null;
        }

     

        
    }
    class Position
    {
        public int x;
        public int y;
    }

    enum TravelRoute
    {
        Up,
        Down,
        Left,
        Right,
        None
    }

}
