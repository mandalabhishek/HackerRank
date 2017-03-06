using System;

namespace HackerRank.Algorithm
{
    class AlgorithmWarmUpSwitch
    {
        public static void AlgorithmWarmUpList()
        {
            try
            {
                Begin:
                Console.WriteLine("\nEnter Your Choice For :" +
                                  "\n\t\t\t1.Simple sum" +
                                  "\n\t\t\t2.Array sum" +
                                  "\n\t\t\t3.Compare the triplets" +
                                  "\n\t\t\t4.Sum of big integer array" +
                                  "\n\t\t\t5.Diagonal Difference" +
                                  "\n\t\t\t6.Count +ve or -ve int in a Array" +
                                  "\n\t\t\t7.StairCase" +
                                  "\n\t\t\t8.Min & Max Sum" +
                                  "\n\t\t\t9.Time Conversion");
                Console.Write("\nYour Choice : ");
                int supply = Convert.ToInt32(Console.ReadLine());
                switch (supply)
                {
                    case 1:
                    {
                        AlgorithmWarmUp.SimpleSum();
                        break;
                    }
                    case 2:
                    {
                        AlgorithmWarmUp.ArraySum();
                        break;
                    }
                    case 3:
                    {
                        AlgorithmWarmUp.Triplets();
                        break;
                    }
                    case 4:
                    {
                        AlgorithmWarmUp.BigSum();
                        break;
                    }
                    case 5:
                    {
                        AlgorithmWarmUp.DiagonalDifference();
                        break;
                    }
                    case 6:
                    {
                        AlgorithmWarmUp.PlusMinus();
                        break;
                    }
                    case 7:
                    {
                        AlgorithmWarmUp.Staircase();
                        break;
                    }
                    case 8:
                    {
                        AlgorithmWarmUp.MinMaxSum();
                        break;
                    }
                    case 9:
                    {
                        AlgorithmWarmUp.TimeConversation();
                        break;
                    }
                    default:
                        Console.WriteLine("\nEnter a valid choice given in list.");
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
                Console.Write("\nDo you want to continue on Algorithms Warmup: ");
                input = Convert.ToString(Console.ReadLine().ToLower());
                if (input == "yes")
                {
                    AlgorithmWarmUpList();
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
