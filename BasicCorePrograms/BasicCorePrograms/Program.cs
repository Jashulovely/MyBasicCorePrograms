using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("Please Enter :  1 --> Flip Coin   2  --> Leap Year   3  -->  PowersOfTwo");
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1: FlipCoin fc = new FlipCoin();
                        fc.HeadsTails();
                        Console.ReadLine();
                    break;
                case 2: LeapYear lp = new LeapYear();
                        lp.IsLeapYear();
                        Console.ReadLine();
                    break;
                case 3: PowerOfTwo pot = new PowerOfTwo();
                        pot.TwoPowers();
                        Console.ReadLine();
                    break;


                default: 
                        Console.WriteLine("Please Enter a Valid Number.");
                        Console.ReadLine();
                    break;
            }
        }
    }
}
