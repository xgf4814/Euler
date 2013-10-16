using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerLib
{
    public class XMath
    {

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
