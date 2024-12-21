using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstReview
{
    internal class PerfectSquare
    {
        public static void CheckPerfectSquare()
        {
            Console.WriteLine("Enter the Num:");
            int n = Convert.ToInt32(Console.ReadLine());
            bool isPerfect = false;

            if (n < 0)
            {
                Console.WriteLine("Enter a positive Num");
                return;
            }

            for(int i =0;i*i <= n; i++)
            {
                if((i*i) == n)
                {
                    isPerfect = true;
                    break;
                }
            }

            if (isPerfect)
            {
                Console.WriteLine("It has a perfect Square");
            }
            else
            {
                Console.WriteLine("It has not a perfect Square");
            }
        }
    }
}
