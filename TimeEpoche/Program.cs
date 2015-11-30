using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TimeEpoche
{
    class Program
    {
        static void Main(string[] args)
        {
            //var epochStart = new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified);
            //var epocheSeconds = (epochStart - DateTime.UtcNow).TotalSeconds;
            //var now = DateTime.Now.AddDays(1);
            //var seconds = (now - epochStart).TotalSeconds;

            //Console.WriteLine((long)seconds);
            //Console.WriteLine(DateTimeFromEpoch((long)seconds));

            //Console.WriteLine("Total seconds from Epoche start: {0}", epocheSeconds);

            var seconds = (long)1446715845397;
            TimeSpan time = TimeSpan.FromSeconds(seconds);

            //here backslash is must to tell that colon is
            //not the part of format, it just a character that we want in output
            string str = time.ToString(@"hh\:mm\:ss\:fff");
            Console.WriteLine(str);
        }

        public static DateTime DateTimeFromEpoch(long seconds)
        {
            return new DateTime(1970, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified).AddSeconds(seconds);
        }
    }
}
