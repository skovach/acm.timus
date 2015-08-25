using System;

namespace _1349.Farm
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n != 1 && n != 2)
            {
                Console.WriteLine("-1");
                return;
            }

            string answer1 = "1 2 3";
            string answer2 = "3 4 5";

            Console.WriteLine(n == 1 ? answer1 : answer2);

        }
    }
}
