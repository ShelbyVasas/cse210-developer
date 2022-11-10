using System;
using System.Collections.Generic;

namespace Unit03.Game
{
    public class Jumper
    {
        private int lifePoints = 5;
        private int wordIndex = 0;
        
        /// <summary>
        /// Asks user for a guess and verify's it's accuracy.
        /// </summary>
        public void readUserInput(string keyword)
        {
            Guess check = new Guess();
            Console.WriteLine($"You have {getLifePoints()} lives left");
            Console.Write("Guess a letter [a-z]:");

            try{
                char input = Console.ReadLine()[0];
                hitPoints(check.checkUserInput(input, keyword));
                int index = keyword.IndexOf(input);
                wordIndex = index;
            }
            catch(Exception){
                check.checkUserInput('0', keyword);
                wordIndex = -1;
            }
        }

        /// <summary>
        /// Returns how many more attempts the user has.
        /// </summary>
        public int getLifePoints()
        {
            return lifePoints;
        }

        /// <summary>
        /// Updates the lifepoint score for the next round.
        /// </summary>
        public void setLifePoints(int life)
        {
            lifePoints = life;
        }

        /// <summary>
        /// Updates the word index for the next round.
        /// </summary>
        public int getWordIndex()
        {
            return wordIndex;
        }

        /// <summary>
        /// Subtracts the lifepoint total if the user is incorrect. 
        /// </summary>
        public void hitPoints(bool hit)
        {
            if (hit == false)
            {
                lifePoints--;
            }
        }

    }
}