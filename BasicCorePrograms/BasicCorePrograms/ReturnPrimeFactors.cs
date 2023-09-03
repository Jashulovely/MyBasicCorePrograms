using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace BasicCorePrograms
{
    internal class ReturnPrimeFactors
    {
        public void PrimeFactors() {

            
            Console.WriteLine("Enter the number for prime factors.");
            int  num = Convert.ToInt32(Console.ReadLine());

            ArrayList factors = new ArrayList();
            ArrayList primeFactors = new ArrayList();
            //primeFactors.Add(1);

            int  i, j;
            float m = (float)num / 2;

            for (i = 1; i <= m; i++)
            {
                if(num % i == 0)
                {
                    factors.Add(i);
                }

            }

            foreach (var item in factors)
            {
                int flag = 0;
                int factor = Convert.ToInt32(item);  
                
                for (j = 2; j <= factor / 2; j++)
                {
                    if (factor % j == 0)
                    {

                        flag = 1;
                        break;

                    }
                }
                if(flag == 0)
                {
                    primeFactors.Add(factor);

                }
                
            }
            Console.Write("Total Factors of given number is : ");
            foreach (var item in factors)
            {
                Console.Write(item + ",");

            }
            Console.WriteLine();
            Console.Write("Prime Factors of given number is : ");
            foreach(var item in primeFactors)
            {
                Console.Write(item +",");
            }
            
            




        }
    }
}
