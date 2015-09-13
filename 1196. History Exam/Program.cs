using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1196.History_Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var professorsList = new HashSet<string>();
            for (int i = 0; i < n; i++)
            {
                professorsList.Add(Console.ReadLine());
            }
            int m = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 0; i < m; i++)
            {
                //studentslist.Add(int.Parse(Console.ReadLine()));
                result = professorsList.Contains(Console.ReadLine()) ? result += 1 : result;
            }

            //int result = professorsList.Distinct().Join(studentslist, p => p, s => s, (p, s) => new List<int>()).Count();
            Console.WriteLine(result);
        }
    }
}
