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
            uint n = uint.Parse(field[0]);
            uint m = uint.Parse(field[1]);

            //int turns = 0;

            //if (n == 0 || m == 0)
            //{
            //    Console.WriteLine(0);
            //    return;
            //}

            //if (n == 1 || m == 1)
            //{
            //    Console.WriteLine(1);
            //    return;
            //}

            //if (n == 2 || m == 2)
            //{
            //    Console.WriteLine(3);
            //    return;
            //}

            //int minSide = m > n ? n : m;
            //int isOdd = n > m ? 1 : 0;

            //int spirals = (((minSide) / 2) + 1)* 4;

            Console.WriteLine(m >= n ? 2 * (n - 1) : 2 * (m - 1) + 1);
        }
    }
}
