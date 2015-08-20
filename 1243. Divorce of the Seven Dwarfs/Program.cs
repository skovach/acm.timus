using System;
using System.Data.SqlTypes;
using System.Numerics;

namespace _1243.Divorce_of_the_Seven_Dwarfs
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = BigInteger.Parse(Console.ReadLine());
            var s = new BigInteger(7);
            var result = BigInteger.Remainder(n, s);
            Console.WriteLine(result);
        }
    }
}
