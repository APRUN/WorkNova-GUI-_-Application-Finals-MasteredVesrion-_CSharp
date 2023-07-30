using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.BL;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.DL;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.Universal_Forms;

namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.User_Controls
{
    public partial class ApplyJobCtrl : UserControl
    {
        MessageBoxForm mf = new MessageBoxForm();

        public ApplyJobCtrl()
        {
            InitializeComponent();
        }

        private void ApplyJobCtrl_Load(object sender, EventArgs e)
        {
            
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            bool valid = false;
            bool valid1 = false;
            bool valid2 = false;
            bool valid3 = false;

            float age;
            float experience;

            string name = nametxt.Text;
            string contact = contacttxt.Text;
            string city = Citytxt.Text;
            string cnic = cnictxt.Text;
            string jobname = jobnametxt.Text;

            Job userjob = JobDL.SearchJob(jobname);
            Person Currentuser = PersonDL.SearchPersonByName(name);

            if (Currentuser != null)
            {
                valid3 = true;
            }
            if (float.TryParse(agetxt.Text, out age))
            {
                valid = true;
            }
            if (float.TryParse(Exptxt.Text, out experience))
            {
                valid1 = true;
            }
            if (userjob != null)
            {
                valid2 = true;
            }
            if (valid1 && valid2 && valid3 && nametxt != null && jobnametxt != null && cnictxt != null && contacttxt != null)
            {
                Employee NewEmp = new Employee(Currentuser, age, contact, city, cnic, userjob, experience);
                EmployeeDL.AddEmployee(NewEmp);
                FileHandler.WriteEmpDatatoFile();
                mf.ShowMessage("Applied.");
                mf.Show();
            }
            else
            {
                MessageBox.Show(Currentuser.Name+jobname + valid2.ToString() + valid3.ToString());
                mf.ShowMessage("Invalid Entries.");
                mf.Show();
            }
        }
    }
}
