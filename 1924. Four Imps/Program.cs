using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1924.Four_Imps
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

                Console.WriteLine(((number + 1) / 2) % 2 != 0 ? "grimy" : "black");
        }
    }
}
