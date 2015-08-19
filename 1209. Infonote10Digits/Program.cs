using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1209.Infonote10Digits
{
    class Program
    {
        static void Main(string[] args)
        {
            long number = int.Parse(Console.ReadLine());
            long[] positions = new long[number];
            var result = new long[number];

            for (int i = 0; i < positions.Length; i++)
            {
                positions[i] = int.Parse(Console.ReadLine());
                result[i] = Math.Round(Math.Sqrt(8*positions[i] - 7) + 1) == (Math.Sqrt(8*positions[i] - 7) + 1) ? 1 : 0;
            }

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write("{0} ", result[i]);
            }

            //int positionMax = positions.Max();
            //int nextValue = 1;
            //StringBuilder powers = new StringBuilder(nextValue);

            //while (powers.Length - 1 <= int.MaxValue)
            //{
            //    powers.Append(nextValue);
            //    nextValue *= 10;
            //}

            //for (int i = 0; i < positions.Length; i++)
            //{
            //    Console.Write("{0} ", powers[positions[i] - 1]);
            //}


            //Stopwatch sw = new Stopwatch();
            //sw.Start();
            //Console.WriteLine("Watch:Start");

            //HashSet<int> power = new HashSet<int>() { 1 };
            //int zeroCounter = 1;
            //int nextOne = 2;
            //int positionMax = positions.Max();
            //while (power.Max() < positionMax)
            //{
            //    nextOne += zeroCounter;
            //    power.Add(nextOne + zeroCounter);
            //    zeroCounter++;
            //}
            //Console.WriteLine("Watch: {0}", sw.ElapsedMilliseconds);
            //sw.Stop();


        }
    }
}
