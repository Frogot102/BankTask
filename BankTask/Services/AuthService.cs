using System.Collections.Generic;

namespace BankTask.Services
{
    public static class AuthService
    {
        private static readonly Dictionary<string, string> Users = new Dictionary<string, string>
        {
            { "admin", "adminpass" },
            { "user", "userpass" }
        };

        private static string _currentUser;
        private static string _currentRole;

        public static bool Login(string username, string password)
        {
            if (Users.TryGetValue(username, out string pass) && pass == password)
            {
                _currentUser = username;
                _currentRole = username == "admin" ? "Admin" : "User";
                return true;
            }
            return false;
        }

        public static string CurrentUser => _currentUser;
        public static string CurrentRole => _currentRole;
        public static bool IsAdmin => _currentRole == "Admin";
        public static bool IsLoggedIn => !string.IsNullOrEmpty(_currentUser);
    }
}