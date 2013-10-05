using EulerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem20
{
    class Program
    {
        static void Main(string[] args)
        {
            string factorial = "1";
            for (int i = 1; i <= int.Parse(args[0]); i++)
            {
                //Console.Write(sum + " * " + i.ToString() + " = ");
                factorial = StringInt.Multiply(factorial,i.ToString());
                //Console.WriteLine(sum);
            }
            Console.WriteLine(factorial);
            Console.WriteLine();
            Console.Write("Sum of those digits = " + StringInt.SumDigits(factorial));
        }
    }
}
