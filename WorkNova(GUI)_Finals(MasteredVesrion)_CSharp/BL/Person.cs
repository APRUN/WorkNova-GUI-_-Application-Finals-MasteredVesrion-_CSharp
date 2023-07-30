using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.BL
{
    class Person
    {
        private string name;
        private string password;
        private string email;
        public Person()
        {
        }
        public Person(string Name, string password)
        {
            this.Name = name;
            this.Password = password;
        }
        public Person(string Name)
        {
            this.Name = name;
        }
        public Person(string name, string password, string email)
        {
            this.Name = name;
            this.Password = password;
            this.Email = email;
        }
        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
    }
}
