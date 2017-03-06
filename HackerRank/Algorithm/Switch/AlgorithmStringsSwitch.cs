using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithm
{
    class AlgorithmStringsSwitch
    {
        public static void StringsList()
        {
            try
            {
                Begin:
                Console.WriteLine("\nEnter Your Choice For :" +
                                  "\n\t\t\t1.Camel Case ");
                Console.Write("\nYour Choice : ");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        {
                            AlgorithmStrings.CamelCase();
                            break;
                        }
                    default:
                        Console.WriteLine("Enter a valid choice given in list.");
                        goto Begin;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("\nError Occurred : " + ex.Message);
            }
            finally
            {
                string input = string.Empty;
                Last:
                input = String.Empty;
                Console.Write("\nDo you want to continue on Algorithm Strings : ");
                input = Convert.ToString(Console.ReadLine().ToLower());
                if (input == "yes")
                {
                    StringsList();
                }
                else if (input.Contains("no"))
                {
                }
                else
                {
                    Console.WriteLine("\nEnter a valid input.");
                    goto Last;
                }
            }
        }
    }
}
