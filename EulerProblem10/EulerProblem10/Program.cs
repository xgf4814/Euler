using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem10
{
    class Program
    {
        static void Main(string[] args)
        {
            long sum = 0;

            // Eratosthenes
            // Create a list of consecutive integers from 2 to n: (2, 3, 4, ..., n).
            int limit = 2000000;
            int[] a = new int[limit+1];
            for (int i = 2; i <= limit; i++)
                a[i] = i;

            // Initially, let p equal 2, the first prime number.
            int p = 2;
            while (p < limit)
            {
                Console.Write("\r{0}       ", p);
                // Starting from p, count up in increments of p and mark each of these numbers greater than p itself in the list. These will be multiples of p: 2p, 3p, 4p, etc.; note that some of them may have already been marked.
                for (int x = 2; (p * x) <= limit; x++)
                {
                    a[p * x] = 0;
                }

                // Find the first number greater than p in the list that is not marked. If there was no such number, stop. Otherwise, let p now equal this number (which is the next prime), and repeat from step 3.
                if ((p + 1) < limit)
                {
                    do
                    {
                        p++;
                    }
                    while (a[p] == 0 && p < limit);
                }
                
            }


            for (int x = 0; x < a.Length; x++)
            {
                if (a[x] != 0)
                {
                    //Console.WriteLine(a[x]);
                    sum += a[x];
                }
            }
            Console.WriteLine("SUM = " + sum);

        }

    }
}
