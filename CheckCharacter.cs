using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstReview
{
    internal class CheckCharacter
    {
        public static bool CheckUniqueChar()
        {
            Console.WriteLine("Enter the String:");
            string s = Console.ReadLine();

            s = s.ToLower();
            for(int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (s[i] == s[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}
