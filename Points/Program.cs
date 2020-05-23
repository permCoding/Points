using System;
using System.Collections.Generic;

namespace Points
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            int countPoints = 5;
            int width = 60, height = 25;
            Console.WindowWidth = width; Console.WindowHeight = height;

            List<Point> points = new List<Point>();
            for (int i = 0; i < countPoints; i++)
            {
                points.Add(
                    new Point(
                        rnd.Next(width),
                        rnd.Next(height)
                    )
                );
            }

            foreach (var p in points)
                Console.WriteLine($"Id = {p.Id}; X = {p.X}; Y = {p.Y}");

            Console.ReadLine();
        }
    }
}
