using System;

namespace lab6try1
{
    public class ReadFileLines
    {
        private string[] lines;
        public ReadFileLines(string fileName)
        {
            lines = System.IO.File.ReadAllLines(fileName);
        }

        public void PointsWithinRadius(Point starting_point, double radius)
        {
            foreach (string line in lines)
            {
                Point p = new Point(line);

                if (p.DistanceTo(starting_point) <= radius)
                {
                    Console.WriteLine("\t" + line);
                }
            }
        }
        
    }
}