using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Checkpoint01
{
    class Program
    {
        static int ValidateUserInput()
        {
            int userInput = 0;
            string UserInputString = Console.ReadLine();
            int.TryParse(UserInputString, out userInput);

            while (userInput < 1 || userInput > 5)
            {
                Console.WriteLine("That is not a valid excercise number.\nPlease enter a number between 1 and 5:\t");
                int.TryParse(Console.ReadLine(), out userInput);
            }

            return userInput;
        }

        static void Main(string[] args)
        {
            // Get user input for which Excercise they would like to run
            Console.WriteLine("Welcome young padawan...\nThere are 5 Excercises to choose from.");
            Console.WriteLine("Enter a number between 1 and 5 to select which Exercise you would like to run:\t");

            switch (ValidateUserInput())
            {
                case 1:
                    Console.WriteLine("Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.");
                    Excercise01 excercise01 = new Excercise01();
                    Console.WriteLine("Count: {0}", excercise01.DivisibleByThree());
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Write a program and continuously ask the user to enter a number or \"ok\" to exit.\nCalculate the sum of all the previously entered numbers and display it on the console.");
                    Excercise02 excercise02 = new Excercise02();
                    Console.WriteLine("The sum is: {0}", excercise02.SumOfInput());
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Write a program and ask the user to enter a number.\nCompute the factorial of the number and print it on the console.");
                    Console.WriteLine("For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.");
                    Excercise03 excercise03 = new Excercise03();
                    excercise03.Factorial();
                    Console.WriteLine("{0}! = {1}", excercise03.UserInput, excercise03.Result);
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number.");
                    Console.WriteLine("If the user guesses the number, display \"You won\"; otherwise, display \"You lost\".");
                    Excercise04 excercise04 = new Excercise04();
                    Console.WriteLine("Enter your guess here: \t");
                    excercise04.GuessTheNumber();
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Write a program and ask the user to enter a series of numbers separated by comma.");
                    Console.WriteLine("Find the maximum of the numbers and display it on the console. For example, if the user enters \"5, 3, 8, 1, 4\", the program should display 8.");
                    Console.WriteLine("Enter a series of numbers separated by a comma: ");
                    Excercise05 excercise05 = new Excercise05();
                    Console.WriteLine("The max number is : {0} ", excercise05.MaxNumber());
                    Console.ReadLine();
                    break;

            }
        }
    }
}
