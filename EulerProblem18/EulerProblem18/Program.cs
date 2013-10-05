using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem18
{
    class Program
    {
        static void Main(string[] args)
        {

            List<string> input = new List<string>();

            int counter = 0;
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file =
               new System.IO.StreamReader(args[0]);
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
                input.Add(line);
                counter++;
            }

            file.Close();

            Console.WriteLine();

            int[][] triangle = new int[input.Count][];
            int i = 0;
            foreach (string s in input)
            {
                Console.WriteLine(i + ": " + s);
                triangle[i] = input[i].Split(' ').Select(p => int.Parse(p)).ToArray();
                i++;
            }

            Console.WriteLine();

            foreach(int[] xx in triangle)
            {
                foreach (int x in xx)
                {
                    Console.Write(x + " ");
                }
                Console.WriteLine();
            }
            
        }
    }
}
