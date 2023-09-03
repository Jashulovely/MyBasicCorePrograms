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
            

            Console.WriteLine("Please Enter :  1 --> Flip Coin   2  --> Leap Year   3  -->  Powers Of Two   4  -->  Harmonic Number \n  " +
                "5  -->  Prime Factors   6  -->  Quotient And Remainder   7  -->  Swaping Two Numbers   8   -->  Even Or Odd   9  -->  Vowel Or Not" +
                "10  -->  Largest Number   11  -->  Harmonic Series");
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
                case 4: HarmonicNumber hn = new HarmonicNumber();
                        hn.Harmonic();
                        Console.ReadLine();
                    break;
                case 5: ReturnPrimeFactors rpf = new ReturnPrimeFactors();
                        rpf.PrimeFactors();
                        Console.ReadLine();
                    break;
                case 6: DivisionProperties dp = new DivisionProperties();
                        dp.QuotientRemainder();
                        Console.ReadLine();
                    break;
                case 7: SwapTwoNumbers swt = new SwapTwoNumbers();
                         swt.Swaping();
                         Console.ReadLine();
                    break;
                case 8: EvenOrOdd eo = new EvenOrOdd();
                        eo.Check();
                        Console.ReadLine();
                    break;
                case 9: Vowel v = new Vowel();
                        v.Check();
                        Console.ReadLine();
                    break;
                case 10: LargestInThreeNumbers lar = new LargestInThreeNumbers();
                         lar.LargestNumber();
                         Console.ReadLine();
                    break;
                case 11: HarmonicSeries hs = new HarmonicSeries();
                         hs.Harmonic();
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
