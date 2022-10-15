using System;

namespace Unit02.game
{
    public class Card
    {
        public int randomNum;

        public int cardDraw()
        {
            Random rand = new Random();
            randomNum = rand.Next(1,14);
            return randomNum;
        }
    }
}