using System;
using System.Collections.Generic;
using System.Linq;

namespace _1100.Final_Standings
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var teams = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                teams.Add(int.Parse(line[0]), int.Parse(line[1]));
            }

            foreach (var team in teams.OrderByDescending(v => v.Value))
            {
                Console.WriteLine("{0} {1}", team.Key, team.Value);
            }


        }
    }
}