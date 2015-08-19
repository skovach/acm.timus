using System;

namespace DragonsLocalization
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            if(number <= 0 && number > 2001)
            {
                return;
            }
            int[] numbers = { 0, 4, 9, 19, 49, 99, 249, 499, 999,2000 };
            string[] howMany = { "few", "several", "pack", "lots", "horde", "throng", "swarm", "zounds", "legion" };
            for (int i = 1; i < numbers.Length; i++)
            {
                if (number <= numbers[i] && number > 0)
                {
                    Console.WriteLine(howMany[i-1]);
                    break;
                }
            }

        }
    }
}
