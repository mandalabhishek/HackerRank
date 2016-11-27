using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    public class Program
    {
        //Console.WriteLine("Enter the Value of Age :");
        static int initialAge = int.Parse(Console.ReadLine());
        public Program(int initialAge)
        {
           
            if (initialAge < 0)
            {
                initialAge = 0;
                Console.WriteLine("Age is not valid, setting age to 0.");
            }
        }

        private static void Main1(string[] args)
        {
            //ConditionalQuiz();
            //ArrayQuiz();
            //Array();
            //ArrayCombiQuiz();
            //SortingArray();
            //ArrayCombiQuiz();
            ClassQuiz();
        }

        public static void ConditionalQuiz()
        {
            Console.WriteLine("Enter Varible N:");
            int n = Convert.ToInt32(Console.ReadLine());
            Array();
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
        private static void Array()
        {
            Console.WriteLine("Enter the lenght of Array :");
            //int n = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i++)
            {
                int[] ArrayTemp = new int[n];
                Console.WriteLine("Enter the Array :");  
                ArrayTemp[i]=int.Parse(Console.ReadLine());
            }
            int[] myArray = {1, 2, 3};
            foreach (int a in myArray)
            {
                Console.WriteLine(a);
            }
        }

        static void ArrayQuiz()
        {

            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = System.Array.ConvertAll(arr_temp,Int32.Parse);

            for (int i = (n - 1); i >= 0; i--)
            {
                Console.WriteLine("you entered {0}", arr[i]);
            }
            Console.ReadLine();
        }

        static public void SortingArray()
        {
            Console.WriteLine("Enter the number of string you want to enter :");
            int n = int.Parse(Console.ReadLine());
            string[] TempArray = new string[n];
            for (int i = 0; i <= (n-1); i++)
            {
                Console.WriteLine("Enter your {0} String :",i);
                TempArray[i] = Convert.ToString(Console.ReadLine());
            }
            for (int i = (n-1); i >= 0; i--)
            {
                Console.WriteLine("Your Entered strings are : {0}",TempArray[i]);
                int m = TempArray[i].Length;
                Console.WriteLine("Length of array is :{0}",m);
                foreach (var a in TempArray[i])
                {
                    Console.Write("{0} ",a);
                }
            }
            Console.ReadKey();
        }

        static public void ArrayCombiQuiz()
        {
            Console.WriteLine("Enter a string :");
            string arr_temp = Console.ReadLine();

            for (int i = 0; i <= (arr_temp.Length - 1); i++)
            {
                if (i%2 == 0)
                {
                    Console.WriteLine("even {0}", arr_temp[i]);
                }
                else
                {
                    Console.WriteLine("odd {0}", arr_temp[i]);
                }

            }
            Console.ReadKey();
        }

        static void ClassQuiz()
        {
            
            Program Oldie = new Program(initialAge);
            Oldie.amIOld(initialAge);
            Program.yearPasses(initialAge);
            Console.ReadKey();
        }
        public void amIOld(int initialAge)
        {
            if (initialAge <= 13)
            {
                Console.WriteLine("You are young.");
            }
            int sum = initialAge + 3;
            if (sum <= 13)
            {
                Console.WriteLine("You are young.");
            }
            else if(sum >13 && sum <18)
            {
                Console.WriteLine("You are teenager.");
            }
        }
        public static void yearPasses(int initialAge)
        {

            if (initialAge > 18)
            {
                Console.WriteLine("You are old.");
            }
            int sum = initialAge + 3;
            if (sum >= 13 && sum <= 18)
            {
                Console.WriteLine("You are teenager.");
            }
            else if(sum > 18)
            {
                Console.WriteLine("You are old.");
            }
        }
    }
}


