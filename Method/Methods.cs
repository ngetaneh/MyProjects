using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Methods
    {
        static void Main(string[] args)
        {
            Methods p = new Methods();
            p.evenNumber(30);
            int sum = p.ADD(10, 20);
            int i = 0;

            // Pass by reference
            simpleMethod(ref i);

            Console.WriteLine(i);
            Console.ReadLine();
            Console.WriteLine(sum);
            Console.ReadLine();
            Console.WriteLine(p);
            Console.ReadLine();
        }

        public int ADD (int FN, int SN)
        {
            return FN + SN;
        }
        public void evenNumber( int Target)
        {
            int start = 0;

            while(start <= Target)
            {
                Console.WriteLine(start);
                start = start + 2;
                Console.ReadLine();
            }
        }
        public static void simpleMethod (ref int j)
        {
            j = 101;
        }
    }
}
