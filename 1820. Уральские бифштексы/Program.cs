using System;

namespace _1820.Уральские_бифштексы
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t' },
                StringSplitOptions.RemoveEmptyEntries);
            int nSteaks = int.Parse(input[0]);
            int kInPans = int.Parse(input[1]);
            int sides = 2 * nSteaks;

            if (kInPans >= nSteaks)
            {
                Console.WriteLine(2);
                return;
            }
            else if (kInPans < nSteaks)
            {
                int minutes = sides / kInPans;
                if (sides % kInPans > 0)
                {
                    minutes++;
                }
                Console.WriteLine(minutes);
            }
        }
    }
}
