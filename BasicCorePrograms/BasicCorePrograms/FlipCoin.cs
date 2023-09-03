using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class FlipCoin
    {
        float headsCount = 0;
        float tailsCount = 0;
        public void HeadsTails()
        {
            Console.WriteLine("Enter The Number Of Times To Flip The Coin");

            int num = int.Parse(Console.ReadLine());

            Random ran = new Random();

            for (int i = 1; i <= num; i++)
            {
                

                if(ran.NextDouble() > 0.5)
                {
                    headsCount++;
                }
                else
                {
                    tailsCount++;
                }


            }

            float headsPercentage = headsCount / num * 100;
            float tailsPercentage = tailsCount / num * 100;

            Console.WriteLine("Heads Percentage = " + headsPercentage + "%");
            Console.WriteLine("Tails Percentage = " + tailsPercentage + "%");

        }
    }
}
