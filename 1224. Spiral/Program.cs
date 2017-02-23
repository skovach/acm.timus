using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1224.Spiral
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> field = Console.ReadLine().Split(' ').ToList();
            int m = int.Parse(field[0]);
            int n = int.Parse(field[1]);

            int turns = 0;

            int minSide = m > n ? n : m;
            int isOdd = minSide%2 == 0 ? 0 : 1;

            int spirals = ((minSide-isOdd) / 2) * 4;

            Console.WriteLine(spirals);
        }
    }
}
