﻿using System;

namespace Points
{
    class Point
    {
        // поля
        public int X;
        public int Y;
        // конструкторы
        public Point() : this(0, 0)
        {
            //this.X = 0;
            //this.Y = 0;
        }
        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
        // методы
    }
}
