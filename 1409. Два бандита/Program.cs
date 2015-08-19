using System;

namespace _1409.Два_бандита
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' },
    StringSplitOptions.RemoveEmptyEntries);
            int harryShot = int.Parse(input[0]);
            int LarryShot = int.Parse(input[1]);

            Console.WriteLine(string.Format("{0} {1}", LarryShot-1, harryShot-1));
        }
    }
}
