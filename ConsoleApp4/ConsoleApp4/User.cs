using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace ConsoleApp4
{
    public class User
    {
        private string name;
        private string surname;
        private string username;
        private string password;
        private DateTime registerDate;
        private string token = "";
        public User()
        {

        }
        public User(string username, string name, string surname, string password, DateTime registerDate)
        {
            this.username = username;
            this.name = name;
            this.surname = surname;
            this.password = password;
            this.registerDate = registerDate;

        }
        public User(string token)
        {
            this.token = token;
        }


        public string Name
        {
            get { return name; }
            set => name = !string.IsNullOrEmpty(value) ? value : throw new ArgumentException("field cannot be empty or null");
        }
        public string Surname { get { return surname; } set { surname = value; } }
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; }  set { password = value; } }
        public DateTime RegisterDate { get { return registerDate; } set { registerDate = value; } }
        public string Token { get { return token; } set { token = value; } }


        public override string ToString()
        {
            return base.ToString() + ": " + name.ToString() + " " + surname.ToString() + ", username: " + username.ToString() + " password: " + password.ToString() + ", tokenAUTH: " + token.ToString();
        }
    }
}
