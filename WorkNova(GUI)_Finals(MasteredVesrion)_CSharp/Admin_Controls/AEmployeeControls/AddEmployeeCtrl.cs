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

namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.Admin_Controls.AEmployeeControls
{
    public partial class AddEmployeeCtrl : UserControl
    {
        MessageBoxForm mf = new MessageBoxForm();

        public AddEmployeeCtrl()
        {
            InitializeComponent();
        }

        private void guna2TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddEmployeeCtrl_Load(object sender, EventArgs e)
        {

        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            float age;
            float experience;

            string jobname = jobnametxt.Text;
            string name = nametxt.Text;
            string contact = contacttxt.Text;
            string city = citytxt.Text;
            string cnic = cnictxt.Text;

            float.TryParse(exptxt.Text,out experience);
            float.TryParse(agetxt.Text,out age);

            Person EmpUser = PersonDL.SearchPersonByName(name);
            Job job=JobDL.SearchJob(jobname);

            if(job==null)
            {
                mf.StartPosition = FormStartPosition.CenterScreen;
                mf.ShowMessage("Invalid Job.");
                mf.Show();
            }
            else if(EmpUser==null)
            {
                mf.StartPosition = FormStartPosition.CenterScreen;
                mf.ShowMessage("Invalid User.");
                mf.Show();
            }
            else
            {
                Employee NewEmp = new Employee(EmpUser,age,contact,city,cnic,job,experience);

                if(!(EmployeeDL.EmployeeIsAvailable(EmpUser.Name)))
                {
                    EmployeeDL.AddEmployee(NewEmp);
                    FileHandler.WriteEmpDatatoFile();

                    mf.StartPosition = FormStartPosition.CenterScreen;
                    mf.ShowMessage("Employee Added.");
                    mf.Show();

                    ClearTxt();
                }
                else
                {
                    mf.StartPosition = FormStartPosition.CenterScreen;
                    mf.ShowMessage("Already Exsist.");
                    mf.Show();

                    ClearTxt();
                }
            }

        }
        private void ClearTxt()
        {
            nametxt.Text = "";
            contacttxt.Text = "";
            citytxt.Text = "";
            cnictxt.Text = "";
            agetxt.Text = "";
            exptxt.Text = "";
            jobnametxt.Text = "";
        }
    }
}
