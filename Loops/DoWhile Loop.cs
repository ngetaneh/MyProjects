using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class DoWhile_Loop
    {
        static void Main(string[] args)
        {
            string userChoice = String.Empty;

            do
            {
                Console.WriteLine("Please enter you target");
                int userTarget = int.Parse(Console.ReadLine());

                int start = 0;

                while (start <= userTarget)
                {

                    Console.WriteLine(start + " ");
                    start = start + 2;
                    Console.ReadLine();

                }

                do
                {
                    Console.WriteLine("Do you Want to continue Y/N");
                    Console.ReadLine();


                    userChoice = Console.ReadLine().ToUpper();

                    if (userChoice != "Y" && userChoice != "N")
                    {
                        Console.WriteLine("Invalid Choiuce");
                        Console.ReadLine();
                    }
                }
                while (userChoice != "Y" && userChoice != "N");
            }
            while (userChoice == "Y");
        }
    }
}
