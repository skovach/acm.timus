using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1068.Sum
{
    class Program
    {
        private static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            if (n > 0)
            {
                for (int i = 1; i <= n; i++)
                {
                    sum += i;
                }
            }
            else if (n < 0)
            {
                for (int i = 1; i >= n; i--)
                {
                    sum += i;
                }
            }
            else
            {
                sum = 1;
            }
            Console.WriteLine(sum);
        }
    }
}
