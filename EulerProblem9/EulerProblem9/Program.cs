using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem9
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int a = 1; a <= 998; a++)
            {
                for (int b = 999 - a; b >= 1; b--)
                {
                    int c = 1000 - (a + b);

                    if ((a * a + b * b) == (c * c))
                    {
                        Console.WriteLine(a * b * c);
                        return;
                    }
                                        
                }
            }

        }
    }
}
