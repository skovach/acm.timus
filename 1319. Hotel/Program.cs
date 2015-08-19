using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1319.Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.Parse(Console.ReadLine());
            int area = max * max;

            List<string> sequence = Enumerable.Range(1, max*max).Select(i => i.ToString()).ToList();
            sequence.Reverse();
            List<string> result = new List<string>();

            // calculate matrix
            for (int i = 0; i < max; i++)
            {
                int step = 0;
                int maxStep = max - i;

                List<string> currentLine = new List<string>();
                for (int j = 1; j <= max; j++)
                {
                    if (sequence.Count == max)
                    {
                        currentLine = sequence;
                        break;
                    }

                    currentLine.Add(sequence[step]);                                                           
                    step += j > maxStep ? maxStep : j;
                }

                // remove used digits
                sequence = sequence.Except(currentLine).ToList();
                result.Add(String.Join(" ", currentLine));
            }

            for (int i = result.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(result[i]);
            }
        }
    }
}
