using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProgram
{
     public class SwapTwoNumber
    {
        public static void SwapNumber()
        {
            int a = 5, b = 10;
            Console.WriteLine("Before swap a = " + a + " b= " + b);

            a = a * b;
            b = a / b;
            a = a / b;
            Console.WriteLine("after swap a = " + a + " b= " + b);
        }
    }
}
