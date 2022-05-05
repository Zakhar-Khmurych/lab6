using System;
using System.Diagnostics;
//using CsvReader;

namespace lab6try1

{
    class Program
    {
        public static string fileName = @"C:\Users\HP\RiderProjects\lab6try1\data.txt";
        //public static string fileName = "https://raw.githubusercontent.com/kse-ua/algorithms/main/res/ukraine_poi.csv";
        public static Point startPoint = new Point("49,55293;25,56755;;;McDonald's;;");
        public static double radius = 0.01;

        static void Main(string[] args)
        { //https://csharpexamples.com/c-binary-search-tree-implementation/
            
            var sw = new Stopwatch();
            sw.Start();

            ReadFileLines data = new ReadFileLines(fileName);

            data.PointsWithinRadius(startPoint, radius);
            
            sw.Stop();
            Console.WriteLine($"Elapsed time: {sw.Elapsed}");
            
          }
    }
}