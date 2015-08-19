using System;

namespace _1876.Centipede_s_Morning
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ');

            int aLeft = int.Parse(input[0]);
            int bRight = int.Parse(input[1]);

            int time = 0;

            time = bRight*2;
            if (aLeft >= 40) aLeft = 40;
            time += aLeft;

            Console.WriteLine(time);
        }
    }
}

