using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EulerProblem19
{
    class Program
    {

        public static int[] monthLengths = {31,28,31,30,31,30,31,31,30,31,30,31};
        public static string[] months = {"Jan","Feb","Mar","Apr","May","Jun","Jul","Aug","Sep","Oct","Nov","Dec"};
        public static string[] days = {"Sun","Mon","Tue","Wed","Thu","Fri","Sat"};

        static void Main(string[] args)
        {
            int day = 1; // Sunday is 0
            int date = 0; // 0 is 1st of month
            int month = 0; // 0 is January
            int year = 1900;

            int sum = 0;
            int count = 0;

            while (year < 2001)
            {
                // Incement DAY OF WEEK
                day = (day + 1) % 7;

                // Increment DATE
                date = (date + 1) % (monthLengths[month]);

                if (date == 0)
                {
                    // Increment MONTH
                    month = (month + 1) % 12;

                    if (month == 0)
                    {
                        // Increment YEAR
                        year++;
                        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
                        {
                            //Console.WriteLine(year);
                            monthLengths[1] = 29;
                        }
                        else
                        {
                            monthLengths[1] = 28;
                        }
                    }
                }

                //Console.WriteLine(count++ + ": " + days[day] + ", " + months[month] + " " + (date + 1) + " " + year);

                if (year >= 1901 && day == 0 && date == 0)
                {
                    sum++;
                    Console.WriteLine(months[month] + " " + year);
                }
            }

            Console.WriteLine(sum);

        }
    }
}
