using System;
using System.Collections.Generic;

namespace Points
{
    class Program
    {
        static void Main()
        {
            int countPoints = 5;

            List<Point> points = new List<Point>();
            for (int i = 0; i < countPoints; i++)
                points.Add(new Point());

            foreach (var p in points)
                Console.WriteLine($"X = {p.X}; Y = {p.Y}");

            Console.ReadLine();
        }
    }
}
