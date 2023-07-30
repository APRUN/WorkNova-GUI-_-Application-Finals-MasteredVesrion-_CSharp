using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.BL
{
    class Job:AJob
    {


        public string Job_name { get => job_name; set => job_name = value; }
        public string Companyname { get => companyname; set => companyname = value; }
        public float Experiencefor { get => experiencefor; set => experiencefor = value; }
        public string City { get => city; set => city = value; }
        public string Category { get => category; set => category = value; }
        public float Pay { get => pay; set => pay = value; }

        public override bool IsRemote()
        {
            return false;
        }

        public Job(string job_name, string companyname, float experiencefor, string city, string category, float pay)
        {
            this.Job_name = job_name;
            this.Companyname = companyname;
            this.Experiencefor = experiencefor;
            this.City = city;
            this.Category = category;
            this.Pay = pay;
        }
        private string job_name;
        private string companyname;
        private float experiencefor;
        private string city;
        private string category;
        private float pay;
    }
}
