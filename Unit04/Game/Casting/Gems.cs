using System;
using System.Collections.Generic;

namespace Unit04.Game.Casting
{
    public class Gems : Actor
    {
        private string _message = "";
        public int _points = 0;
        public Gems ()
        {
        }

        public string GetMessage()
        {
            return _message;
        }

        public void SetMessage(string message)
        {
            this._message = message;
        }
    }
}