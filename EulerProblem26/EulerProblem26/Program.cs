using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem26
{
    class Program
    {
        static void Main(string[] args)
        {
            //Implement Long Division
            int max_divisor = int.Parse(args[0])-1;
            int d_longestrecurring = 3;
            int longest_recurring_cycle = 1;

            int x;
            int y;
            int r;
            List<int> previous = new List<int>();
            //for (int d = max_divisor+1; d <= max_divisor+1; d++)
            for (int d = 2; d <= max_divisor; d++)
            {
                previous.Clear();
                x = 1;
                r = 0;

                // Long Division
                while(!previous.Contains(x) && x != 0)
                {
                    previous.Add(x);
                    while (d > x)
                        x *= 10;
                    y = d * (x / d);

                    x = x - y;                  
                    r++;
                }

                //Console.WriteLine("1/" + d + "; " + r + "; " + x);

                // Determine if repeating
                r = r - previous.IndexOf(x);
                if (x != 0)
                {
                    if (r > longest_recurring_cycle)
                    {
                        longest_recurring_cycle = r;
                        d_longestrecurring = d;
                    }
                }

            }

            Console.WriteLine("\nDivisor = " + d_longestrecurring);
            Console.WriteLine("Length of Recurrence = " + longest_recurring_cycle);
            Console.WriteLine((1.0 / (double)d_longestrecurring));

        }
    }
}
