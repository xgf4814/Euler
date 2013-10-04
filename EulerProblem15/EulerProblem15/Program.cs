using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem15
{
    class Program
    {

        int size = 0;
        long[,] a;

        public Program(int s)
        {
            size = s;
            a = new long[size, size];
            ArrayAlgorithm();
            Console.WriteLine(a[0,0]);
        }

        static void Main(string[] args)
        {
            Program p = new Program(Int32.Parse(args[0]));
        }
        
        void ArrayAlgorithm()
        {
            
            // Go in a diagonal from the bottom right
            for (int diag = size - 1; diag >= 0; diag--)
            {
                //a[diag, diag] = diag;
                ValueSet(diag, diag);

                // Traverse North & West
                for (int x = diag-1; x >= 0; x--)
                {
                    //a[x, diag] = diag;
                    ValueSet(x, diag);
                    //a[diag, x] = diag;
                    ValueSet(diag, x);
                }

            }

        }

        void ValueSet(int x, int y)
        {
            a[x, y] = ValueGet(x + 1, y) + ValueGet(x, y + 1);
        }

        long ValueGet(int x, int y)
        {
            if (x < size && y < size)
            {
                return a[x, y];
            }
            else
            {
                return 1;
            }
        }

        /*
        static void RecursiveRouteFinder(int size, int x, int y)
        {
            if (x < size)
            {
                //Console.Write("R ");
                RecursiveRouteFinder(size, x + 1, y);
            }
            
            if (y < size)
            {
                //Console.Write("D ");
                RecursiveRouteFinder(size, x, y + 1);
            }

            if (x == size && y == size)
            {
                num++;
                //Console.WriteLine(num);
                Console.Write("\r{0}   ", num);
            }

        }*/

    }
}
