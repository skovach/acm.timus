using System;
using System.Collections.Generic;

namespace _1197.Lonesome_Knight
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            var positions = new List<string>();
            for (int i = 0; i < number; i++)
            {
                positions.Add(Console.ReadLine());
            }

            string letters = "abcdefgh";

            foreach (var position in positions)
            {
                int underAttack = 0;
                int x = letters.IndexOf(position[0]) + 1;
                int y = int.Parse(position[1].ToString());

                if (x - 2 >= 1)
                {
                    if (y + 1 <= 8)
                    {
                        underAttack++;
                    }
                    if (y - 1 >= 1)
                    {
                        underAttack++;
                    }
                }
                if (x + 2 <= 8)
                {
                    if (y + 1 <= 8)
                    {
                        underAttack++;
                    }
                    if (y - 1 >= 1)
                    {
                        underAttack++;
                    }
                }
                if (y - 2 >= 1)
                {
                    if (x + 1 <= 8)
                    {
                        underAttack++;
                    }
                    if (x - 1 >= 1)
                    {
                        underAttack++;
                    }
                }
                if (y + 2 <= 8)
                {
                    if (x + 1 <= 8)
                    {
                        underAttack++;
                    }
                    if (x - 1 >= 1)
                    {
                        underAttack++;
                    }
                }
                Console.WriteLine(underAttack);
            }
            
        }
    }
}
