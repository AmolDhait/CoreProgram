using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProgram
{
    public class LeapYear
    {
        public static void DisplayLeap()
        {
            Console.WriteLine("Enter Year : ");
            int Year = Convert.ToInt32(Console.ReadLine());

            if (Year % 4 == 0 && Year % 100 != 0 || Year % 400 == 0)
            {
                Console.WriteLine("This is a Leap Year.", Year);
            }
            else
            {
                Console.WriteLine("This is not a Leap Year.", Year);
                Console.ReadLine();
            }
        }
    }
}
