using System;
using System.Collections.Generic;

namespace Unit03.Game
{
    public class Guess
    {
        private string selectedWord = "";
        private string setSelectedWord(string genWord)
        {
            selectedWord = genWord;
            return selectedWord;
        }

        /// <summary>
        /// Chooses a random word for the gameplay.
        /// </summary>
        public string selectRandomWord()
        {
            List<string> words = new List<string>{
                "oasis",
                "opera",
                "pages",
                "pause",
                "patch",
                "quest",
                "quiet",
                "radio",
                "sauce"
            };
            var random = new Random();
            int index = random.Next(words.Count);
            return setSelectedWord(words[index]);
        }
        /// <summary>
        /// Returns the selected word for gameplay
        /// </summary>
        public void getSelectedWord()
        {
            Console.WriteLine(selectedWord);
        }

        /// <summary>
        /// Checks to see if the user's guess matches as value in the chosen word.
        /// </summary>
        public bool checkUserInput(char userInput, string selectedWord)
        {
            if (selectedWord.Contains(userInput))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}