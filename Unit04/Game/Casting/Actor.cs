using System;
using System.Collections.Generic;

namespace Unit04.Game.Casting
{
    public class Actor
    {
        private string _text = "";
        private int _fontSize = 15;
        private Color _color = new Color(255,255,255);
        private Point _position = new Point(0,0);
        private Point _velocity =new Point(0,0);

        public Actor()
        {
        }

        public Color GetColor()
        {
            return _color;
        }

        public int GetFontSize()
        {
            return _fontSize;
        }

        public Point GetPosition()
        {
            return _position;
        }

        public Point GetText()
        {
            return _text;
        }

        public Point GetVelocity()
        {
            return _velocity;
        }

        public void MoveNext(int maxX, int MaxY)
        {
            int x = ((_position.GetX() + _velocity.GetX()) + maxX) % mzxX;
            int y = ((_position.GetY() + _velocity.GetType()) + MaxY) % int.MaxValue;
            _position = new Point(x,y);
        }

    }
}