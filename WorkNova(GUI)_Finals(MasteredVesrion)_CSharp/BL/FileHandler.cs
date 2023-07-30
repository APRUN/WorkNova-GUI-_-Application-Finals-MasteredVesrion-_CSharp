using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.DL;

namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.BL
{
    class FileHandler
    {
        public static void WriteUsertoFile()
        {
            string path="Users.txt";
            StreamWriter file = new StreamWriter(path);
            foreach(User TempUser in PersonDL.Persons1)
            {
                file.WriteLine(TempUser.Name+","+TempUser.Password+","+TempUser.Email);
            }
            file.Flush();
            file.Close();
        }
        public static void LoadUserFromFile()
        {
            string path = "Users.txt";
            StreamReader file = new StreamReader(path);
            string line;
            while(!(file.EndOfStream))
            {
                line = file.ReadLine();
                string[] word = line.Split(',');
                User GotUser = new User(word[0],word[1],word[2]);
                PersonDL.AddPerson(GotUser);
            }
            file.Close();
        }
        public static void LoadAdminFromFile()
        {
            string path = "Admins.txt";
            StreamReader file = new StreamReader(path);
            string line;
            while (!(file.EndOfStream))
            {
                line = file.ReadLine();
                string[] word = line.Split(',');
                Admin GotAdmin = new Admin(word[0], word[1], word[2]);
                AdminDL.AddAdmin(GotAdmin);
            }
            file.Close();
        }
        public static void WriteAdmintoFile()
        {
            string path = "Admins.txt";
            StreamWriter file = new StreamWriter(path);
            foreach (Admin TempAdmin in AdminDL.AdminList1)
            {
                file.WriteLine(TempAdmin.Name + "," + TempAdmin.Password + "," + TempAdmin.Email);
            }
            file.Flush();
            file.Close();
        }
        public static void WriteJobDatatoFile()
        {
            string path = "JobData.txt";
            StreamWriter file = new StreamWriter(path);
            foreach (Job TempJob in JobDL.Jobs)
            {
                file.WriteLine(TempJob.Job_name + "," + TempJob.Companyname + "," + TempJob.Experiencefor + "," + TempJob.City + "," + TempJob.Category + "," + TempJob.Pay);
            }
            file.Flush();
            file.Close();
        }

        public static void loadJobData()
        {
            string path = "JobData.txt";
            StreamReader file = new StreamReader(path);
            string line;
            while (!(file.EndOfStream))
            {
                line = file.ReadLine();
                string[] word = line.Split(',');
                Job job = new Job(word[0], word[1], float.Parse(word[2]), word[3], word[4], float.Parse(word[5]));
                JobDL.AddJob(job);
            }
            file.Close();
        }
        public static void WriteEmpDatatoFile()
        {
            string path = "Employeedata.txt";
            StreamWriter file = new StreamWriter(path);
            foreach (Employee TempEmp in EmployeeDL.Employees)
            {
                file.WriteLine(TempEmp.CurrentUser.Name+ "," +TempEmp.Age + "," + TempEmp.Contact + "," + TempEmp.City + "," + TempEmp.Cnic + "," + TempEmp.Job.Job_name + "," + TempEmp.Empexperience);
            }
            file.Flush();
            file.Close();
        }

        public static void loadEmpData()
        {
            string path = "EmployeeData.txt";
            StreamReader file = new StreamReader(path);
            string line;
            while (!(file.EndOfStream))
            {
                line = file.ReadLine();
                string[] word = line.Split(',');

                string username = word[0];
                Person user=PersonDL.SearchPersonByName(username);
                float age;
                float.TryParse(word[1], out age);
                Job job = JobDL.SearchJob(word[5]);
                float experience=7.6f;
                float.TryParse(word[6],out experience);

                if(job!=null&&user!=null)
                {
                    Employee employee = new Employee(user, age, word[2], word[3], word[4], job, experience);
                }
                
            }
            file.Close();
        }
    }
}
