using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Arrays
    {
        // Arrays are a collection of simmilar data types
        static void Main(string[] args)
        {
            int[] evenNumbers = new int[3];

            evenNumbers[0] = 0;
            evenNumbers[1] = 2;
            evenNumbers[2] = 4;

            Console.WriteLine(evenNumbers[1]);
            Console.ReadLine();
        }
    }
}
