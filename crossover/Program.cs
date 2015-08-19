using System;

namespace crossover
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            double zeroOne = 1;
            double s = 0;
            while(s == 0)
            {
                if (zeroOne % N == 0)
                {
                    s = zeroOne;
                    break;
                }
                zeroOne = NextZeroOne(zeroOne);
            }
            Console.WriteLine(s);

        }

        static double NextZeroOne(double zeroOne)
        {
            string newZeroOne = zeroOne.ToString();
            char[] digits = newZeroOne.ToCharArray();
            for (int i = 0; i < digits.Length; i++)
            {
                if(digits[i] != '1')
                {
                    digits[i] = '1';
                    break;
                }
                if(i + 1 == digits.Length)
                {
                    for (int y = 1; y < digits.Length; y++)
                    {
                        digits[y] = '0';
                    }
                    newZeroOne = string.Join("",digits);
                    newZeroOne += '0';
                    return Convert.ToDouble(newZeroOne);
                }
            }
            newZeroOne = string.Join("", digits);
            return Convert.ToDouble(newZeroOne);
        }
    }
}
