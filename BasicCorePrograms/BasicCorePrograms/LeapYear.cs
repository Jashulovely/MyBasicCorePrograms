using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LeapYear
    {
        public void IsLeapYear()
        {
            Console.WriteLine("Please Enter a Four Digit Number.");
            int year = int.Parse(Console.ReadLine());
            if (year >= 1000 && year<=9999)
            {
                if((year % 4 == 0 && year % 100 !=0) || (year % 400 == 0))
                {
                    Console.WriteLine(year + " IS A LEAP YEAR");
                }
                else
                {
                    Console.WriteLine(year + " IS NOT A LEAP YEAR");
                }

            }
            else
            {
                Console.WriteLine("Please Enter a Valid Four Digit Number.");
                IsLeapYear();
            }
        }
    }
}
