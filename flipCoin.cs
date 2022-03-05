using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProgram
{
    public class flipCoin
    {
        public static void CalculatePercentage()
        {
            Console.WriteLine("Enter no flip");
            int Head = 0;
            int Tail = 0;
            int HeadCount = 1;
            int TailCount = 1;
            double HeadPercentage;
            double TailPercentage;

            int Flip = Convert.ToInt32(Console.ReadLine());

            if (Flip > 0)
            {
                for (int i = 1; i <= Flip; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    Console.WriteLine(number);
                    if (number == 1)
                    {
                        //Head = 1;
                        //HeadCount += Head;
                        HeadCount++;
                    }
                    else if (number == 0)
                    {
                        //Tail = 1;
                        //TailCount += Tail;
                        TailCount++;
                    }
                }
                Console.WriteLine("..............");
                HeadPercentage = (HeadCount * 100) / Flip;
                TailPercentage = (TailCount * 100) / Flip;
                Console.WriteLine("Head Percentage: " + HeadPercentage);
                Console.WriteLine("Tail Percentage: " + TailPercentage);
            }

            //Console.WriteLine(HeadCount);
            //Console.WriteLine(TailCount);

        }
        
    }
}
