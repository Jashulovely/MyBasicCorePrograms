using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class DivisionProperties
    {
        public void QuotientRemainder()
        {
            Console.WriteLine("Enter the Dividend Value.");
            int dividend = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Divisor Value.");
            int divisor = int.Parse(Console.ReadLine());

            Console.WriteLine("The Quotient for given number is " + dividend / divisor);
            Console.WriteLine("The Remainder for given number is " + dividend % divisor);

        }
    }
}
