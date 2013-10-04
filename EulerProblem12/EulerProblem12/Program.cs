using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem12
{
    class Program
    {
        static void Main(string[] args)
        {
            int limit = Int32.Parse(args[0]);
            
            List<int> triangleNumbers = new List<int>();
            triangleNumbers.Add(1);

            int i = 2;
            List<int> divisors = new List<int>();
            while (divisors.Count < limit)
            {
                triangleNumbers.Add(triangleNumbers[triangleNumbers.Count - 1] + i);
                divisors = Divisorize(triangleNumbers[triangleNumbers.Count - 1]);
                Console.Write("\r{0} {1}                 ", i, divisors.Count);
                i++;
            }

            Console.WriteLine();
            Console.WriteLine("First Triangle Number with over " + limit + " divisors:");
            Console.WriteLine("Triangle Number #" + triangleNumbers.Count + ", Value == " + triangleNumbers[triangleNumbers.Count - 1]);
            Console.WriteLine();
            foreach (int x in divisors)
                Console.Write(x + ", ");
            Console.WriteLine();
            
        }

        private static List<int> Divisorize(int p)
        {
            List<int> d = new List<int>();

            for (int i = 1; i <= p; i++)
            {
                if (p % i == 0)
                    d.Add(i);
            }

            return d;
        }

    }
}
