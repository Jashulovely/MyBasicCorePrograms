using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class PowerOfTwo
    {
        public void TwoPowers() {

            Console.WriteLine("Please Enter the Number for the Table List of Powers of 2");
            int num = Convert.ToInt32(Console.ReadLine());

            
           // int isLeapYear = 2;
            int powerValue;

            if(num < 31)
            {
                for(int i = 1; i <= num; i++)
                {
                    powerValue = (int) Math.Pow(2, i);
                    Console.WriteLine("2" + " power " + i + " = " + powerValue);

                    //isLeapYear = isLeapYear * i;

                    if ((powerValue % 4 == 0 && powerValue % 100 != 0) || (powerValue % 400 == 0))
                    {
                        Console.WriteLine(powerValue + " IS A LEAP YEAR");
                    }
                    else
                    {
                        Console.WriteLine(powerValue + " IS NOT A LEAP YEAR");
                    }
                }
            }
            else
            {
                Console.WriteLine("Number greater than 31 Over flows the range of int data type. Please provide value less than 31.");
                TwoPowers();
            }


        }
    }
}
