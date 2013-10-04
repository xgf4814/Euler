using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerLib
{
    class StringInt
    {

        public static string Multiply(string a, string b)
        {
            if (Int64.Parse(a) != 2 && Int64.Parse(b) != 2)
            {
                throw new NotImplementedException();
            }


            // We're only going to support multiplying by two for now
            return ShiftLeft( (Int64.Parse(a) == 2 ? a : b ));
        }

        public static string ShiftLeft(string a)
        {
            return " ";
        }

        public static string Add(string a, string b)
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
