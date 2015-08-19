using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1881.Long_problem_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int pages = 0;
            string[] input = Console.ReadLine().Split(' ');
            int hLines = int.Parse(input[0]);
            int wSymbols = int.Parse(input[1]);
            int nWordsInText = int.Parse(input[2]);
            List<string> words = new List<string>();
            for (int i = 0; i < nWordsInText; i++)
            {
                words.Add(Console.ReadLine());
            }

            //process line
            int currentLineSymbols = 0;
            int space = 1;
            int hInText = 1;
            for (int i = 0; i < words.Count - 1; i++)
            {
                currentLineSymbols += words[i].Length;
                int nextProbableLineLength = currentLineSymbols + space + words[i + 1].Length;
                if (nextProbableLineLength > wSymbols)
                {
                    hInText++;
                    currentLineSymbols = 0;
                }
                else
                {
                    currentLineSymbols += space;
                }

            }
            pages = hInText / hLines;
            if (hInText % hLines != 0) pages++;
            Console.WriteLine(pages);
        }
    }
}
