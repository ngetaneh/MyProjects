using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataType_Conversion
{
    class tryParse
    {
        static void Main(string[] args)
        {
            string strNumber = "100";

            int Result = 0;

            // Try Parse is a boolean data type. 
            // It will return true if there is conversion
            bool ifConversionIsSucessful = int.TryParse(strNumber, out Result);

            if (ifConversionIsSucessful)
            {
                Console.WriteLine(Result);
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine ("Please enter a valid output");
                Console.ReadLine();
            }
        }
    }
}
