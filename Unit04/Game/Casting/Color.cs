using System;
using System.Collections.Generic;

namespace Unit04.Game.Casting
{
    public class Color
    {
        private int _red = 0;
        private int _green = 0;
        private int _blue = 0;
        private int _alpha = 225;
        
        public Color(int red, int green, int blue)
        {
            this._red = red;
            this._green = green;
            this._blue = blue;
        }

        //returns the base color (white)
        public int GetAlpha()
        {
            return _alpha;
        }

        //returns the value of red
        public int GetRed()
        {
            return _red;
        }

        //returns the value of green 
        public int GetGreen()
        {
            return _green;
        }

        //returns the value of blue
        public int GetBlue()
        {
            return _blue;
        }
    }
}