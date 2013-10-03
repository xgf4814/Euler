using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem13
{
    class Program
    {
        static void Main(string[] args)
        {
            string sum;
            string[] data;

            if (args.Length == 0)
                data = EulerData.s;
            else
                data = args;

            sum = data[0];
            for (int i = 1; i < data.Length; i++)
            {
                sum = StringAdd(sum, data[i]);
            }

            Console.WriteLine(sum);
            Console.WriteLine("First 10 digits: " + sum.Substring(0, 10));


        }

        public static string StringAdd(string a, string b)
        {

            while (a.Length != b.Length)
            {
                if (a.Length < b.Length)
                {
                    a = a.Insert(0, "0");
                }
                else if (b.Length < a.Length)
                {
                    b = b.Insert(0, "0");
                }
            }

            int l = a.Length;
            string c = "";

            int int_a;
            int int_b;
            int int_temp = 0;
            string temp = "";
            for (int i = l - 1; i >= 0; i--)
            {
                int_a = Int32.Parse(a.Substring(i, 1));
                int_b = Int32.Parse(b.Substring(i, 1));
                int_temp += int_a + int_b;
                temp = int_temp.ToString();

                //Console.WriteLine(i + ": " + int_temp);
                //Console.WriteLine(i + ": " + temp);

                if (int_temp < 10 || i == 0)
                {
                    c = c.Insert(0, temp);
                    int_temp = 0;
                }
                else
                {
                    c = c.Insert(0, temp.Substring(temp.Length - 1, 1));
                    int_temp = Int32.Parse(temp.Substring(0, 1));
                }
            }
            

            return c;
        }

    }
}
