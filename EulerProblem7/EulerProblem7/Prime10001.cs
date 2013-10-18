using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem7
{
    class Prime10001
    {
        static void Main(string[] args)
        {

            List<long> primes = new List<long>();
            long lastPrime = 0;

            int i = 2;

            while (primes.Count < 10001)
            {
                if (isPrime(i))
                {
                    primes.Add(i);
                    lastPrime = i;
                }
                i++;
            }

            Console.WriteLine(lastPrime);
            
        }

        private static bool isPrime(int p)
        {
            for (int i = 2; i < p; i++)
            {
                if (p % i == 0)
                    return false;
            }

            return true;
        }
    }
}
