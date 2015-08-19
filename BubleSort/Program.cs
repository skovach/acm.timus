using System;
using System.Linq;

namespace BubleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int min = 0;
            int max = 10;
            int[] values = Enumerable.Repeat(0, 350).Select(i => rand.Next(min, max)).ToArray();

            BubleSortArray(values);

            foreach (var value in values)
            {
                Console.WriteLine(value);
            }
        }

        private static void BubleSortArray(int[] array)
        {
            for (int q = 0; q < array.Length; q++)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i - 1] > array[i])
                    {
                        int x = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = x; 
                    }
                }
            }
        }
    }
}
