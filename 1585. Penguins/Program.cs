using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1585.Penguins
{
    class Program
    {
        static void Main(string[] args)
        {
            var species = new Dictionary<string, int>()
            {
                {"Emperor Penguin", 0},
                {"Little Penguin", 1},
                {"Macaroni Penguin", 2},
            };
            var result = new int[3];
            int n = int.Parse(Console.ReadLine());
            var notebook = new List<string>();
            for (int i = 0; i < n; i++)
            {
                notebook.Add(Console.ReadLine());
            }

            foreach (var peng in notebook)
            {
                int index = species.SingleOrDefault(p => p.Key == peng).Value;
                result[index]++;
            }

            var maxNotes = Array.FindIndex(result, r => r == result.Max());
            var output = species.SingleOrDefault(s => s.Value == maxNotes).Key;
            Console.WriteLine(output);


        }
    }
}
