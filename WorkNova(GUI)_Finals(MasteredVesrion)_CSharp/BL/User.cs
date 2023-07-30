using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.BL
{
    class User:Person
    {
        public User(string name,string password,string email):base(name,password,email)
        {

        }
        public User(string name, string password) : base(name, password)
        {

        }
    }
}
