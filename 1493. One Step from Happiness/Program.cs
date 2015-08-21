using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1493.One_Step_from_Happiness
{
    class Program
    {
        static void Main(string[] args)
        {
            string ticket = Console.ReadLine();

            string firstHalf = ticket.Substring(0, 3);
            string secondHalf = ticket.Substring(3, 3);

            int fSum = GetSumOfHalf(firstHalf);
            int sSumInc = GetSumOfHalf((int.Parse(secondHalf) + 1).ToString());
            int sSumDec = GetSumOfHalf((int.Parse(secondHalf) - 1).ToString());

            string response = fSum == sSumInc || fSum == sSumDec ? "Yes" : "No";

            Console.WriteLine(response);
        }

        static int GetSumOfHalf(string halfNumber)
        {
            return halfNumber.Sum(digit => int.Parse(digit.ToString()));
        }
    }
}
