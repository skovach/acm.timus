using System;
using System.Collections.Generic;
using System.Linq;

namespace _1617.Flat_Spots
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Int32.Parse(Console.ReadLine());

            var pairs = new Dictionary<int, int>();
            for (int i = 0; i < n; i++)
            {
                int p = int.Parse(Console.ReadLine());
                if (pairs.ContainsKey(p))
                {
                    pairs[p]++;
                }
                else
                {
                    pairs.Add(p, 1);
                }
            }
            int result = pairs.Where(v => v.Value > 3).Aggregate(0, (current, p) => current + p.Value/4);
            Console.Write(result);
        }
    }
}
