using EulerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem16
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = "2";
            int count = Int32.Parse(args[0]);
            string z = StringInt.ShiftLeft(x, count-1);
            Console.WriteLine(x + " ^ " + count + " = " + z);
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Sum of Digits: " + StringInt.SumDigits(z));
        }
    }
}
