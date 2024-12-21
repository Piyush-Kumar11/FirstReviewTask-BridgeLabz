using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstReview
{
    internal class CalculateWorkdays
    {
        public static void NumberOfWorkdays()
        {
            Console.WriteLine("Enter the start date (yyyy-mm-dd):");
            DateTime start = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter the end date (yyyy-mm-dd):");
            DateTime end = DateTime.Parse(Console.ReadLine());

            if (start > end)
            {
                Console.WriteLine("The start date must be before the end date!!!");
                return;
            }

            int count = 0;

            for (DateTime d = start; d <= end; d = d.AddDays(1))
            {
                if (d.DayOfWeek !=DayOfWeek.Saturday && d.DayOfWeek!= DayOfWeek.Sunday)
                {
                    count++;
                }
            }
            Console.WriteLine("Total Working Days: " + count);
        }
    }
}
