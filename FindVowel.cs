using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreProgram
{
    public class FindVowel
    {
        public static void FindVowelOrNot()
        {
            char ch;
            Console.Write("\n\n");
            Console.Write("check whether the input alphabet is a vowel or not:\n");
            Console.Write("-----------------------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input an Alphabet (A-Z or a-z) : ");
            ch = Convert.ToChar(Console.ReadLine().ToLower());
            char i;
            char a;
            char o;
            char u;
            char e;
            if ((ch == 'i') || (ch == 'o') || (ch == 'u') || (ch == 'e') || (ch == 'a') || (ch == 'I') || (ch == 'O') || (ch == 'U') || (ch == 'E') || (ch == 'A'))
            {
                Console.WriteLine(ch + " is Vowel.");
            }
            else
            {
                Console.WriteLine(ch + " is not Vowel.");
            }

        }
    }
}
