using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerLib
{
    public class XMath
    {

        public static List<int> GeneratePrimes(int limit)
        {
            long sum = 0;

            // Eratosthenes
            // Create a list of consecutive integers from 2 to n: (2, 3, 4, ..., n).
            int[] a = new int[limit + 1];
            for (int i = 2; i <= limit; i++)
                a[i] = i;

            // Initially, let p equal 2, the first prime number.
            int p = 2;
            while (p < limit)
            {
                //Console.Write("\r{0}       ", p);
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
                else
                {
                    p++;
                }
            }

            List<int> primes = new List<int>();
            foreach (int i in a)
                if (i != 0)
                    primes.Add(i);
            return primes;

        }

        public static int Factorial(int n)
        {
            int product = 1;
            for (int i = n; i > 0; i--)
            {
                product *= i;
            }
            //Console.WriteLine("Factorial(" + n + ") = " + product);
            return product;
        }

        public enum SumType { defecient, perfect, abundant };

        public static bool IsAbundant(int n)
        {
            return (SumOfProperDivisorsType(n) == SumType.abundant);
        }

        public static SumType SumOfProperDivisorsType(int n)
        {
            int sum = SumOfProperDivisors(n);

            if (sum > n)
                return SumType.abundant;
            else if (sum < n)
                return SumType.defecient;
            else
                return SumType.perfect;

        }

        public static int SumOfProperDivisors(int n)
        {
            int sum = 0;

            foreach (int i in ProperDivisors(n))
                sum += i;

            return sum;
        }

        public static List<int> ProperDivisors(int n)
        {

            List<int> divisors = new List<int>();

            if (n == 1)
                throw new NotImplementedException();

            // Always add one as a special case, since we aren't supposed to add n
            divisors.Add(1);

            if (n == 2 || n == 3)
                return divisors;

            int intsqrt = (int)Math.Sqrt(n);

            for (int i = 2; i <= intsqrt; i++)
            {
                if (n % i == 0)
                {
                    divisors.Add(i);
                    if (i != (n / i))
                    {
                        divisors.Add(n / i);
                    }
                }
            }

            // square root case
            //if (n % intsqrt == 0)
            //  divisors.Add(intsqrt);

            return divisors;
        }
    }
}
