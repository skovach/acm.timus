using System;
using System.Collections.Generic;
using System.Globalization;


namespace _1313.Some_Words_about_Sport
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string[][] pixels = new string[number][];
            for (int k = 0; k < number; k++)
            {
                pixels[k] = Console.ReadLine().Split(' ');
            }

            int i = 0;
            for (int y = 0; y < number*2-1; y++)
            {
                int j = y;
                if (y >= number)
                {
                    i++;
                    j = number - 1;
                }

                for (int x = 0; x < number; x++)
                {
                    if (x+i < number && j < number)
                    {
                        //result += pixels[j][x+i] + ' ';
                        Console.Write(pixels[j][x + i] + ' ');
                        j--;
                        if (j < 0) { break; }
                                                                                        }
                }
            }
            //result.Remove(result.Length - 1);
            //Console.WriteLine(result);
        }
    }
}
