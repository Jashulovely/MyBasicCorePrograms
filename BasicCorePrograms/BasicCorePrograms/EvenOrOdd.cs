using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class EvenOrOdd
    {
        public void Check()
        {
            Console.WriteLine("Enter a number.");
            int num = int.Parse(Console.ReadLine());

            if(num % 2 == 0)
            {
                Console.WriteLine("Entered Number is a EVEN Number.");
            }
            else
            {
                Console.WriteLine("Entered Number is a ODD Number.");
            }
        }
    }
}
