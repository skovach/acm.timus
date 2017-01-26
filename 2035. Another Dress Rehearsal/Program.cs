using System;

namespace _2035.Another_Dress_Rehearsal
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            UInt64 x = UInt64.Parse(input[0]);
            UInt64 y = UInt64.Parse(input[1]);
            UInt64 c = UInt64.Parse(input[2]);

            if (ImpossibleConditions(x, y, c))
            {
                Console.WriteLine("Impossible");
                return;
            }
            UInt64 a, b;
            
            if (x >= c)
            {
                Console.WriteLine("{0} {1}", c, 0);
                return;
            }
            if (y >= c)
            {
                Console.WriteLine("{0} {1}", 0, c);
                return;
            }

            bool reverseResult = x > y;
            if (reverseResult)
            {
                var temp = y;
                y = x;
                x = temp;
            }

            while (x/2 + y >= c)
            {
                if (x/2 + y == c)
                {
                    a = x/2;
                    b = y;
                    if (reverseResult)
                    {
                        var temp = b;
                        b = a;
                        a = temp;
                    }
                    Console.WriteLine("{0} {1}", a, c - a);
                }

                x /= 2;
            }

            for (a = x; a < x*2; a++)
            {
                b = c - a;
                if (b >= 0 && b <= y)
                {
                    if (reverseResult)
                    {
                        var temp = b;
                        b = a;
                        a = temp;
                    }
                    Console.WriteLine("{0} {1}", a, b);
                    return;
                }
            }

            
        }

    

        private static bool ImpossibleConditions(ulong x, ulong y, ulong c)
        {
            return x + y < c;
        }
    }
}
