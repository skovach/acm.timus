using System;

namespace _1264.Workdays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' },
    StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(int.Parse(input[0]) * (int.Parse(input[1]) + 1));
        }
    }
}
