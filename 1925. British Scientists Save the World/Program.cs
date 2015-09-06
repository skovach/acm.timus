using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1925.British_Scientists_Save_the_World
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] get = Console.ReadLine().Split(' ');
            int n = int.Parse(get[0]);
            int k = int.Parse(get[1]);
            List<int> years = new List<int>();
            List<int> inNumbers = new List<int>();

            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ');
                years.Add(int.Parse(line[0]));
                inNumbers.Add(int.Parse(line[1]));
            }


            int x = 0;

            x = (years.Sum() + k - (n + 1)*2) - inNumbers.Sum();

            Console.WriteLine(x > 0? x.ToString() : "Big Bang!");
        }
    }
}
