using System;
using System.Collections.Generic;

namespace DifferentNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            List<string> Combinations = new List<string>();

            var combination = new int[number];
            // init
            for (int i = 0; i < number; i++)
            {
                combination[i] = 1;
            }

            for (int i = 0; i < combination.Length/2; i++)
            {
                for (int j = 0; j < number; j++)
                {     
                    if(combination[i] != number)
                    {
                        Combinations.Add(string.Join("", combination));
                        combination[i]++;
                    }
                    else
                    {
                        break;
                    }

                }
            }


            // init
            for (int i = 0; i < number; i++)
            {
                combination[i] = 1;
            }
            for (int i = (combination.Length - 1)/2; i >= 0; i--)
            {
                for (int j = 0; j < number; j++)
                {
                    Combinations.Add(string.Join("", combination));
                    if (combination[i] != number)
                    {
                        combination[i]++;
                    }
                    else
                    {
                        break;
                    }
                }
            }

            // output
            foreach (var item in Combinations)
            {
                Console.WriteLine(item);

            }

        }
    }
}
