using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Log_Reg_Form
{
    public class User
    {
        private sbyte _age;
        public string Name { get; set; } = default;
        public string Surname { get; set; } = default;
        public sbyte Age
        {
            get
            {
                return this._age;
            }
            set
            {
                if (value > 0 && value < 100)
                {
                    _age = value;
                }
            }
        }
        public string Email { get; set; } = default;
        public string Password { get; set; } = default;
        public string ProfilePicturePath { get; set; } = default;
        public UserRole UserRole { get; set; }

        public bool IsEmailConfirmed { get; set; } = false;
        public User(string name, string surname, sbyte age, string email, string passw)
        {
            Name = name;
            Surname = surname;
            Age = age;
            Email = email;
            Password = passw;
        }

        public User(string name, string surname, sbyte age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }

        public User(string email, string password)
        {
            Email = email;
            Password = password;
        }
        public User()
        {
            _age = default;
        }
    }
}
