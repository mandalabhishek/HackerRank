using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.StartDays
{
    public static class Interface
    {
        public static void InterfaceQuiz()
        {
            Console.Write("\nEnter a dummy number :");
            int n = Int32.Parse(Console.ReadLine());
            AdvancedArithmetic myCalculator = new Calculator();
            int sum = myCalculator.divisorSum(n);
            Console.WriteLine("I implemented: AdvancedArithmetic\n" + sum);
        }
    }
    public interface AdvancedArithmetic
    {
        int divisorSum(int n);
    }
    public class Calculator : AdvancedArithmetic
    {
        int sum = 0;
        public int divisorSum(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    sum = sum + i;
                }
            }
            return sum;
        }
    }
}
