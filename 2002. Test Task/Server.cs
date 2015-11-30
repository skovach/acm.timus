using System.Collections.Generic;

namespace _2002.Test_Task
{
    public static class Server
    {
        private static Dictionary<Command, IRequestStrategy> strategies =
            new Dictionary<Command, IRequestStrategy>();

        static Server()
        {
            strategies.Add(Command.register, new RegisterRequstStrategy());
            strategies.Add(Command.login, new LogInRequestStrategy());
            strategies.Add(Command.logout, new LogOutRequestStrategy());
        }

        public static string PrecessReqest(Request request)
        {
            return strategies[request.Command].ProcessRequest(request);
        }
    }
}

