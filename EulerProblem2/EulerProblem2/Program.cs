using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> l = new List<int>();
            int i = 1;
            int j = 2;
            int k = 2;
            l.Add(k);

            while (k < 4000000)
            {
                k = i + j;
                l.Add(k);
                i = j;
                j = k;
            }

            int sum = 0;
            foreach (int element in l)
            {
                if (element % 2 == 0)
                    sum += element;
            }

            Console.WriteLine(sum);
        }
    }
}
