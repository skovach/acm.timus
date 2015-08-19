using System;

namespace _2001.Mathematicians_and_Berries
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] barries = Console.ReadLine().Split(' ');
            string[] allInFirst = Console.ReadLine().Split(' ');
            string[] allInSecond = Console.ReadLine().Split(' ');

            int firstBarries = int.Parse(barries[0]);
            int secondBarries = int.Parse(barries[1]);

            int firstEntity = int.Parse(allInSecond[0]);
            int secondEntity = int.Parse(allInFirst[1]);

            Console.WriteLine(string.Format("{0} {1}", firstBarries - firstEntity, secondBarries - secondEntity));
        }
    }
}
