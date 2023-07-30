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
    public partial class RemoveEmployeeCtrl : UserControl
    {
        MessageBoxForm mf = new MessageBoxForm();
        public RemoveEmployeeCtrl()
        {
            InitializeComponent();
        }

        private void Removebtn_Click(object sender, EventArgs e)
        {
            string name = nametxt.Text;

            Employee RemoveEmp = EmployeeDL.SearchnReturnEmployee(name);

            if (RemoveEmp != null)
            {
                namelbl.Text = RemoveEmp.CurrentUser.Name;
                contactlbl.Text = RemoveEmp.Contact;
                citylbl.Text = RemoveEmp.City;
                jobnamelbl.Text = RemoveEmp.Job.Job_name;

                EmployeeDL.RemoveEmployee(RemoveEmp);
                FileHandler.WriteEmpDatatoFile();

                mf.StartPosition = FormStartPosition.CenterScreen;
                mf.ShowMessage("Removed Employee.");
                mf.Show();

                ClearLbl();
            }
            else
            {
                mf.StartPosition = FormStartPosition.CenterScreen;
                mf.ShowMessage("Invalid Employee.");
                mf.Show();

                ClearLbl();
            }
        }
        public void ClearLbl()
        {
            namelbl.Text = "";
            contactlbl.Text = "";
            citylbl.Text = "";
            jobnamelbl.Text = "";
        }

        private void RemoveEmployeeCtrl_Load(object sender, EventArgs e)
        {

        }
    }
}
