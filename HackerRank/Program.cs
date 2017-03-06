using System;
using HackerRank.StartDays;
using HackerRank.Algorithm;
using HackerRank.Statistics;

namespace HackerRank
{
    public class Program
    {
        private static void Main()
        {
            Console.WriteLine("\t\t\t\t\t*** Welcome To Hacker Rank Solutions ***" +
                              "\n\t\t\t\t\t    ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
            ConsoleDisplay();
            Console.WriteLine("\n\n\t\t\t\t\t\t\t\t\t\t\tMade By:" +
                              "\n\t\t\t\t\t\t\t\t\t\t\t\tAbhishek Mandal" +
                              "\n\t\t\t\t\t\t\t\t\t\t\t\t8446970962");
            Console.ReadKey();
        }

        public static void ConsoleDisplay()
        {
            string result = String.Empty;
            try
            {
                Start:
                int mainChoice = 0;
                Console.WriteLine("\n\t\t\t\t\t\t    #Region-Main");
                Console.WriteLine("\nEnter Your Choice For :" +
                              "\n\t\t\t1.Algorithms" +
                              "\n\t\t\t2.SQL" +
                              "\n\t\t\t3.Start Days Code" +
                              "\n\t\t\t4.Statistics");
                Console.Write("\nYour Choice : ");
                try
                {
                    mainChoice = Int32.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("\nEnter a numeric value.");
                    goto Start;
                }
                switch (mainChoice)
                {
                    case 1:
                        {
                            Console.WriteLine("\n\t\t\t\t\t\t#Region-Main-Algorithm");
                            AlgorithmSwitch algorithmRank = new AlgorithmSwitch();
                            algorithmRank.AlgorithmList();
                            break;
                        }
                    case 2:
                        {
                            SQL.SQL.SQLList();
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("\n\t\t\t\t\t\t#Region-Main-Start Days");
                            StartDaysSwitch.StartDaysList();
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("\n\t\t\t\t\t\t #Region-Main-Statistics");
                            StatisticsSwitch.StatisticsList();
                            break;
                        }
                    default:
                        Console.WriteLine("\nEnter a valid choice given in list.");
                        goto Start;
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
                Console.Write("\nDo you want to continue on Hacker Rank Solutions: ");
                input = Convert.ToString(Console.ReadLine().ToLower());
                if (input == "yes")
                {
                    ConsoleDisplay();
                }
                else if (input.Contains("no"))
                {
                Console.WriteLine("\n\n\t\t\t\t* Thanks For Using Hacker Rank Solution Application *");
                Console.ReadKey();
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

