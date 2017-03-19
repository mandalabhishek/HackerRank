using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.StartDays
{
    public class ClassInstance
    {
        public static void Instance()
        {
            int initialAge = 0;
            Console.Write("Enter the no. of values for testing age :");
            int T = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < T; i++)
            {
                Console.Write("Enter the age :");
                int age = int.Parse(Console.In.ReadLine());
                if (age >= 0)
                {
                    initialAge = age;
                }
                else
                {
                    Console.WriteLine("Age is not valid, setting age to 0.");
                    age = 0;
                    initialAge = age;
                }
                amIOld(initialAge);
                for (int j = 0; j < 3; j++)
                {
                    yearPasses(initialAge);
                }
                amIOld(initialAge);
                Console.WriteLine();
            }
        }
        public static string amIOld(int age)
        {
            if (age < 13)
                Console.WriteLine("You are young.");
            else if (age >= 13 && age < 18)
                Console.WriteLine("You are a teenager.");
            else
                Console.WriteLine("You are old.");
            return null;
        }

        public static int yearPasses(int age)
        {
            return age += 1;
        }
    }    
}
