using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem6
{
    class Program
    {
        static void Main(string[] args)
        {

            long sumOfSquares = 0;
            long squareOfSum = 0;

            for (int i = 1; i <= 100; i++)
            {
                sumOfSquares += i * i;
                squareOfSum += i;
            }

            squareOfSum *= squareOfSum;

            Console.WriteLine(squareOfSum - sumOfSquares);

        }
    }
}
