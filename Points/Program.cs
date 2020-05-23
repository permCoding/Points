using System;
using System.Collections.Generic;

namespace Points
{
    class Point
    {
        public int X;
        public int Y;
    }
    class Program
    {
        static void Main()
        {
            Point point = new Point();
            Console.WriteLine($"X = {point.X}; Y = {point.Y}");

            Console.ReadLine();
        }
    }
}
