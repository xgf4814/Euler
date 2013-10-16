using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem23
{
    class Program
    {
        static void Main(string[] args)
        {
             
            // Go from 12 to 28123 and find all abundant numbers, store them in a List
            List<int> abundantNums = new List<int>();
            for (int i = 12; i <= 28123; i++)
            {
                if (EulerLib.XMath.IsAbundant(i))
                {
                    abundantNums.Add(i);
                }
            }

            // Instantiate an array that's twice the size of the largest abundant number + 1
            int largest = abundantNums[abundantNums.Count - 1];
            //bool[] scratch = new bool[(largest * 2)+1];
            bool[] scratch = new bool[28124];

            // The default value in that array is false. If the corresponding value in the array
            // can be written as the sum of two abundant numbers, set the value to true.
            while (abundantNums.Count > 0)
            {
                foreach (int i in abundantNums)
                {
                    if((abundantNums[0] + i) < scratch.Length)
                        scratch[abundantNums[0] + i] = true;
                }
                abundantNums.RemoveAt(0);
            }

            int sum = 0;
            for (int i = 0; i < scratch.Length; i++)
            {
                //Console.WriteLine(scratch[i] + "\t\t" + i);
                if (scratch[i] == false)
                    sum += i;
            }
            Console.WriteLine("SUM = " + sum);

        }
    }
}
