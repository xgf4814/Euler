using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem17
{
    class Program
    {

        static string[] digits = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen", "twenty" };
        static string[] tens = { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };

        static void Main(string[] args)
        {

            
            int sum = 0;

            for (int i = 1; i <= int.Parse(args[0]); i++)
            {
                sum += numberToWords(i).Length;
            }

            Console.WriteLine(sum);
            
        }

        private static string numberToWords(int i)
        {
            if (i == 1000)
                return "onethousand";

            string s = "";

            if (i >= 100)
            {
                s = s + digits[i / 100] + "hundred"; // + (i % 100 == 0 ? "" : "and");
                i %= 100;
                if (i == 0)
                    return s;
                s = s + "and";
            }

            if (i >= 20)
            {
                s = s + tens[i/10];
                i %= 10;
                s = s + digits[i];
            }
            else
            {
                s = s + digits[i];
            }

            return s;

        }
    }
}
