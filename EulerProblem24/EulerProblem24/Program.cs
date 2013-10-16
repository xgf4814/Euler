using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem24
{
    class Program
    {
        static void Main(string[] args)
        {
            int numDigits = int.Parse(args[0]); // We'll assume for now it's 0 - n (e.g. 4 = 0123)
            int lpn = int.Parse(args[1]); // Lexicographic Permutation Number

            List<int> remaining = new List<int>();
            for (int i = 0; i < numDigits; i++)
                remaining.Add(i);

            int level = numDigits;
            int index;
            int f;
            List<int> result = new List<int>();
            while (remaining.Count > 1)
            {
                level--;
                f = EulerLib.XMath.Factorial(level);
                index = (lpn / f);
                lpn %= f;
                result.Add(remaining[index]);
                remaining.RemoveAt(index);
            }
            result.Add(remaining[0]);
            
            foreach (int i in result)
                Console.Write(i);
            Console.WriteLine();

        }
    }
}
