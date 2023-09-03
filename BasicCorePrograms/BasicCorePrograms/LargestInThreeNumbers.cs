using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class LargestInThreeNumbers
    {
        public void LargestNumber()
        {
            int number1, number2, number3;
            string result;

            Console.Write("Enter the first number :");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the second number :");
            number2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the third number :");
            number3 = Convert.ToInt32(Console.ReadLine());

            if (number1 > number2 && number1 > number3)
            {
                result = "The 1st Number is the greatest among three  : " + number1;
            }
            else if (number2 > number1 && number2 > number3)
            {
                result = "The 2nd Number is the greatest among three : " + number2;
            }
            else
            {
                result = "The 3rd Number is the greatest among three : " + number3;
            }

            Console.WriteLine(result);
        }
    }
}
