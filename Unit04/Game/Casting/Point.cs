using System;
using System.Collections.Generic;

namespace Unit04.Game.Casting
{
    public class Point
    {
        private int _x = 0;
        private int _y = 0;

        public Point(int x, int y)
        {
            this._x = x;
            this._y = y;
        }

        public Point Add(Point other)
        {
            int x = this._x + other.GetX();
            int y = this._y + other.GetY();
            return new Point(x, y);
        }

        public bool Equals(Point other)
        {
            return this._x == other.GetX() && this._y == other.GetY();
        }

        public int GetX()
        {
            return _x;
        }

        public int GetY()
        {
            return _y;
        }

        public Point Scale(int factor)
        {
            int x = this._x * factor;
            int y = this._y * factor;
            return new Point(x, y);
        }
    }
}