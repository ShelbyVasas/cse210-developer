using System;

namespace Unit02.game
{
    public class Director
    {
        public int _oldCard;
        public int _newCard;
        public int _points = 300;
        public string userGuess;
        bool playAgain = true;

        public void playGame()
        {
            while (playAgain)
            {
                newCard();
                getInputs();
                doUpdates();
                play();
            }

        }

        public void newCard()
        {
            Card newCard = new Card();
            _newCard = newCard.cardDraw();
            Console.WriteLine($"The card is: {_newCard}");

        }
        public void getInputs()
        {
            Console.Write("Higher or Lower? [h/l]");
            userGuess = Console.ReadLine();

        }

        public void doUpdates()
        {
                _oldCard = _newCard;
                Card newCard = new Card();
                _newCard = newCard.cardDraw();
                Console.WriteLine($"The new card is: {_newCard}");
                compareCards(_newCard,_oldCard,userGuess);
                Console.WriteLine($"Your new score is: {_points} points\n");

        }

        public void compareCards(int newcard, int oldcard, string choice)
        {
            if (choice == "l")
            {
                if (newcard < oldcard)
                {
                    _points += 100;
                }
                else
                {
                    _points -= 75;
                }
            }
            else if (choice == "h")
            {
                if (newcard > oldcard)
                {
                    _points += 100;
                }
                else
                {
                    _points -= 75;
                }
            }
        }

        public void play()
        {
            if (_points == 0)
            {
                playAgain = false;
            }
            else
            {
                Console.Write("Want to play again? [y/n]");
                string choice = Console.ReadLine();
                playAgain = (choice == "y");
            }
        }

    }
}