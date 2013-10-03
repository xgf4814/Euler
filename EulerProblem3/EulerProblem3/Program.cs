using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<long> factors = new List<long>();
            long target = Int64.Parse(args[0]);

            long i = 2;
            while (target > 1)
            {
                if (target % i == 0)
                {
                    target = target / i;
                    factors.Add(i);
                    Console.WriteLine(i);
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
