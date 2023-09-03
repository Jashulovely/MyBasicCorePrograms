using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class SwapTwoNumbers
    {
        public void Swaping()
        {
            int num1, num2, temp;
            Console.WriteLine("Enter the first number");
            num1= int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Numbers before swaping num1 = {0}, num2 = {1}", num1, num2);

            temp = num1;
            num1 = num2;
            num2 = temp;

            Console.WriteLine("Numbers after swaping num1 = {0}, num2 = {1}", num1, num2);



        }
    }
}
