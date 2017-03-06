using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.Statistics
{
    class Statistics
    {
        public static void WeightedMean()
        {
            Console.Write("Enter the no. of elements :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the {0} values (separated by space) :", n);
            string[] x = Console.ReadLine().Split(' ');
            int[] b = Array.ConvertAll(x, int.Parse);
            Console.Write("Enter the frequency of weights (separated by space) :");
            string[] y = Console.ReadLine().Split(' ');
            int[] c = Array.ConvertAll(y, int.Parse);
            int total = 0;
            double final = 0;
            int sum = 0;
            for (int i = 0; i <n; i++)
            {
                total += (b[i]*c[i]);
            }
            for (int i = 0; i < n; i++)
            {
                sum += c[i];
            }
            final = (total/sum);
            Console.WriteLine("Result is : {0:N1}",final);
        }
        public static void MeanMedianMode()
        {
            double mean = 0;
            double median = 0;
            int x = 0;
            double y = 0;
            double temp = 0;
            double b = 0;
            Console.Write("Enter the no. of values :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the {0} values (separated by space) :", n);
            string[] dummy = Console.ReadLine().Split(' ');
            double[] array = new double[n];
            double[] abc = new double[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(dummy[i]);
                mean = mean + array[i];
            }
            Console.WriteLine("Mean is :{0:F1}", mean / n);

            Array.Sort(array);
            if (n % 2 == 0)
            {
                median = array[(n - 1) / 2] + array[(n / 2)];
                Console.WriteLine("Median is :" + median / 2);
            }
            else
            {
                x = ((n - 1) / 2) + 1;
                median = array[x];
                Console.WriteLine("Median is :" + median);
            }
            for (int i = 0; i < n; i++)
            {
                b = 0;
                for (int j = 0; j < n; j++)
                {
                    if (array[i] == array[j])
                    {
                        b++;
                    }
                }
                if (b > 1 && b > temp)
                {
                    temp = b;
                    y = array[i];
                }
            }
            Console.WriteLine(y >= 0 ? ("Mode is : " + y) : ("Mode is : " + array[0]));
            Console.ReadKey();
        }
        public static void StandardDeviation()
        {
            double y = 0;
            double mean = 0;
            double x = 0;
            double deviation = 0;
            Console.Write("Enter the no. of values :");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the {0} values (separated by space) :",n);
            string[] dummy = Console.ReadLine().Split(' ');
            double[] array = new double[n];
            double[] abc = new double[n];
            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(dummy[i]);
                mean = mean + array[i];
            }
            x = mean / n;
            Console.WriteLine("Mean is :{0:F1}", x);
            for (int i = 0; i < n; i++)
            {
                abc[i] = (array[i] - x) * (array[i] - x);
            }
            for (int i = 0; i < n; i++)
            {
                deviation = deviation + abc[i];
            }
            y = Math.Sqrt(deviation / n);
            Console.WriteLine("Deviation is : {0:F1}", y);
        }
    }
}
