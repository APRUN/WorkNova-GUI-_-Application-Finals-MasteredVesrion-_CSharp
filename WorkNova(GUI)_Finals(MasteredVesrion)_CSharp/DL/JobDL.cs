using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.BL;

namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.DL
{
    class JobDL
    {
        private static List<Job> jobs = new List<Job>();

        internal static List<Job> Jobs { get => jobs; set => jobs = value; }
        public static void AddJob(Job job)
        {
            jobs.Add(job);
        }
        public static void RemoveJob(Job job)
        {
            jobs.Remove(job);
        }
        public static Job SearchJob(string name)
        {
            foreach(Job TempJob in jobs)
            {
                if(TempJob.Job_name==name)
                {
                    return TempJob;
                }
            }
            return null;
        }
        public static bool JobIsAvailable(string name)
        {
            foreach (Job TempJob in jobs)
            {
                if (TempJob.Job_name == name)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
