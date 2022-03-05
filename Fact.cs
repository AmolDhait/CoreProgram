using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProgram
{
    public class Fact
    {
        public static void FactNumber()
        {
            int a, b;
            Console.WriteLine("Please enter your integer: ");
            a = Convert.ToInt32(Console.ReadLine());
            for (b = 1; b <= a; b++)
            {
                if (a % b == 0)
                {
                    Console.WriteLine(b);
                }
            }

        }
    }
}
