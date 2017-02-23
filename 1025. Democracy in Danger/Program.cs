using System;
using System.Collections.Generic;
using System.Linq;

namespace _1025.Democracy_in_Danger
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = int.Parse(Console.ReadLine());
            List<string> votersLine = Console.ReadLine().Split(' ').ToList();
            int result = 0;

            // solution 1 ok
            var voters = new List<int>();
            votersLine.ForEach(x => { voters.Add(int.Parse(x)); });
            voters.Sort();
            for (int i = 0; i < (k / 2) + 1; i++)
            {
                result += (voters[i] / 2) + 1;
            }

            // not working with set of equal items. example: 5 5 5 
            //votersLine.Sort();
            //int groupAmount = (k / 2) + 1;
            //votersLine.RemoveRange(groupAmount, votersLine.Count - groupAmount);

            //var prev = votersLine[0];

            //List<int> voters = new List<int>();
            //votersLine.ForEach(v => voters.Add(int.Parse(v)));

            //result = (votersLine.Sum(x => int.Parse(x)) / 2) + 1;

            Console.WriteLine(result);
        }
    }
}