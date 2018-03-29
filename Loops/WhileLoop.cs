using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class WhileLoop
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter you target");
            int userTarget = int.Parse(Console.ReadLine());

            int start = 0;

            while (start <= userTarget)
            {

                Console.WriteLine(start);
                start = start + 2;
                Console.ReadLine();

            }

        }
    }
}
