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

namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.Admin_Controls.AEmployeeControls
{
    public partial class ViewEmployeesCtrl : UserControl
    {
        public ViewEmployeesCtrl()
        {
            InitializeComponent();
        }
        private void LoadDatatoListView()
        {
            foreach (Employee TempEmp in EmployeeDL.Employees)
            {
                ListViewItem item = new ListViewItem(TempEmp.CurrentUser.Name);
                item.SubItems.Add(TempEmp.Job.Job_name);
                item.SubItems.Add(TempEmp.Job.Pay.ToString());
                item.SubItems.Add(TempEmp.Contact);
                item.SubItems.Add(TempEmp.City);
                item.SubItems.Add(TempEmp.Empexperience.ToString());
                EmpListView.Items.Add(item);
            }
        }
        private void ViewEmployeesCtrl_Load(object sender, EventArgs e)
        {
            EmpListView.Columns.Add("Name", 150);
            EmpListView.Columns.Add("Job Name", 160);
            EmpListView.Columns.Add("Pay: ", 150);
            EmpListView.Columns.Add("Contact: ", 150);
            EmpListView.Columns.Add("City: ", 150);
            EmpListView.Columns.Add("Experience: ", 150);
            LoadDatatoListView();
        }
    }
}
