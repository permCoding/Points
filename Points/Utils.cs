using System;

namespace Points
{
    class Point
    {
        // поля
        public static int index = -1;
        public int X;
        public int Y;
        public int Id;
        public int ShiftY;
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
            this.Id = ++index;
            this.ShiftY = +1;
        }
        // методы
        public void SetPoint()
        {
            Console.SetCursorPosition(this.X, this.Y);
            Console.Write('#');
        }
        public void MovePoint()
        {
            this.Y += ShiftY;
            // if (height)
            SetPoint();
        }
    }
}
