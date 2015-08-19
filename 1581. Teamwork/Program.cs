using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1581.Teamwork
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<String> vasiaNumbers = Console.ReadLine().Split(' ').ToList();
            List<string> petiaNumbers = new List<string>();

            int start = 0;
            while (start < n)
            {
                int q = 1;
                while (start + 1 < n && vasiaNumbers[start] == vasiaNumbers[start + 1])
                {
                    q++;
                    start++;
                }
                petiaNumbers.Add(q + " ");
                petiaNumbers.Add(vasiaNumbers[start] + " ");

                start++;
            }
            DisplayCollection(petiaNumbers);
        }

        static void DisplayCollection(IList<string> collection)
        {
            for (int i = 0; i < collection.Count; i++)
            {
                Console.Write(collection[i]);
            }
        }
    }
}


//9
//1 1 2 3 3 3 10 10 11
