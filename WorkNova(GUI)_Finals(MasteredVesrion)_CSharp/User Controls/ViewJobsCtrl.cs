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
    public partial class ViewJobsCtrl : UserControl
    {
        public ViewJobsCtrl()
        {
            InitializeComponent();
        }

        private void ViewJobsCtrl_Load(object sender, EventArgs e)
        {
            JobListView.Columns.Add("Job Name", 160);
            JobListView.Columns.Add("Company Name: ", 150);
            JobListView.Columns.Add("Pay: ", 150);
            JobListView.Columns.Add("City: ", 150);
            JobListView.Columns.Add("Experience: ", 150);
            JobListView.Columns.Add("Category: ", 150);
            LoadDatatoListView();
        }
        private void LoadDatatoListView()
        {
            foreach (Job TempJob in JobDL.Jobs)
            {
                ListViewItem item = new ListViewItem(TempJob.Job_name);
                item.SubItems.Add(TempJob.Companyname);
                item.SubItems.Add(TempJob.Pay.ToString());
                item.SubItems.Add(TempJob.City);
                item.SubItems.Add(TempJob.Experiencefor.ToString());
                item.SubItems.Add(TempJob.Category);
                JobListView.Items.Add(item);
            }
        }
    }
}
