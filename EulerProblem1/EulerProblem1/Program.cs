﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                sum += (i % 3 == 0 || i % 5 == 0) ? i : 0;
            }
            Console.WriteLine(sum);
        }
    }
}
