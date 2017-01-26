using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefVSValie
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int min = 0;
            int max = 100;
            var list = Enumerable.Repeat(0, 10).Select(i => rand.Next(min, max)).ToList();
            MethodParams(list);

            Console.WriteLine();
        }

        public static void MethodParams(List<int> list)
        {
            list[0] = 42;

            list = new List<int>();
            

        }
    }
}
