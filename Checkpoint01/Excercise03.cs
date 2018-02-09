using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint01
{
    class Excercise03
    {
        //Write a program and ask the user to enter a number.Compute the factorial of the number and print it on the console. 
        //For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

        public int UserInput { get; set; } = 0;
        public int Result { get; set; } = 0;
        public bool ValidInput { get; set; } = false;
        public void Factorial()
        {
            int userInputCopy = 0;
            while (!ValidInput)
            {
                if (int.TryParse(Console.ReadLine(), out userInputCopy))
                {
                    UserInput = userInputCopy;
                    Result = ComputeFactorial(userInputCopy);
                    ValidInput = true;
                }

                else
                {
                    InvalidInput();
                }

            }

        }

        private void InvalidInput()
        {
            Console.WriteLine("Invalid input, please try again.");
        }

        private int ComputeFactorial(int num)
        {
            if (num < 2)
            {
                return num * 1;
            }

            else
            {
                return num * ComputeFactorial(num - 1);
            }
        }

    }
}
