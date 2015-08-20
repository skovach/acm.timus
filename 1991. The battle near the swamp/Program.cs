using System;

namespace _1991.The_battle_near_the_swamp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int n = int.Parse(input[0]);
            int k = int.Parse(input[1]);

            string[] boomBooms = Console.ReadLine().Split(' ');

            int droidsSurvived = 0;
            int boomBoomsLeft = 0;

            for (int i = 0; i < n; i++)
            {
                int bombs = int.Parse(boomBooms[i]);
                if (bombs > k)
                {
                    boomBoomsLeft += bombs - k;
                }
                else if (k > bombs)
                {
                    droidsSurvived += k - bombs;
                }
            }

            Console.WriteLine("{0} {1}", boomBoomsLeft, droidsSurvived);

        }
    }
}
