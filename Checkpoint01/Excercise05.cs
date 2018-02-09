using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checkpoint01
{
    class Excercise05
    {
        public string[] UserInputString { get; set; }
        public List<int> UserInputNumbers { get; set; } = new List<int>();

        public int MaxNumber()
        {
            int number = 0;
            UserInputString = Console.ReadLine().Split(',');
            foreach (string str in UserInputString)
            {
                int.TryParse(str, out number);
                UserInputNumbers.Add(number);
            }

            return UserInputNumbers.Max();
        }

       
    }
}
