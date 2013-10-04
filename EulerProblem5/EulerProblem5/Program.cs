using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem5
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 2520;

            while (true)
            {
                if(start % 20 == 0)
                    if(start % 19 == 0)
                        if(start % 18 == 0)
                            if(start % 17 == 0)
                                if(start % 16 == 0)
                                    if(start % 15 == 0)
                                        if(start % 14 == 0)
                                            if(start % 13 == 0)
                                                if(start % 12 == 0)
                                                    if(start % 11 == 0)
                                                        if(start % 9 == 0)
                                                            if (start % 7 == 0)
                                                            {
                                                                Console.WriteLine(start);
                                                                return;
                                                            }



                start++;
            }

        }
    }
}
