using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.StartDays
{
    public class StartDaysCode
    {
        public static void HelloWorld()
        {
            Console.Write("\nEnter your name :");
            String inputString = Console.ReadLine();
            Console.Write("Input String is : Hello " + inputString);
            Console.ReadKey();
        }
        public static void Operator()
        {
            Console.Write("\nEnter MealCost:");
            double mealCost = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter TipPercent:");
            double tipPercent = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter TaxPercent:");
            double taxPercent = Convert.ToDouble(Console.ReadLine());
            double tip = mealCost * (tipPercent / 100);
            double tax = mealCost * (taxPercent / 100);
            double totalCost = mealCost + tip + tax;
            double X = Math.Round(totalCost);
            Console.WriteLine("The total meal cost is {0} dollars.", X);
            Console.ReadKey();
        }
        public static void Conditional()
        {
            Console.Write("\nEnter Varible N:");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 != 0)
            {
                Console.WriteLine("Weird");
            }
            else
            {
                if (2 <= n && n <= 5)
                {
                    Console.WriteLine("Not Weird");
                }
                if (6 <= n && n <= 20)
                {
                    Console.WriteLine("Weird");
                }
                if (20 < n)
                {
                    Console.WriteLine("Not Weird");
                }
            }
            Console.ReadKey();
        }
        public static void Loops()
        {
            Console.Write("Enter the table no. to be printed :");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int a = 1; a <= 10; a = a + 1)
            {
                //int x = 0;
                int x = n * a;
                Console.WriteLine("{0} x {1} = {2}", n, a, x);
            }
        }
        public static void ArrayStringSorting()
        {
            Console.Write("\nEnter the number of string require to sort : ");
            int n = int.Parse(Console.ReadLine());
            string[] dummy = new string[n];
            for (int i = 0; i <= (n - 1); i++)
            {
                Console.Write("Enter your String {0} :", i + 1);
                dummy[i] = Convert.ToString(Console.ReadLine());
            }
            string dummyc = string.Empty;
            string dummyd = string.Empty;
            for (int i = 0; i < n; i++)
            {
                int m = dummy[i].Length;
                for (int j = 0; j < m; j++)
                {
                    if (j % 2 == 0)
                    {
                        string c = Convert.ToString(dummy[i][j]);
                        dummyc += c;
                    }
                }
                Console.Write("Sorted Even String " + (i + 1) + " is :" + dummyc);
                Console.Write(" ");
                for (int j = 0; j < m; j++)
                {
                    if (j % 2 != 0)
                    {
                        string c = Convert.ToString(dummy[i][j]);
                        dummyd += c;
                    }
                }
                Console.Write("\nSorted Odd String " + (i + 1) + " is :" + dummyd);
                Console.WriteLine();
            }
        }
        public static void ArrayReverse()
        {
            Console.Write("\nEnter integer array (separated by space):");
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = System.Array.ConvertAll(arr_temp, Int32.Parse);
            string reversed = String.Empty;
            for (int i = (arr_temp.Length - 1); i >= 0; i--)
            {
                reversed += arr_temp[i].ToString() + " ";
            }
            Console.Write("Reversed array is: " + reversed);
            Console.ReadLine();
        }
        public static void Factorial()
        {
            Console.Write("\nEnter the positive integer for factorial :");
            int p = int.Parse(Console.ReadLine());
            int result = p;
            for (int n = 1; n < p; n++)
            {
                result = result * (n);
            }
            Console.WriteLine("Factorial of input integer is :{0}", result);
            Console.ReadKey();
        }
        public static void BooleanConsecutive()
        {
            string reminder = "";
            Console.Write("\nEnter the Number :");
            int dummy = int.Parse(Console.ReadLine());
            for (int x = dummy; x >= 1;)
            {
                int qoutient = x / 2;
                reminder += (x % 2).ToString();
                x = qoutient;
            }
            Console.WriteLine("Boolean Conversion (reversed): " + reminder);
            int len = reminder.Length;
            string rem = "";
            for (int i = (len - 1); i >= 0; i--)
            {
                rem += reminder[i];
            }
            Console.WriteLine("Boolean Conversion (actual): {0}", rem);
            int temp = 0;
            int count = 0;
            for (int i = 0; i < len; i++)
            {
                if (reminder[i] == '1')
                {
                    count++;
                }
                else if (reminder[i] == '0')
                {
                    count = 0;
                }
                if (temp < count)
                {
                    temp = count;
                }
            }
            Console.WriteLine("Number of Consective 1's are : {0}", temp);
            Console.ReadKey();
        }
        public static void Parsing()
        {
            Console.Write("\nEnter the String (String/Integer):");
            try
            {
                int dummy = int.Parse(Console.ReadLine());
                Console.WriteLine(dummy);
            }
            catch (Exception)
            {
                Console.WriteLine("Bad String");
            }
        }
        public static void Calculator(int a, int b)
        {
            try
            {
                if (a >= 0 && b >= 0)
                {
                    int i = 1;
                    int s = a;
                    do
                    {
                        s *= a;
                        i++;
                    } while (i < b);
                    Console.WriteLine("Output is : {0}", s);
                    Console.ReadKey();
                }
                else
                {
                    throw new Exception("Enter a non negative number.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public static void Sorting()
        {
            Console.Write("Enter the length of Array to be sorted :");
            int n = Convert.ToInt32(Console.ReadLine());
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(a_temp, Int32.Parse);
            int temp = 0;
            int loopCount = 0;
            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                        loopCount++;
                    }
                }
            }
            Console.WriteLine("Array is sorted in {0} swaps.", loopCount);
            Console.WriteLine("First Element: " + arr[0]);
            Console.WriteLine("Last Element: " + arr[n - 1]);
            Console.WriteLine("Sorted Array :");
            for (int i = 0; i < arr.Length; i++) Console.Write(+arr[i] + " ");
            Console.ReadKey();
        }
        public static void Prime()
        {
            Console.Write("Enter no. of test cases :");
            long n = Convert.ToInt64(Console.ReadLine());
            long[] a = (new long[n]); ;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter the case no.{0} :", i + 1);
                a[i] = Convert.ToInt64(Console.ReadLine());
            }
            for (int j = 0; j < n; j++)
            {
                bool flag = false;
                if (a[j] < 2)
                {
                    Console.WriteLine("Not prime");
                }
                else if (a[j] == 3 || a[j] == 2)
                {
                    Console.WriteLine("Prime");
                }
                else
                {
                    for (int i = 2; i < Math.Sqrt(a[j]); i++)
                    {
                        if (a[j] % i == 0)
                        {
                            flag = true;
                        }
                    }
                    Console.WriteLine(flag == true ? "Not prime" : "Prime");
                }
            }
            Console.ReadKey();
        }
        public static void NestedLogic()
        {
            int bill = 0;
            Console.WriteLine("Welcome to Library System");
            Console.Write("Enter the actual date (saparated by space): ");
            string[] actual = Console.ReadLine().Split(' ');
            Console.Write("Enter the expected date (saparated by space): ");
            string[] expected = Console.ReadLine().Split(' ');
            if (actual == expected)
            {
                bill = 0;
            }
            else if (Convert.ToInt32(actual[2]) < Convert.ToInt32(expected[2]))
            {
                bill = 0;
            }
            else if (Convert.ToInt32(actual[2]) > Convert.ToInt32(expected[2]))
            {
                bill = 10000;
            }
            else if (Convert.ToInt32(actual[1]) > Convert.ToInt32(expected[1]))
            {
                bill = (Convert.ToInt32(actual[1]) - Convert.ToInt32(expected[1])) * 500;
            }
            else if (Convert.ToInt32(actual[0]) > Convert.ToInt32(expected[0]))
            {
                bill = (Convert.ToInt32(actual[0]) - Convert.ToInt32(expected[0])) * 15;
            }
            Console.WriteLine("Final bill of library is :" + bill);
        }
        public static void StringPatterns()
        {
            Console.Write("Enter the no. of test cases :");
            int N = Convert.ToInt32(Console.ReadLine());
            string[] tokens_firstName = new string[N];
            string[] final = new string[N];
            for (int a0 = 0; a0 < N; a0++)
            {
                Console.Write("Enter the {0} test cases :", a0 + 1);
                Console.WriteLine("Enter the first name and than email Id saparated by space.");
                tokens_firstName[a0] = Console.ReadLine();
            }
            for (int i = 0; i < N; i++)
            {
                if (tokens_firstName[i].ToString().Contains("@gmail.com"))
                {
                    final[i] = tokens_firstName[i].Substring(0, tokens_firstName[i].IndexOf(' '));
                }
            }
            Array.Sort(final);
            for (int i = 0; i < N; i++)
            {
                if (final[i] != null)
                    Console.WriteLine("First name of {0} id is : {1}", i + 1, final[i]);
            }
        }
        public static void Dictionary()
        {
            string name = string.Empty;
            Console.Write("Enter the number of inputs :");
            int n = Convert.ToInt32(Console.ReadLine());
            Dictionary<string, string> dict = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter Number and Name (saparated by space):");
                string[] dummy = Console.ReadLine().Split(' ');
                dict.Add(dummy[0], dummy[1]);
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter name to search :");
                name = Console.ReadLine();
                Console.WriteLine(dict.ContainsKey(name) ? name + "=" + dict[name] : "Not Found");
            }
        }
    }
    public class Scope
    {
        public static int maximumDifference;
        public static int n = 0;
        public static int computeDifference(int[] elements)
        {
            Array.Sort(elements);
            n = elements.Length;
            maximumDifference = elements[n - 1] - elements[0];
            return maximumDifference;
        }
        public static void Diff()
        {
            Console.WriteLine("Enter length of integer array: ");
            Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a array of Interger (saparated by space): ");
            int[] a = Console.ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
            int final = 0;
            final = computeDifference(a);
            Console.Write("Result is :" + final);
        }
    }
}






