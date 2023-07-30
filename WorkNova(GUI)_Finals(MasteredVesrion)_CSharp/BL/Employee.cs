using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.BL
{
    class Employee
    {

        public Employee(Person user, float age, string contact, string city, string cnic, Job job, float empexperience)
        {
            CurrentUser=user;
            this.Age = age;
            this.Contact = contact;
            this.City = city;
            this.Cnic = cnic;
            this.Job = job;
            this.Empexperience = empexperience;
        }

        public string Contact { get => contact; set => contact = value; }
        public float Age { get => age; set => age = value; }
        public string Cnic { get => cnic; set => cnic = value; }
        public string City { get => city; set => city = value; }
        public float Empexperience { get => empexperience; set => empexperience = value; }
        public Job Job { get => job; set => job = value; }
        public Person CurrentUser { get => currentUser; set => currentUser = value; }

        private string contact;
        private float age;
        private string cnic;
        private Job job;
        private string city;
        private float empexperience;
        private Person currentUser;
    }
}
