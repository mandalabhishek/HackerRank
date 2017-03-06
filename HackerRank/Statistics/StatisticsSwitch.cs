using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Statistics
{
    class StatisticsSwitch
    {
        public static void StatisticsList()
        {
            try
            {
                Begin:
                Console.WriteLine("\nEnter Your Choice For :" +
                                  "\n\t\t\t1.Weighted Mean" +
                                  "\n\t\t\t2.Mean,Median & Mode" +
                                  "\n\t\t\t3.Standard Deviation");
                Console.Write("\nYour Choice : ");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                    {
                        Statistics.WeightedMean();
                        break;
                    }
                    case 2:
                    {
                        Statistics.MeanMedianMode();
                        break;
                    }
                    case 3:
                    {
                        Statistics.StandardDeviation();
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
                Console.Write("\nDo you want to continue on Statistics : ");
                input = Convert.ToString(Console.ReadLine().ToLower());
                if (input == "yes")
                {
                    StatisticsList();
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
