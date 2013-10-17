using EulerLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem25
{
    class Program
    {
        static void Main(string[] args)
        {

            string i = "1";
            string j = "1";
            string k = "1";

            int term = 2;
            while (k.Length < int.Parse(args[0]))
            {
                k = EulerLib.StringInt.Add(i, j);
                i = j;
                j = k;
                term++;
                Console.WriteLine("F" + term + " = " + k);
            }

        }
    }
}
