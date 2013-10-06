using EulerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem21
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = 0;

            if (args.Length == 1)
            {
                try
                {
                    limit = int.Parse(args[0]);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            else
            {
                Console.WriteLine("Specify the upper limit");
                return;
            }

            bool debug = false;

            if (debug)
            {
                List<int> foo = XMath.ProperDivisors(limit);
                foo.Sort();
                foreach (int i in foo)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine();
                Console.WriteLine(d(limit));
                Console.WriteLine(IsAmicable(limit));
            }
            else
            {
                int sum = 0;
                for (int i = 2; i < limit; i++)
                {
                    if (IsAmicable(i))
                    {
                        sum += i;
                    }
                }

                Console.WriteLine(sum);
            }

        }

        static bool IsAmicable(int a)
        {
            if (a == 0)
                return false;
            
            int x = d(a);

            if (x < 2)
                return false;

            int y = d(x);

            if (a == y && a != x)
            {
                Console.WriteLine("Amicable Pair: " + a + " " + x);
                return true;
            }
            else
            {
                return false;
            }
        }

        static int d(int n)
        {   
            int sum = 0;
            foreach (int i in XMath.ProperDivisors(n))
            {
                sum += i;
            }
            return sum;
        }

    }
}
