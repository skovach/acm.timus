using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManyToManyTry
{
    class Program
    {
        static void Main(string[] args)
        {
            SchoolContext context = new SchoolContext();

            var s = context.Courses.Select(x => x.Students); 
        }
    }
}
