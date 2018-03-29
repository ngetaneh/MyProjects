using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe_purchase_switch_if_and_go_to
{
    class Program
    {
        static void Main(string[] args)
        {
           int  totalCoffeCost = 0;

            start:
            Console.WriteLine("Please select your coffe size 1 - Small, 2 - Medium, 3 - Large");
            int userChoice = int.Parse(Console.ReadLine());

            switch (userChoice)
            {
                case 1:
                    totalCoffeCost += 1;
                    Console.ReadLine();
                    break;
                case 2:
                    totalCoffeCost += 2;
                    Console.ReadLine();

                    break;
                case 3:
                    totalCoffeCost += 3;
                    Console.ReadLine();

                    break;
                default:
                    Console.WriteLine("Invalid {0 }selection", userChoice);
                    Console.ReadLine();
                    goto start;
            }
            Decide:
            Console.WriteLine("Do you want to continue - Yes or No?");
            string continueWithTransaction = Console.ReadLine();

            switch(continueWithTransaction.ToUpper())
                {
                case "YES":
                    goto start;
               
                case "NO":
                    break;
            default:
                    Console.WriteLine(" Your Choice is {} invalid. Please try again");
                    goto Decide;
            }



            Console.WriteLine("Thank you for shopping with us");
            Console.WriteLine("Bill Amount is ${0}", totalCoffeCost );
            Console.ReadLine();
        }
    }
}
