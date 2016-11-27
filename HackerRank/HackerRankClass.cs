using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank
{
    class Person
    {
    }
}

class Person
{
    public static int age;
    public Person(int age)
    {
        if (age < 0)
        { 
            Console.WriteLine("Age is not valid, setting age to 0.");
            age = 0;
        }
        if (age <= 13)
        {
            Console.WriteLine("You are young.");
        }
        else if (age >= 13 && age <= 18)
        {
            Console.WriteLine("You are teenager.");
        }
        else if (age > 18)
        {
            Console.WriteLine("You are old.");
        }
        int iage = age + 3;
        if (iage < 13)
        {
            Console.WriteLine("You are young.");
        }
        else if (iage >= 13 && iage <= 18)
        {
            Console.WriteLine("You are teenager.");
        }
        else if (iage > 18)
        {
            Console.WriteLine("You are old.");
        }

    }
    public void amIOld()
    {
        //if (age <= 13)
        //{
        //    Console.WriteLine("You are young.");
        //}
        //else if (age >= 13 && age <=18)
        //{
        //    Console.WriteLine("You are teenager.");
        //}
        //else if (age > 18)
        //{
        //    Console.WriteLine("You are old.");
        //}
        //int iage = age + 3;
        //if (iage <= 13)
        //{
        //    Console.WriteLine("You are young.");
        //}
        //else if (iage >= 13 && iage <= 18)
        //{
        //    Console.WriteLine("You are teenager.");
        //}
        //else if (iage > 18)
        //{
        //    Console.WriteLine("You are old.");
        //}

    }

    public void yearPasses()
    {
        // Increment the age of the person in here
        //int iage = age + 3;
        //if (iage <= 13)
        //{
        //    Console.WriteLine("You are young.");
        //}
        //else if (iage >= 13 && iage <= 18)
        //{
        //    Console.WriteLine("You are teenager.");
        //}
        //else if (iage > 18)
        //{
        //    Console.WriteLine("You are old.");
        //}

    }

    static void Main(String[] args)
    {
        Console.WriteLine("Enter number of test cases :");
        int T = int.Parse(Console.In.ReadLine());
        for (int i = 0; i < T; i++)
        {
            Console.WriteLine("Enter Age :");
            age = int.Parse(Console.In.ReadLine());
            Person p = new Person(age);
            p.amIOld();
            for (int j = 0; j < 3; j++)
            {
                p.yearPasses();
            }
            p.amIOld();
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
