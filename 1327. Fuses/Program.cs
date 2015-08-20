using System;
namespace _1327.Fuses
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int result = (b - a) / 2;
            result = a%2 != 0 || b%2 != 0 ? result + 1 : result;

            Console.WriteLine(result);
        }
    }
}
