using System;


namespace _2002.Test_Task
{
    public class RegisterRequstStrategy : IRequestStrategy
    {
        public string ProcessRequest(Request request)
        {
            if (Context.Users.ContainsKey(request.UserName)) return Context.RegisterResultMessages["Fail"];

            Context.Users.Add(request.UserName, request.Password);
            return Context.RegisterResultMessages["Ok"];
        }
    }
}
