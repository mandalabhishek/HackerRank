using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackerRank.StartDays
{
    class Inheritance
    {
        internal static void Start()
        {
            Console.WriteLine("Enter the details : (First name, Last name, Id)");
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            Console.WriteLine("Enter the number of score :");
            int numScores = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the {0} score :",numScores);
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
            Console.ReadKey();
        }
    }

    public class Person
    {
        public string firstName;
        public string lastName;
        public int id;
        public Person(){}
        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }
    public class Student : Person
    {
        private int[] testScores;
        public Student(string firstName, string lastName, int id, int[] scores)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = id;
            testScores = scores;
        }
        public string Calculate()
        {
            int average = 0;
            string dummy = String.Empty;
            for (int i = 0; i < testScores.Length; i++)
            {
                average += testScores[i];
            }
            int ave = average/testScores.Length;
            string output = string.Empty;
            if (ave < 40)
            {
                dummy = "T";
            }
            else if (40<= (ave) && (ave) < 55)
            {
                dummy = "D";
            }
            else if (55 <= (ave) && (ave) < 70)
            {
                dummy = "P";
            }
            else if (70 <= (ave) && (ave) < 80)
            {
                dummy = "A";
            }
            else if (80 <= (ave) && (ave) < 90)
            {
                dummy = "E";
            }
            else if (90 <= (ave) && (ave) <= 100)
            {
                dummy = "O";
            }
            return dummy;
        }
    }
}
