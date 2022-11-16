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

        //returns a color
        public Color GetColor()
        {
            return _color;
        }

        //returns a text size
        public int GetFontSize()
        {
            return _fontSize;
        }

        //returns a position
        public Point GetPosition()
        {
            return _position;
        }

        //returns a text value
        public string GetText()
        {
            return _text;
        }

        //returns a velocity
        public Point GetVelocity()
        {
            return _velocity;
        }

        //moves the object across the screen
        public void MoveNext(int maxX, int MaxY)
        {
            int x = ((_position.GetX() + _velocity.GetX()) + maxX) % maxX;
            int y = ((_position.GetY() + _velocity.GetY()) + MaxY) % MaxY;
            _position = new Point(x,y);
        }

        //sets a color
        public void SetColor(Color color)
        {
            if (color == null)
            {
                throw new ArgumentException("color can't be null");
            }
            this._color = color;
        }

        //sets the font size
        public void SetFontSize(int fontSize)
        {
            if (fontSize <= 0)
            {
                throw new ArgumentException("fontSize must be greater than 0");
            }
            this._fontSize = fontSize;
        }

        //sets the position
        public void SetPosition(Point position)
        {
            if (position == null)
            {
                throw new ArgumentException("position can't be null");
            }
            this._position = position;
        }

        //sets the text
        public void SetText(string text)
        {
            if (text == null)
            {
                throw new ArgumentException("text can't be null");
            }
            this._text = text;
        }

        //sets the velocity
        public void SetVelocity(Point velocity)
        {
            if (velocity == null)
            {
                throw new ArgumentException("velocity can't be null");
            }
            this._velocity = velocity;
        }

    }
}