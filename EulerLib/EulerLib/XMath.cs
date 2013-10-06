using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerLib
{
    public class XMath
    {
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

            for (int i = 2; i < intsqrt; i++)
            {
                if (n % i == 0)
                {
                    divisors.Add(i);
                    divisors.Add(n / i);
                }
            }

            // square root case
            if (n % intsqrt == 0)
                divisors.Add(intsqrt);

            return divisors;
        }
    }
}
