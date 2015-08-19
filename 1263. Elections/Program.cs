using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1263.Elections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] they = Console.ReadLine().Split(' ');

            int candidates = int.Parse(they[0]);
            int electors = int.Parse(they[1]);

            int[] votes = new int[electors];
            double[] choices = new double[candidates];
            for (int i = 0; i < electors; i++)
            {
                votes[i] = int.Parse(Console.ReadLine());
            }

            foreach (var choice in votes)
            {
                choices[choice - 1]++;
            }

            for (int i = 0; i < candidates; i++)
            {
                Console.WriteLine("{0:P2}", choices[i] / electors);
            }

        }
    }
}