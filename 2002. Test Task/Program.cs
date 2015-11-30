using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2002.Test_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var responseQ = new List<string>();
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ');
                var request = BuildRequest(line);
                string response = Server.PrecessReqest(request);
                responseQ.Add(response);
            }

            responseQ.ForEach(Console.WriteLine);
        }

        private static Command GetRequestCommand(string comandName)
        {
            return Enum.GetValues(typeof(Command))
                    .Cast<Command>().FirstOrDefault(x => x.ToString() == comandName);
        }

        private static Request BuildRequest(string[] line)
        {
            var command = GetRequestCommand(line[0]);
            var request = new Request()
            {
                Command = command,
                UserName = line[1]
            };
            if (command != Command.logout)
            {
                request.Password = line[2];
            }
            return request;
        }
    }
}
