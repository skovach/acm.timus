using System.Collections.Generic;

namespace _2002.Test_Task
{
    public static class Context
    {
        static Context()
        {
            InitResultDictionaries();
            InitUsers();
        }

        private static void InitUsers()
        {
            Users = new Dictionary<string, string>();
            LogedInUsers = new Dictionary<string, string>();
        }

        public static Dictionary<string, string> Users { get; set; }
        public static Dictionary<string, string> LogedInUsers { get; set; }

        public static Dictionary<string, string> RegisterResultMessages { get; set; }
        public static Dictionary<string, string> LogInResultMessages { get; set; }
        public static Dictionary<string, string> LogOutResultMessages { get; set; }

        private static void InitResultDictionaries()
        {
            RegisterResultMessages = new Dictionary<string, string>
            {
                {"Ok", "success: new user added"},
                {"Fail", "fail: user already exists"}
            };

            LogInResultMessages = new Dictionary<string, string>
            {
                {"Ok", "user logged in"},
                {"NoUser", "fail: no such user"},
                {"InvalidPassword",  "fail: incorrect password"},
                {"AlreadyLogedIn",  "fail: already logged in"}

            };

            LogOutResultMessages = new Dictionary<string, string>
            {
                {"NoUser", "fail: no such user"},
                {"AlreadyLogedOut", "fail: already logged out"},
                {"Ok", "success: user logged out"}
            };
        }
    }
}
