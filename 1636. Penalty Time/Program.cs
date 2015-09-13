using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1636.Penalty_Time
{
    class Program
    {
        static void Main(string[] args)
        {
            var Ts = Console.ReadLine().Split(' ');
            var penalties = Console.ReadLine().Split(' ');

            int pTime = penalties.Sum(x => int.Parse(x));
            pTime *= 20;    

            string result = int.Parse(Ts[1]) - pTime >= int.Parse(Ts[0]) ? "No chance." : "Dirty debug :(";
            Console.WriteLine(result);
        }
    }
}
