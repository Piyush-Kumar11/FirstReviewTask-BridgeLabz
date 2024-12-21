using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstReview
{
    internal class SumOfEvenOdd
    {
        public static void SumOfEvenOddDigits()
        {
            Console.WriteLine("Enter the Number:");
            int num = Convert.ToInt32(Console.ReadLine());
            int evenSum = 0;
            int oddSum = 0;

            while (num > 0)
            {
                int rem = num % 10;
                if (rem % 2 == 0)
                {
                    evenSum += rem;
                }
                else
                {
                    oddSum += rem;
                }
                num = num / 10;
            }
            Console.WriteLine("Sum of Even Digits:" + evenSum);
            Console.WriteLine("Sum of Odd Digits:" + oddSum);

        }
    }
}
