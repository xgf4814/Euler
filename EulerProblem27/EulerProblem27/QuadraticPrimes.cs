using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem27
{
    class QuadraticPrimes
    {

        int numPrimes = 2000;
        List<int> primeList;
        HashSet<int> primeSet;
        
        static void Main(string[] args)
        {
            QuadraticPrimes q = new QuadraticPrimes();
        }

        public QuadraticPrimes()
        {
            InitPrimeCollections();
            int numConsecutive;
            int maxConsecutive = 0;
            int maxA = 0; 
            int maxB = 0;

            for (int a = -999; a < 1000; a++)
            {
                for (int b = -999; b < 1000; b++)
                {
                    numConsecutive = CQP(a, b);
                    if (numConsecutive > maxConsecutive)
                    {
                        maxConsecutive = numConsecutive;
                        maxA = a;
                        maxB = b;
                    }
                }
            }

            Console.WriteLine("n^2" + (maxA > 0 ? "+ " : " ") + maxA + "*n " + (maxB > 0 ? "+ " : " ") + maxB);
            Console.WriteLine(maxConsecutive + " consecutive primes");
            Console.WriteLine("Coefficient Product a * b = " + (maxA * maxB));

        }

        private int CQP(int a, int b)
        {
            int n = 0;
            int x = (n * n) + (a * n) + b;

            while (IsPrime(x))
            {
                n++;
                x = (n * n) + (a * n) + b;
            }

            return n;
        }

        public bool IsPrime(int n)
        {
            if (n > primeList[primeList.Count-1])
            {
                numPrimes *= 2;
                InitPrimeCollections();
            }

            return primeSet.Contains(n);
        }

        public void InitPrimeCollections()
        {
            primeList = EulerLib.XMath.GeneratePrimes(numPrimes);
            primeSet = new HashSet<int>(primeList);
        }


    }
}
