using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class HarmonicNumber
    {
        public void Harmonic()
        {
            Console.WriteLine("Enter The Number of terms for Harmonic expression.");

            int i, n;
            double s = 0.0;

            
            n = Convert.ToInt32(Console.ReadLine());
            
            for (i = 1; i <= n; i++)
            {
                if(i == n)
                {
                    Console.Write("1/{0}", i);
                    s += 1 / (float)i;
                    break;
                }
                Console.Write("1/{0} + ", i);
                s += 1 / (float)i;
            }
            Console.Write("\nSum of Series upto {0} terms : {1} \n", n, s);
        }
    }
}
