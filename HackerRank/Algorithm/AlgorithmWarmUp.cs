using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Algorithm
{
    public class AlgorithmWarmUp
    {
        public static int Sum(int a, int b)
        {
            int y = a + b;
            return y;
        }
        public static void SimpleSum()
        {
            Console.Write("Enter First value :");
            int val1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Second value :");
            int val2 = Convert.ToInt32(Console.ReadLine());
            int sum = Sum(val1, val2);
            Console.WriteLine("Sum of integer is :"+ sum);
        }
        public static void ArraySum()
        {
            int sum = 0;
            Console.WriteLine("Enter the array integer values (separated by space) :");
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            for (int i = 0; i < arr_temp.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine(sum);

        }
        public static void Triplets()
        {
            Console.WriteLine("\nComparing the win counts of two team.");
            Console.WriteLine("\nEnter integer array 1 (separated by spaces) :");
            string[] tokens_a0 = Console.ReadLine().Split(' ');
            Console.WriteLine("Enter integer array 2 (separated by spaces) :");
            string[] tokens_b0 = Console.ReadLine().Split(' ');
            int a = 0;
            int b = 0;
            for (int i = 0; i < 3; i++)
            {
                if (Convert.ToInt32(tokens_a0[i]) > Convert.ToInt32(tokens_b0[i]))
                {
                    a = a + 1;
                }
                if (Convert.ToInt32(tokens_a0[i]) < Convert.ToInt32(tokens_b0[i]))
                {
                    b = b + 1;
                }
            
                if (Convert.ToInt32(tokens_a0[i]) == Convert.ToInt32(tokens_b0[i]))
                {
                }
            }
            Console.WriteLine("Win score of team 1 :" + a + "\nWin score of team 2 :" + b);
        }
        public static void BigSum()
        {
            Console.WriteLine("\nEnter integer array (separated by space):");
            long sum = 0;
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);
            for (int i = 0; i < arr_temp.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("Sum of entered array is :"+sum);
        }
        public static void DiagonalDifference()
        {
            int sum = 0;
            int minus = 0;
            int final = 0;
            int count = 0;
            Console.WriteLine("Enter the size of Square :");
            int n = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Enter the {0} rows {0} values splitted by space :", n);
            int[][] a = new int[n][];
            for (int i = 0; i < n; i++)
            {
                string[] array = Console.ReadLine().Split(' ');
                a[i] = Array.ConvertAll(array, Int32.Parse);
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i == j)
                    {
                        sum = sum + a[i][j];
                    }
                }
            }
            for (int j = (n - 1); j >= 0; j--)
            {
                minus = minus + a[count][j];
                count++;
            }
            final = Math.Abs(sum - minus);
            Console.WriteLine("Diagonal Difference is :" + final);
        }
        public static void PlusMinus()
        {
            Console.WriteLine("\nEnter integer array (separated by space and can be +ve or -ve) :");
            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), Convert.ToInt32);
            float pos = 0;
            float neg = 0;
            float zer = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    pos = pos + 1;
                }

                if (arr[i] < 0)
                {
                    neg = neg + 1;
                }

                if (arr[i] == 0)
                {
                    zer = zer + 1;
                }
            }
            Console.WriteLine("Number of positive integers :" + pos);
            Console.WriteLine("Number of negative integers :" + neg);
            Console.WriteLine("Number of zero :" + zer);
        }
        public static void Staircase()
        {
            Console.WriteLine("Enter the size of Square :");
            int t = Convert.ToInt16(Console.ReadLine());
            for (int i = 1; i <= t; ++i)
            {
                for (int j = 1; j <= t; ++j)
                {
                    if (j <= (t - i))
                    {
                        Console.Write(" ");
                    }
                    else
                    {
                        Console.Write("#");
                    }
                }
                Console.WriteLine();
            }
        }
        public static void MinMaxSum()
        {
            Console.Write("Enter the length of Array for sum :");
            long n = Int64.Parse(Console.ReadLine());
            long[] array = new long[n];
            long temp = 0;
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter the entry no. {0} :", i + 1);
                array[i] = Int64.Parse(Console.ReadLine());
                temp = temp + array[i];
            }
            Array.Sort(array);
            Console.WriteLine("Maximum sum is :" + (temp - array[0]));
            Console.WriteLine("Minimum sum is :" + (temp - array[n - 1]));
            Console.ReadLine();
        }
        public static void TimeConversation()
        {
            Console.Write("Enter the time in 12 hour format:- ");
            string[] time = Console.ReadLine().Split(':');
            if (time[0] == "12" && time[1] == "00" && time[2].ToString().ToUpper() == "00AM")
            {
                Console.WriteLine("Time in 24 hour format is :- 00:00:00");
            }
            else if (time[0] == "12" && time[1] == "00" && time[2] == "00PM")
            {
                Console.WriteLine("Time in 24 hour format is :- 12:00:00");
            }
            else if (time[2].ToUpper().Contains("AM") && time[0] == "12")
            {
                Console.WriteLine("Time in 24 hour format is :- 00:{0}:{1}", time[1], time[2].Remove(startIndex: 2));
            }
            else if (time[2].ToUpper().Contains("AM"))
            {
                Console.WriteLine("Time in 24 hour format is :- {0}:{1}:{2}", time[0], time[1], time[2].Remove(startIndex: 2));
            }
            else if (time[2].ToUpper().Contains("PM") && time[0] == "12")
            {
                Console.WriteLine("Time in 24 hour format is :- {0}:{1}:{2}", (int.Parse(time[0])), time[1], time[2].Remove(startIndex: 2));
            }
            else if (time[2].ToUpper().Contains("PM"))
            {
                Console.WriteLine("Time in 24 hour format is :- {0}:{1}:{2}", (int.Parse(time[0]) + 12), time[1], time[2].Remove(startIndex: 2));
            }
            Console.ReadKey();
        }
    }
}


