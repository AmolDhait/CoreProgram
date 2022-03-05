using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProgram
{
    public class QuotientAndRemaider
    {
        public static void CalculateQuotientAndRemaider()
        {
            int dividend = 50;
            int divsor = 8;

            int quptient = dividend / divsor;
            int remainder = dividend % divsor;
            Console.WriteLine("Dividend: {0} Divisorn: {1}", dividend, divsor);
            Console.WriteLine("QUOTIENT :{0}", quptient);
            Console.WriteLine("Remainder :{0}", remainder);
        }
    }
}
