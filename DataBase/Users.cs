using System;
using System.Collections.Generic;

namespace Log_Reg_Form
{
    public static class Users
    {
        private readonly static List<User> _users;

        static Users()
        {
            _users = new List<User>();
            AddDefaultUsers(_users);
        }
        private static void AddDefaultUsers(List<User> users)
        {
            users.AddRange(new List<User>
            {
                new User{Name = "Emil", Surname = "Belaev", Age = 14, Email = "emil@gmail.com", Password = "1234"},
                new User{Name = "Zeynal", Surname = "Zeynalov", Age = 14, Email = "zeynal@gmail.com", Password = "1234"},
                new User{Email = "admin@", Password = "admin", UserRole = UserRole.Admin}
            });
        }

        public static void AddUser(User user)
        {
            if (user != null)
            {
                if (!ContainsUser(user))
                {
                    _users.Add(user);
                }
            }
        }

        public static bool HasUser(User user)
        {
            bool userExists = false;
            if (user != null)
            {
                foreach (User u in _users)
                {
                    if (u.Email == user.Email)
                    {
                        userExists = true;
                        break;
                    }
                }
            }
            return userExists;
        }
        
        public static bool HasUser(string email, string password)
        {
            bool userExists = false;

                foreach (User _user in _users)
                {
                    if (email == _user.Email && password == _user.Password)
                    {
                        userExists = true;
                        break;
                    }
                }
                 return userExists;
        }
        
        public static User GetUser(string email, string password)
        {
            User user = null;
            if (HasUser(email, password))
            {
                foreach (User _user in _users)
                {
                    if (email == _user.Email && password == _user.Password)
                    {
                        user = _user;
                        break;
                    }
                }
            }
            return user;
        }

        public static List<User> GetUsers()
        {
            return _users;
        }

        private static bool ContainsUser (User user)
        {
            bool userExists = _users.Contains(user) ? true : false;
            return userExists;
        }
    }
}
