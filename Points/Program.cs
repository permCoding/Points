using System;
using System.Collections.Generic;

namespace Points
{
    class Program
    {
        static void Main()
        {
            Point point = new Point();

            List<Point> points = new List<Point>();
            points.Add(point);
            points.Add(point);
            points.Add(point);

            Console.WriteLine($"X = {points[0].X}; Y = {points[0].Y}");

            Console.ReadLine();
        }
    }
}
