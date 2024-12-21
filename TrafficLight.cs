using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstReview
{
    internal class TrafficLight
    {
        public static void TrafficLightSystem()
        {
            string currLight = "Red";

            while (true)
            {
                if (currLight == "Red")
                {
                    Console.WriteLine("Red: Stop");
                }
                else if (currLight == "Green")
                {
                    Console.WriteLine("Green: Go");
                }
                else if (currLight == "Yellow")
                {
                    Console.WriteLine("Yellow: Wait!");
                }

                Console.WriteLine("Enter s to switch the light");
                char c = Convert.ToChar(Console.ReadLine());

                if(c =='s' || c == 'S')
                {
                    if (currLight == "Green")
                        currLight = "Yellow";
                    else if (currLight == "Red")
                        currLight = "Green";
                    else if (currLight == "Yellow")
                        currLight = "Red";
                }
                else
                {
                    return;
                }
            }
        }
    }
}
