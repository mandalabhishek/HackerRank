using System;

namespace HackerRank.Algorithm
{
    internal class AlgorithmSwitch
    {
        public void AlgorithmList()
        {
            Begin:
            Console.WriteLine("\nEnter Your Choice For :" +
                              "\n\t\t\t1.Warm Up" +
                              "\n\t\t\t2.Implementation" +
                              "\n\t\t\t3.Strings");
            Console.Write("\nYour Choice : ");
            int input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                {
                    Console.WriteLine("\n\t\t\t\t\t     #Region-Main-Algorithm-Warm Up");
                    AlgorithmWarmUpSwitch.AlgorithmWarmUpList();
                       break;
                }
                case 2:
                {
                    Console.WriteLine("\n\t\t\t\t\t  #Region-Main-Algorithm-Implementation");
                    AlgorithmImplementationSwitch.AlgorithmImplementationList();
                       break;
                }
                case 3:
                    {
                        Console.WriteLine("\n\t\t\t\t\t     #Region-Main-Algorithm-Strings");
                        AlgorithmStringsSwitch.StringsList();
                        break;
                    }
                default:
                {
                    Console.WriteLine("\nEnter a valid choice given in list.");
                    goto Begin;
                }
            }
        }
    }
}
