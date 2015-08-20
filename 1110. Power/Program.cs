using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _1110.Power
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] read = Console.ReadLine().Split(' ');

            int N = int.Parse(read[0]);
            BigInteger M = new BigInteger(int.Parse(read[1]));
            BigInteger Y = new BigInteger(int.Parse(read[2]));

            var x = new List<BigInteger>();

            for (int i = 0; i < M; i++)
            {
                BigInteger X = new BigInteger(i);
                if (BigInteger.Pow(X, N) % M == Y)
                {
                    x.Add(X);
                }
            }

            if (!x.Any())
            {
                Console.WriteLine("-1");
                return;
            }

            foreach (var item in x.OrderBy(o => o).ToList())
            {
                Console.Write(item + " ");
            }


        }
    }
}
