using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Statements
{
    class ifStatment
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Number");
            int userNumber = int.Parse(Console.ReadLine());

            if (userNumber == 1)
            {
                Console.WriteLine("Your number is one");
                Console.ReadLine();
            }
           else if (userNumber == 2)
            {
                Console.WriteLine("Your number is Two");
                Console.ReadLine();
            }
            else if (userNumber == 3)
            {
                Console.WriteLine("Your number is Three");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Your number is" + " "  + userNumber);
                Console.ReadLine();

            }
        }
    }
}
