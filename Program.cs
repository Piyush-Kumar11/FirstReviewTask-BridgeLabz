using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstReview
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TrafficLight.TrafficLightSystem();

            //CalculateWorkdays.NumberOfWorkdays();

            //SumOfEvenOdd.SumOfEvenOddDigits();

            //PerfectSquare.CheckPerfectSquare();

            if (CheckCharacter.CheckUniqueChar())
            {
                Console.WriteLine("Characters are Unique!");
            }
            else
            {
                Console.WriteLine("Duplicate characters present!");

            }
        }
    }
}
