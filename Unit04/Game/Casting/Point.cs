using System;
using System.Collections.Generic;

namespace Unit04.Game.Casting
{
    //returns a position as a point
    public class Point
    {
        private int _x = 0;
        private int _y = 0;

        public Point(int x, int y)
        {
            this._x = x;
            this._y = y;
        }

        //returns a new point
        public Point Add(Point other)
        {
            int x = this._x + other.GetX();
            int y = this._y + other.GetY();
            return new Point(x, y);
        }

        //returns the boolean value of if x is equal to a new x and y
        public bool Equals(Point other)
        {
            return this._x == other.GetX() && this._y == other.GetY();
        }

        //returns an x coordinate
        public int GetX()
        {
            return _x;
        }

        //returns a y coordinate
        public int GetY()
        {
            return _y;
        }

        //scales the points to match the current scale of the game
        public Point Scale(int factor)
        {
            int x = this._x * factor;
            int y = this._y * factor;
            return new Point(x, y);
        }
    }
}