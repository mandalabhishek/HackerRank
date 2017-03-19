using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.StartDays
{
    class StartDaysSwitch
    {
        public static void StartDaysList()
        {
            try
            {
                Begin:
                Decide:
                Console.WriteLine("\nEnter Your Choice For :" +
                                  "\n\t\t\t1.Hello World" +
                                  "\n\t\t\t2.Operator" +
                                  "\n\t\t\t3.Conditional" +
                                  "\n\t\t\t4.Array String Sorting (Even & Odd)" +
                                  "\n\t\t\t5.Array Reversal" +
                                  "\n\t\t\t6.Factorial" +
                                  "\n\t\t\t7.Boolean Conversion and Consecutive counts" +
                                  "\n\t\t\t8.Inheritance" +
                                  "\n\t\t\t9.Parsing" +
                                  "\n\t\t\t10.Calculator" +
                                  "\n\t\t\t11.Sorting" +
                                  "\n\t\t\t12.Prime Number" +
                                  "\n\t\t\t13.Loops" +
                                  "\n\t\t\t14.Classes and Instance" +
                                  "\n\t\t\t15.Interface" +
                                  "\n\t\t\t16.Nested Logic " +
                                  "\n\t\t\t17.String Patterns");
                Console.Write("\nYour Choice : ");
                int input = Convert.ToInt32(Console.ReadLine());
                switch (input)
                {
                    case 1:
                    {
                        StartDaysCode.HelloWorld();
                        break;
                    }
                    case 2:
                    {
                        StartDaysCode.Operator();
                        break;
                    }
                    case 3:
                    {
                        StartDaysCode.Conditional();
                        break;
                    }
                    case 4:
                    {
                        StartDaysCode.ArrayStringSorting();
                        break;
                    }
                    case 5:
                    {
                        StartDaysCode.ArrayReverse();
                        break;
                    }
                    case 6:
                    {
                        StartDaysCode.Factorial();
                        break;
                    }
                    case 7:
                    {
                        StartDaysCode.BooleanConsecutive();
                        break;
                    }
                    case 8:
                    {
                        Inheritance.Start();
                        break;
                    }
                    case 9:
                    {
                        StartDaysCode.Parsing();
                        break;
                    }
                    case 10:
                    {
                        Console.Write("Enter the number of Test Cases :");
                        int x = int.Parse(Console.ReadLine());
                        string[] m = new string[x];

                        for (int i = 0; i < x; i++)
                        {
                            Console.WriteLine("Enter two integer separated by space Case {0} :", i + 1);
                            m[i] = Console.ReadLine();
                        }
                        for (int i = 0; i < x; i++)
                        {
                            int[] z = Array.ConvertAll(m[i].Split(' '), Int32.Parse);
                            int n = z[0];
                            int p = z[1];
                            StartDaysCode.Calculator(n, p);
                        }
                        break;
                    }
                    case 11:
                    {
                        StartDaysCode.Sorting();
                        break;
                    }
                    case 12:
                    {
                        StartDaysCode.Prime();
                        break;
                    }
                    case 13:
                        {
                            StartDaysCode.Loops();
                            break;
                        }
                    case 14:
                        {
                            ClassInstance.Instance();
                            break;
                        }
                    case 15:
                        {
                            Interface.InterfaceQuiz();
                            break;
                        }
                    case 16:
                        {
                            StartDaysCode.NestedLogic();
                            break;
                        }
                    case 17:
                        {
                            StartDaysCode.StringPatterns();
                            break;
                        }
                    default:
                        Console.WriteLine("Enter a valid choice given in list.");
                        goto Decide;
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
                Console.Write("\nDo you want to continue on Start days code : ");
                input = Convert.ToString(Console.ReadLine().ToLower());
                if (input == "yes")
                {
                    StartDaysList();
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
