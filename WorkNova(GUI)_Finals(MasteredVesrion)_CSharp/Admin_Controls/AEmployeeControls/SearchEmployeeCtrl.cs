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

    public partial class SearchEmployeeCtrl : UserControl
    {
    MessageBoxForm mf = new MessageBoxForm();
        public SearchEmployeeCtrl()
        {
            InitializeComponent();
        }

        private void SearchEmployeeCtrl_Load(object sender, EventArgs e)
        {
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            string name=nametxt.Text;

            Employee FoundEmp=EmployeeDL.SearchnReturnEmployee(name);

            if(FoundEmp!=null)
            {
                namelbl.Text = FoundEmp.CurrentUser.Name;
                contactlbl.Text = FoundEmp.Contact;
                cniclbl.Text = FoundEmp.Cnic;
                explbl.Text = FoundEmp.Empexperience.ToString();
                jobnamelbl.Text = FoundEmp.Job.Job_name;
                jobcatlbl.Text = FoundEmp.Job.Category;
            }
            else
            {

                mf.StartPosition = FormStartPosition.CenterScreen;
                mf.ShowMessage("Invalid Employee.");
                mf.Show();

            }
        }
    }
}
