using System;
using System.Collections.Generic;
using System.Linq;

namespace _1893.A380
{
    class Program
    {
        private static void Main(string[] args)
        {
            string seating = Console.ReadLine();

            int row = int.Parse(seating.Substring(0, seating.Length - 1));
            string place = seating.Substring(seating.Length - 1, 1).ToUpper();

            string flightClass = GetSeatingClass(row);

            var premiumWindows = new List<string>() { "a", "d" };

            var businessWindow = new List<string>() { "a", "f" };


            var economWindow = new List<string>() { "a", "k" };
            var economAisle = new List<string>() { "c", "d", "g", "h" };

            if (flightClass == "p")
            {
                bool isWindow = premiumWindows.Contains(place, StringComparer.OrdinalIgnoreCase);
                if (isWindow)
                {
                    DisplayWindow();
                    return;
                }
                DisplayAisle();
            }
            else if (flightClass == "b")
            {
                bool isWindow = businessWindow.Contains(place, StringComparer.OrdinalIgnoreCase);
                if (isWindow)
                {
                    DisplayWindow();
                    return;
                }
                DisplayAisle();
            }
            else if (flightClass == "e")
            {
                bool isWindow = economWindow.Contains(place, StringComparer.InvariantCultureIgnoreCase);
                if (isWindow)
                {
                    DisplayWindow();
                    return;
                }

                bool isAisle = economAisle.Contains(place, StringComparer.InvariantCultureIgnoreCase);
                if (isAisle)
                {
                    DisplayAisle();
                    return;
                }

                DisplayNeither();
            }
        }
        static string GetSeatingClass(int rowNumber)
        {
            string c = string.Empty;
            if (rowNumber == 1 || rowNumber == 2) c = "p";
            else if (rowNumber >= 3 && rowNumber <= 20) c = "b";
            else if (rowNumber >= 21 && rowNumber <= 65) c = "e";
            return c;
        }

        static void DisplayWindow()
        {
            Console.WriteLine("window");
        }
        static void DisplayAisle()
        {
            Console.WriteLine("aisle");
        }
        static void DisplayNeither()
        {
            Console.WriteLine("neither");
        }
    }
}
