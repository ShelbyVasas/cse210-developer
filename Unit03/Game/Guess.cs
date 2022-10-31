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

        public void getSelectedWord()
        {
            Console.WriteLine(selectedWord);
        }

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