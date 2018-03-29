using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatments
{
    class switchStatments
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter a Number");
            int userNumber = int.Parse(Console.ReadLine());

            switch (userNumber)
            {
                case 10:
                   
                case 20:
                    
                case 30:
                    Console.WriteLine("Your Number is {0}" + " " + userNumber);
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Your Number is  not in 10 , 20 and 30");
                    Console.ReadLine();
                    break;
            }
        }

    }
}
