using System;
using System.Collections.Generic;
using System.Linq;

namespace _1837.Isenbaev_s_Number
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var teams = new List<string[]>();
            var isenbaievNumbers = new Dictionary<string, string>();
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ');
                teams.Add(line);
                if (line.Contains("Isenbaev"))
                {
                    isenbaievNumbers["Isenbaev"] = "0";
                    var primes = line.Where(x => x != "Isenbaev");
                    foreach (var prime in primes)
                    {
                        isenbaievNumbers[prime] = "1";
                    }
                }
            }

            foreach (var team in teams)
            {
                List<int> numbers = new List<int>();
                // take team
                foreach (var member in team)
                {
                    // is friend
                    if (isenbaievNumbers.ContainsKey(member))
                    {
                        if (isenbaievNumbers[member] != "undefined")
                        numbers.Add(int.Parse(isenbaievNumbers[member]));
                    }
                    else numbers.Add(-1);
                }
                int min = 0;
                // min number in team
                if (numbers.Max() >= 0)
                {
                    min = numbers.Where(x => x >= 0).Min();
                }
                else
                {
                    numbers.Clear();
                    min = 0;
                    foreach (var undefinedMember in team)
                    {
                        if (!isenbaievNumbers.ContainsKey(undefinedMember))
                        isenbaievNumbers.Add(undefinedMember, "undefined");
                    }
                    continue;
                }
                min++;
                foreach (var m in team)
                {
                    if (!isenbaievNumbers.ContainsKey(m))
                    {
                        isenbaievNumbers.Add(m, min.ToString());
                    }
                    else
                    {
                        if (isenbaievNumbers[m] == "undefined") continue;
                        if (int.Parse(isenbaievNumbers[m]) > min)
                        {
                            isenbaievNumbers[m] = min.ToString();
                        }
                    }
                }
            }

            foreach (var team in teams)
            {
                List<int> numbers = (from member in team where isenbaievNumbers[member] != "undefined" select int.Parse(isenbaievNumbers[member])).ToList();
                // take team
                if (numbers == null || !numbers.Any()) continue;
                int min = numbers.Min();
                foreach (var m in team)
                {
                    isenbaievNumbers[m] = min.ToString();
                }
            }

            var ordered = isenbaievNumbers.OrderBy(x => x.Key);
            foreach (var isenNumb in ordered)
            {
                Console.WriteLine("{0} {1}", isenNumb.Key, isenNumb.Value);
            }
        }
    }
}
