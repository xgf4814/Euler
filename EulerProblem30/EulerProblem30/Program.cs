using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem30
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sums = new List<int>();
            string s = "";
            int sum;
            for (int x = 2; x <= 236196; x++) //236196 for 5, 26244 for 4
            {
                sum = 0;
                s = x.ToString();
                
                for(int i = 0; i < s.Length; i++)
                {
                    sum += (int)Math.Pow((double)int.Parse(s.Substring(i, 1)), (double)5);
                }

                if (sum == x)
                {
                    Console.WriteLine(x);
                    sums.Add(x);
                }    
            }

            sum = 0;
            foreach(int x in sums)
            {
                sum += x;
            }
            Console.WriteLine("Sum Total = " + sum);

        }
    }
}
