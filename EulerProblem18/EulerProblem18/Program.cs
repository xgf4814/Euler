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
                input.Add(line);
                counter++;
            }
            file.Close();

            int[][] triangle = new int[input.Count][];
            for (int i = 0; i < input.Count; i++)
            {
                triangle[i] = input[i].Split(' ').Select(p => int.Parse(p)).ToArray();
            }

            for (int i = triangle.Length-2; i >= 0; i--)
            {
                for (int k = 0; k < triangle[i].Length; k++)
                {
                    triangle[i][k] += triangle[i + 1][k] > triangle[i + 1][k + 1] ? triangle[i + 1][k] : triangle[i + 1][k + 1];
                }
            }

            Console.WriteLine(triangle[0][0]);

        }
    }
}
