using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1225.Flags
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n == 1 || n == 2)
            {
                Console.WriteLine(2);
                return;
            }
            else if (n == 0)
            {
                Console.WriteLine(n);
            }
            long result = CreateFibonachiSequence(n - 1).Sum() + CreateFibonachiSequence(n - 2).Sum();
            Console.WriteLine(result * 2);


        }

        static IEnumerable<int> CreateFibonachiSequence(int length)
        {
            var fibonachi = new List<int>();
            int f1 = 0, f2 = 1, f3 = 0;
            for (int i = 0; i < length + 1; i++)
            {
                f3 = f1;

                fibonachi.Add(f1);

                f1 = f2;
                f2 = f1 + f3;
            }
            foreach (var item in fibonachi.OrderBy(f => f))
            {
                Console.WriteLine(item);
            }
            return fibonachi;
        }
    }
}
