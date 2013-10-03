using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem14
{
    class Program
    {
        static void Main(string[] args)
        {

            long n;
            int counter;
            int longest = 0;
            int longest_n = 0;
            for (int i = 1; i < 1000000; i++)
            {
                Console.Write("\r{0}   ", i);
                counter = 0;
                n = i;
                while (n != 1)
                {
                    if (n % 2 == 0)
                    {
                        n /= 2;
                    }
                    else
                    {
                        n = 3 * n + 1;
                    }
                    counter++;
                }
                if (counter > longest)
                {
                    longest = counter;
                    longest_n = i;
                }
            }
            Console.WriteLine("Longest, n = " + longest_n);
            Console.WriteLine("Chain Length = " + longest);

        }
    }
}
