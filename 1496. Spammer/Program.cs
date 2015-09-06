using System;
using System.Collections.Generic;

namespace _1496.Spammer
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            HashSet<string> teams = new HashSet<string>();
            HashSet<string> spammers = new HashSet<string>();

            for (int i = 0; i < n; i++)
            {
                string team = Console.ReadLine();

                if (teams.Contains(team))
                {
                    spammers.Add(team);
                }
                else
                {
                    teams.Add(team);
                }
            }

            foreach (var spammer in spammers)
            {
                Console.WriteLine(spammer);
            }
        }
    }
}
