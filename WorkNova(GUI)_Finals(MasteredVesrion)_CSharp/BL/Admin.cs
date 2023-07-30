using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.BL
{
    class Admin
    {
        public Admin(string name, string password, string email)
        {
            this.Name = name;
            this.Password = password;
            this.Email = email;
        }

        public string Name { get => name; set => name = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }


        private string name;
        private string password;
        private string email;
    }
}
