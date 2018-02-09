using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint01
{
    class Excercise02
    {
        //Write a program and continuously ask the user to enter a number or "ok" to exit. 
        //Calculate the sum of all the previously entered numbers and display it on the console.
        public int Sum { get; set; } = 0;
        public int Num = 0;
        public string UserInput { get; set; }
        public bool Exit { get; set; } = false;
        List<int> NumbersList { get; set; } = new List<int>();

        
        public int SumOfInput()
        {
            while (!Exit)
            {
                UserInput = Console.ReadLine();

                //Check if user has entered ok
                if (UserInput.Equals("ok"))
                {
                    Exit = true;

                }

                else if (int.TryParse(UserInput, out Num))
                {
                    NumbersList.Add(Num);
                    Sum += Num;
                    Console.WriteLine("Please enter another number or \"ok\" to exit: ");
                }
                else
                {
                    InvalidInput();
                }
            }
            return Sum;
        }

        private void InvalidInput()
        {
            Console.WriteLine("Invalid input, please try again.");
        }
    }
}
