using System;

namespace _1639.Chocolate_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int pieces = int.Parse(input[0])*int.Parse(input[1]);

            Console.WriteLine(pieces%2 != 0 ? "[second]=:]" : "[:=[first]");
        }
    }
}
