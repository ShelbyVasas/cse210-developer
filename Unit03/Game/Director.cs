using System;
using System.Collections.Generic;

namespace Unit03.Game
{
    /// <summary>
    /// <para>A person who directs the game.</para>
    /// <para>
    /// The responsibility of a Director is to control the sequence of play.
    /// </para>
    /// </summary>
    public class Director
    {
        public void playGame()
        {
            Jumper jumper = new Jumper();
            Guess guess = new Guess();
            Terminal terminal = new Terminal();
            string keyword = "";

            /// <summary>
            /// Verifys that the game is still active because the user has not died yet.
            /// </summary>
            keyword = guess.selectRandomWord();
                while(jumper.getLifePoints() >= 0)
                {
                    if (terminal.getCharList() == keyword)
                    {
                        jumper.setLifePoints(-1);
                        terminal.winDisplay();
                    }
                    else if (terminal.getCharList() != keyword && jumper.getLifePoints() == 0)
                    {
                        jumper.setLifePoints(-1);
                        Console.WriteLine("Sorry you died!");
                        terminal.displayPerson(0);
                    }
                    else
                    {
                        terminal.displayPerson(jumper.getLifePoints());
                        jumper.readUserInput(keyword);
                        int index = jumper.getWordIndex();
                        if (index >= 0)
                        {
                            terminal.setWordList(index, keyword[index]);
                        }
                    }
                }
            /// <sumary>
            /// Continues gameplay if user desires.
            /// </summary>
            Console.WriteLine("Do you want to play again? [y/n]");
            string input = Console.ReadLine();
            if (input == "y")
            {
                keyword = guess.selectRandomWord();
                jumper.setLifePoints(5);
                playGame();
            }

        }
    }
}