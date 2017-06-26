using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1083.Factorials___
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> input = Console.ReadLine().Split(' ').ToList();

            long n = long.Parse(input[0]);
            long k = input[1].Length;

            //if (k == 0)
            //{
            //    Console.WriteLine(n);
            //    return;
            //}

            //long result = 1;

            //long lastMultiplier = n % k == 0 ? k : (n % k);
            
            //while (n > 1)
            //{
            //    result *= n;
            //    n -= k;
            //}

            Console.WriteLine(f(n,k));


        }

        static long f(long n, long k)
        {
            long a = n - k;
            if (a <= 0) { return 1; }
            return a * f(a, k);
        }
    }
}
