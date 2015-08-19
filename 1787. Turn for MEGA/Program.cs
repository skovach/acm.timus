using System;

namespace _1787.Turn_for_MEGA
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            string[] input1 = Console.ReadLine().Split(
               new char[] { ' ', '\t', '\n', '\r' },
               StringSplitOptions.RemoveEmptyEntries);

            string[] input2 = Console.ReadLine().Split(
   new char[] { ' ', '\t', '\n', '\r' },
   StringSplitOptions.RemoveEmptyEntries);

            int kCarsPerMin = int.Parse(input1[0]);
            int nMinutesPast = int.Parse(input1[1]);

            int carsInJam = 0;
            for (int i = 0; i < input2.Length; i++)
            {
                carsInJam += int.Parse(input2[i]) - kCarsPerMin;
                if (carsInJam < 0)
                {
                    carsInJam = 0;
                }
            }
            Console.WriteLine(carsInJam);
        }
    }
}
