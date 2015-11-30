namespace _2002.Test_Task
{
    public class LogInRequestStrategy : IRequestStrategy
    {
        public string ProcessRequest(Request request)
        {
            if (!Context.Users.ContainsKey(request.UserName))
            {
                return Context.LogInResultMessages["NoUser"];
            }
            if (Context.Users[request.UserName] != request.Password)
            {
                return Context.LogInResultMessages["InvalidPassword"];
            }
            if (Context.LogedInUsers.ContainsKey(request.UserName))
            {
                return Context.LogInResultMessages["AlreadyLogedIn"];
            }

            Context.LogedInUsers.Add(request.UserName, request.Password);
            return Context.LogInResultMessages["Ok"];
        }
    }
}
