using System;

namespace _1607.Taxi
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] prices = Console.ReadLine().Split(' ');

            int petrPrice = int.Parse(prices[0]);
            int increment = int.Parse(prices[1]);
            int driverPrice = int.Parse(prices[2]);
            int reduction = int.Parse(prices[3]);

            while (petrPrice <= driverPrice)
            {
                petrPrice += increment;

                if (petrPrice > driverPrice)
                {
                    Console.WriteLine(driverPrice);
                    return;
                }

                driverPrice -= reduction;
            }

            Console.WriteLine(petrPrice);
        }
    }
}