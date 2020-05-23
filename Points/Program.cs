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
            points.RemoveAt(3);
            points.RemoveAt(1);
            for (int i = 0; i < countPoints; i++)
                points.Add(new Point());

            foreach (var p in points)
                Console.WriteLine($"Id = {p.Id}; X = {p.X}; Y = {p.Y}");

            Console.ReadLine();
        }
    }
}
