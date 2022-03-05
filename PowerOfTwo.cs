using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProgram
{
    public class PowerOfTwo
    {
        public static void Power()
        {
            Console.WriteLine("Enter Rang of Power Of Two");
            int i;
            int num = Convert.ToInt32(Console.ReadLine());
            int p = 1;
            if (num <= 31)
            {
                for (i = 0; i <= num; i++)
                {
                    if (i == 0)
                    {
                        p = 1;
                    }
                    else
                    {
                        p = p * 2;
                        Console.WriteLine(p);
                    }
                }
            }
            else
            {
                Console.WriteLine("Rang of Power Of Two more than 31");
            }
        }
    }
}
