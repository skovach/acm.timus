using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2023.Donald_is_a_postman
{
    class Program
    {
        private static Dictionary<string, int> characters = new Dictionary<string, int>()
        {
            {"Alice", 1},
            {"Phil", 1},
            {"Phoebus", 1},

            {"Ariel", 1},
            {"Peter", 1},
            {"Ralph", 1},

            {"Aurora", 1},
            {"Olaf", 1},
            {"Robin", 1},

            {"Bambi", 2},
            {"Mulan", 2},
            {"Silver", 2},

            {"Belle", 2},
            {"Mowgli", 2},
            {"Simba", 2},

            {"Bolt", 2},
            {"Mickey", 2},
            {"Stitch", 2},

            {"Dumbo", 3},
            {"Kuzko", 3},
            {"Tarzan", 3},

            {"Genie", 3},
            {"Kida", 3},
            {"Tiana", 3},

            {"Jiminy", 3},
            {"Kenai", 3},
            {"Winnie", 3},
        };

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var receivers = new List<string>();
            for (int i = 0; i < n; i++)
            {
                receivers.Add(Console.ReadLine());
            }
            int start = GetPosition(receivers[0]);
            int stop = 0;
            int steps = start - 1;
            for (int i = 1; i < n; i++)
            {
                start = GetPosition(receivers[i - 1]);
                stop = GetPosition(receivers[i]);
                steps += Math.Abs(start - stop);
            }

            Console.WriteLine(steps);
        }

        static int GetPosition(string key)
        {
            int value = characters.SingleOrDefault(k => k.Key == key).Value;
            return value;
        }
    }
}
