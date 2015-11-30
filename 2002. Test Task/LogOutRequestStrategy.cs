namespace _2002.Test_Task
{
    public class LogOutRequestStrategy : IRequestStrategy
    {
        public string ProcessRequest(Request request)
        {
            if (!Context.Users.ContainsKey(request.UserName))
            {
                return Context.LogOutResultMessages["NoUser"];
            }
            if (!Context.LogedInUsers.ContainsKey(request.UserName))
            {
                return Context.LogOutResultMessages["AlreadyLogedOut"];
            }

            Context.LogedInUsers.Remove(request.UserName);
            return Context.LogOutResultMessages["Ok"];
        }
    }
}
