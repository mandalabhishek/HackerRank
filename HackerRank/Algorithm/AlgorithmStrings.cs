using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithm
{
    class AlgorithmStrings
    {
        public static void CamelCase()
        {
            Console.Write("Enter a string (count for upper case character):");
            string dummy = Console.ReadLine();
            int b = 1;
            for (int i = 0; i < dummy.Length; i++)
            {
                if (dummy[i].ToString() == dummy[i].ToString().ToUpper())
                {
                    b++;
                }
            }
            Console.WriteLine("No. of words :" + (b));
            Console.ReadKey();
        }
    }
}
