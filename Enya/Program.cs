using System;

namespace Enya
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' },
                StringSplitOptions.RemoveEmptyEntries);
            Console.WriteLine(2 * int.Parse(input[0]) * int.Parse(input[1]) * int.Parse(input[2]));

        }
    }
}
