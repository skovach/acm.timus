using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1545.Hieroglyphs
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var hieroglyphs = new List<string>();

            for (int i = 0; i < n; i++)
            {
                hieroglyphs.Add(Console.ReadLine());
            }
            string vovaEntered = Console.ReadLine();

            foreach (var h in hieroglyphs.Where(h => h.StartsWith(vovaEntered)))
            {
                Console.WriteLine(h);
            }
        }
    }
}
