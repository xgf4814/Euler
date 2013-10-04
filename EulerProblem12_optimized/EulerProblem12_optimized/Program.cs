using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem12_optimized
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            int j = 0;
            int f = 0;
            while (f <= 500)
            {
                f = 0;
                j++;
                num += j;
                for (int n = 1; n <= Math.Round(Math.Sqrt(num)); n++)
                {
                    if (num % n == 0)
                        f += 2;
                }

            }
            Console.WriteLine(num);
        }
    }
}
