using System;
using System.Text;

namespace _1123.Salary
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StringBuilder Salary = new StringBuilder(Console.ReadLine());
            bool isPalindrome = false;

            while (!isPalindrome)
            {
                int middleDigitIndex = 0;
                string middleDigit = String.Empty;

                if (Salary.Length%2 != 0)
                {
                    middleDigitIndex = Salary.Length/2 + 1;
                    middleDigit = Salary[middleDigitIndex].ToString();
                    Salary = Salary.Remove(middleDigitIndex, 1);
                }

                int median = Salary.Length/2;

                StringBuilder mirrorSalary = ReverseString(Salary.ToString(median, Salary.Length - median));
                StringBuilder currentSalary = Salary.Remove(median, Salary.Length - median);

                if (Convert.ToInt64(currentSalary.ToString()) != Convert.ToInt64(mirrorSalary.ToString()))
                {
                    
                    Salary = new StringBuilder(currentSalary + middleDigit + ReverseString(mirrorSalary.ToString()));
                    var s = Convert.ToInt64((Salary.ToString())) + 1;
                    Salary = new StringBuilder(s.ToString());
                }
                else
                {
                    isPalindrome = true;
                    Salary = new StringBuilder(currentSalary + middleDigit + ReverseString(mirrorSalary.ToString()));
                }

            }
            Console.WriteLine(Salary);
        }

        private static StringBuilder ReverseString(string line)
        {
            var chars = line.ToCharArray();
            Array.Reverse(chars);
            return new StringBuilder(new string(chars));
        }
    }
}

/* Palindrom, but not Minimal */
#region Just some palindrome
//    int middleDigitIndex = 0;
//    string middleDigit = String.Empty;

//    if (Salary.Length % 2 != 0)
//    {
//        middleDigitIndex = Salary.Length / 2 + 1;
//        middleDigit = Salary[middleDigitIndex].ToString();
//        Salary = Salary.Remove(middleDigitIndex, 1);
//    }

//    int median = Salary.Length / 2;

//    StringBuilder mirrorSalary = new StringBuilder(ReverseString(Salary.Substring(median, Salary.Length - median)));
//    StringBuilder currentSalary = new StringBuilder(Salary.Remove(median, Salary.Length - median));

//    for (int i = 0; i < median; i++)
//    {
//        while (currentSalary[i] != mirrorSalary[i])
//        {
//            mirrorSalary[i] = IncrementDigit(mirrorSalary[i]);
//            if (int.Parse(mirrorSalary[i].ToString()) == 0)
//            {
//                currentSalary[i] = IncrementDigit(currentSalary[i]);
//            }

//        }
//    }

//    string palindrome = currentSalary + middleDigit + ReverseString(mirrorSalary.ToString());
//    Console.WriteLine(palindrome);
//}

//private static string ReverseString(string line)
//{
//    var chars = line.ToCharArray();
//    Array.Reverse(chars);
//    return new string(chars);
//}

//private static char IncrementDigit(char digit)
//{
//    int d = int.Parse(digit.ToString());
//    d++;
//    string result = d.ToString();
//    return result[result.Length - 1];
//}
#endregion

