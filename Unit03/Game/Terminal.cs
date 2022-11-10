using System;
using System.Collections.Generic;

namespace Unit03.Game
{
    public class Terminal
    {
       private List<char> word = new List<char> {'_','_','_','_','_'};

        /// <summary>
        /// Finds the location of the letter in the list.
        /// </summary>
       public void setWordList(int loc, char letter)
       {
        word[loc] = letter;
       }

        /// <summary>
        /// Prints the letter if guessed correctly.
        /// </summary>
       private void printWordList()
       {
        foreach(char letters in word)
        {
            Console.Write(letters);
        }
       }

        /// <summary>
        /// Adds their guess to the game.
        /// </summary>
       public string getCharList()
       {
        string charTotal = String.Join("",word);
        return charTotal;
       }

        /// <summary>
        /// Shows user if they won!
        /// </summary>
       public void winDisplay()
       {
        Console.WriteLine("You win!");
       }

        /// <summary>
        /// Displays the image of the jumper to the user. 
        /// </summary>
       public void displayPerson(int lifePoints)
       {
        switch(lifePoints)
            {
                case 0:
                    Console.WriteLine(@"
                    /   /
                    x ---
                    \   \
                   ^^^^^^^");
                break;

                case 1:
                    printWordList();
                    Console.WriteLine(@"
                    \   /
                      0
                    / | \
                     / \
                     
                   ^^^^^^");
                break;

                case 2:
                    printWordList();
                    Console.WriteLine(@"
                   \     /
                    \   /
                      0
                    / | \
                     / \
                     
                   ^^^^^^");
                break;

                case 3:
                    printWordList();
                    Console.WriteLine(@"
                  | _____ |
                   \     /
                    \   /
                      0
                    / | \
                     / \
                     
                   ^^^^^^");
                break;

                case 4:
                    printWordList();
                    Console.WriteLine(@"
                   /     \
                  | _____ |
                   \     /
                    \   /
                      0
                    / | \
                     / \
                     
                   ^^^^^^");
                break;

                case 5:
                    printWordList();
                    Console.WriteLine(@"
                    _____
                   /     \
                  | _____ |
                   \     /
                    \   /
                      0
                    / | \
                     / \
                     
                   ^^^^^^");
                break;

                default:
                    Console.WriteLine(@"
                   ~~~~~~~
                    _____
                   /     \
                  | _____ |
                   \     /
                    \   /
                      0
                    / | \
                     / \
                     
                   ^^^^^^");
                break;
            }
       }
    }
}