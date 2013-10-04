using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> palindromes = new List<int>();
            int product;
            for (int i = 999; i >= 100; i--)
            {
                for (int j = 999; j >= 100; j--)
                {
                    product = i * j;
                    if (isPalindrome(product))
                    {
                        //Console.WriteLine(product);
                        palindromes.Add(product);
                    }
                }
            }

            int largest = 0;
            foreach (int palindrome in palindromes)
            {
                if (palindrome > largest)
                    largest = palindrome;
            }

            Console.WriteLine(largest);

        }

        private static bool isPalindrome(int product)
        {
            string s = product.ToString();
            char [] c = s.ToCharArray();

            for(int i = 0; i <= ((s.Length % 2 == 0) ? ((s.Length/2)-1) : (((s.Length-1)/2)-1)); i++)
            {
                if(c[i] != c[(s.Length-1)-i])
                    return false;
            }

            return true;
        }
    }
}
