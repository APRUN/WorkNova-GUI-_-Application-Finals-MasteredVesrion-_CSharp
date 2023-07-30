using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.BL
{
    class Internship:Job,IisPaid
    {
        public Internship(string job_name, string companyname, float experiencefor, string city, string category, float pay):base(job_name, companyname, experiencefor, city, category, pay)
        {

        }

        bool IisPaid.IsPaid { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public bool IsPaid()
        {
            return true;
        }
    }
}
