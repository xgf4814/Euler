using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using EulerLib;

namespace EulerProblem29
{
    class DistinctPowers
    {

        public DistinctPowers(int limit)
        {
            int size = limit - 1;
            Solve(limit, size);
        }

        public void SolveNaive(int limit, int size)
        {
            int i, j, a, b;
            string[,] stringGrid = new string[size, size];
            for (i = 0, a = 2; a <= limit; i++, a++)
            {
                for (j = 0, b = 2; b <= limit; j++, b++)
                {
                    stringGrid[i, j] = EulerLib.StringInt.Power(a, b);
                    Console.Write(stringGrid[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public void Solve(int limit, int size)
        {
            EulerLib.XMath.Power zero = new EulerLib.XMath.Power(0,0);
            EulerLib.XMath.Power[,]grid = new EulerLib.XMath.Power[size, size];
            int i, j, a, b;
            // Fill out the array
            for (i = 0, a = 2; a <= limit; i++, a++)
            {
                for (j = 0, b = 2; b <= limit; j++, b++)
                {
                    if (grid[i, j] == zero)
                    {
                        grid[i, j] = new EulerLib.XMath.Power(a, b);
                        if (grid[i, j].Evaluate() <= (double)limit)
                        {
                            for (int k = 0; k < size; k++)
                            {
                                grid[(int)grid[i, j].Evaluate()-2, k] = new EulerLib.XMath.Power(a, b*(k+2), true);
                            }
                        }
                    }
                }
            }


            // Adding items to set & Debug Output
            SortedSet<EulerLib.XMath.Power> distinct = new SortedSet<EulerLib.XMath.Power>();
            for (i = 0, a = 2; a <= limit; i++, a++)
            {
                for (j = 0, b = 2; b <= limit; j++, b++)
                {
                    Console.Write(grid[i, j] + (grid[i,j].dupe ? "*" : "" ) + "\t");
                    distinct.Add(new EulerLib.XMath.Power(grid[i, j].x, grid[i, j].y));
                }
                Console.WriteLine();
            }

            
            Console.WriteLine("\nDistinct Elements:");
            
            foreach (EulerLib.XMath.Power p in distinct)
            {
                Console.WriteLine(p + "\t" + p.Evaluate());
            }

            Console.WriteLine("\nTotal Distinct Elements: " + distinct.Count);
            
        }

        static void Main(string[] args)
        {

            DistinctPowers dp = new DistinctPowers(int.Parse(args[0]));

        }
    }
}
