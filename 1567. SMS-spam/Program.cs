using System;
using System.Linq;


namespace _1567.SMS_spam
{
    class Program
    {
        public static string[] charList = new string[]
            {
                "abc",
                "def",
                "ghi",
                "jkl",
                "mno",
                "pqr",
                "stu",
                "vwx",
                "yz",
                ".,!",
                "_"
            };

        static void Main(string[] args)
        {
            string slogan = Console.ReadLine();
            slogan = slogan.Replace(' ', '_');
            var price = slogan.Sum(symbol => GetPriceOfSymbol(symbol));
            Console.WriteLine(price);
        }

        private static int GetPriceOfSymbol(char symbol)
        {
            string button = charList.Select(s => s).FirstOrDefault(s => s.Contains(symbol));
            return button.IndexOf(symbol) + 1;
        }
    }
}