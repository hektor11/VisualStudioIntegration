using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint01
{
    class Excercise01
    {
        //Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder. Display the count on the console.
        public int Count { get; set; } = 0;

        public int DivisibleByThree()
        {
            for (int i = 1; i < 101; i++)
            {
                if (i % 3 == 0)
                {
                    Count++;
                }
            }
            return Count;

        }
    }
}
