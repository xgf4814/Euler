using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem28
{
    class Program
    {
        enum Directions { right, down, left, up };
        
        static void Main(string[] args)
        {
            int size = int.Parse(args[0]);
            int[,] spiral = new int[size,size];

            if (size % 2 == 0)
                throw new Exception("Size must be odd");

            // Center the indices
            int x = (size / 2);
            int y = x;

            int dir = 0;
            int kernel = 1;
            int shift = kernel;
            int shiftCount = 0;

            for(int i = 1; i <= (size*size); i++)
            {

                if (shift == 0)
                {
                    dir = (dir + 1) % 4;
                    shiftCount++;
                    if (shiftCount % 2 == 0)
                    {
                        kernel++;
                    }
                    shift = kernel;
                }

                spiral[x, y] = i;
                Move((Directions)dir, ref x, ref y);

                shift--;

            }

            // Add the diagonals together
            int sum = 1;
            for (int i = 0; i < (size / 2); i++)
            {
                sum += spiral[i, i];
                sum += spiral[(size - 1) - i, (size - 1) - i];
                sum += spiral[i, (size - 1) - i];
                sum += spiral[(size - 1) - i, i];
            }
            Console.WriteLine(sum);

            // Debug
            /*
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(spiral[i, j] + "\t");
                }
                Console.WriteLine();
            }
            */

        }

        static void Move(Directions d, ref int x, ref int y)
        {
            if (d == Directions.up)
            {
                x = x - 1;
            }
            else if (d == Directions.down)
            {
                x = x + 1;
            }
            else if (d == Directions.left)
            {
                y = y - 1;
            }
            else if (d == Directions.right)
            {
                y = y + 1;
            }
            else
            {
                throw new Exception("This shouldn't happen");
            }
        }

    }
}
