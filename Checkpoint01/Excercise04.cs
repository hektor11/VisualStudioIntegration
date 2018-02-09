using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint01
{
    class Excercise04
    {
        //Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
        //If the user guesses the number, display “You won"; otherwise, display “You lost". 
        //(To make sure the program is behaving correctly, you can display the secret number on the console first.)
        public int RandomNumber { get; set; }
        public int ChancesLeft { get; set; } = 4;
        public bool GameOver { get; set; }
        public string UserGuessString { get; set; }
        private int UserGuess = 0;

        public void GuessTheNumber()
        {
            // Generate a random # between 1 and 10
            Random random = new Random();
            RandomNumber = random.Next(1, 11);

            //Check if the user guess matches the randomly generated #
            //Update number of chances left based on incorrect guesses
            while (!GameOver)
            {
                if (ChancesLeft > 0)
                {
                    UserGuessString = Console.ReadLine();
                    int.TryParse(UserGuessString, out UserGuess);
                    if (UserGuess == RandomNumber)
                    {
                        Console.WriteLine("You won");
                        GameOver = true;
                    }
                    else
                    {
                        ChancesLeft--;
                        Console.WriteLine("Sorry. You have {0} chances left!", ChancesLeft);
                    }
                }
                else
                {
                    Console.WriteLine("You Lost");
                    GameOver = true;
                }

            }

        }
    }
}
