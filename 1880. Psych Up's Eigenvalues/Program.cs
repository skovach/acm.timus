using System;
using System.Collections.Generic;
using System.Linq;

namespace _1880.Psych_Up_s_Eigenvalues
{
    class Program
    {
        private static int GetResult(string p1, string p2, string p3)
        {
            List<string> items = new List<string>();
            string concat = p1 + ' ' + p2 + ' ' + p3;
            string[] numbers = concat.Split(' ');
            foreach (var item in numbers)
            {
                items.Add(item);                            
            }
            var Combine = items.GroupBy(x => x)
                             .Where(g => g.Count() > 1)
                             .Select(g => g.Key)
                             .ToList();
            foreach (var item in p3.Split(' '))
            {
                Combine.Add(item);
            }
            var output = Combine.GroupBy(x => x)
                 .Where(g => g.Count() > 1)
                 .Select(g => g.Key)
                 .ToList().Count;
            return output;
        }

        static void Main(string[] args)
        {
            // input
            string[] input = Console.In.ReadToEnd().Split(
                 new char[] { '\t', '\n', '\r' },
                 StringSplitOptions.RemoveEmptyEntries);


            Console.WriteLine(GetResult(input[1], input[3], input[5]));

        //    HashSet<string> first = PopulateHashSet(input[1]);
        //    HashSet<string> second = PopulateHashSet(input[3]);
        //    HashSet<string> third = PopulateHashSet(input[5]);

        //    int output = 0;

        //    foreach(string item in first)
        //    {
        //        if(second.Contains(item))
        //        {
        //            if (third.Contains(item))
        //            {
        //                output++;
        //            }
        //        }
        //    }
           
        //    Console.WriteLine(output);
        //}

        //private static HashSet<string> PopulateHashSet(string p)
        //{
        //    HashSet<string> set = new HashSet<string>();
        //    foreach (var item in p.Split(' '))
        //    {
        //        set.Add(item);
        //    }
        //    return set;

        //}
        }

                                                                
    }
}
