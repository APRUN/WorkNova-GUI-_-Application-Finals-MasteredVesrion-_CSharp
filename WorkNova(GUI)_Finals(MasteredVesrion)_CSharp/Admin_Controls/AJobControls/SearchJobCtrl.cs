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

namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.Admin_Controls.AJobControls
{
    public partial class SearchJobCtrl : UserControl
    {
        public SearchJobCtrl()
        {
            InitializeComponent();
        }

        private void SearchJobCtrl_Load(object sender, EventArgs e)
        {
            FileHandler.loadJobData();
        }

        private void Removebtn_Click(object sender, EventArgs e)
        {
            string jobname=jobnametxt.Text;
            Job TempJob=JobDL.SearchJob(jobname);
            if(TempJob!=null)
            {
                jobnamelbl.Text = TempJob.Job_name;
                compnamelbl.Text = TempJob.Companyname;
                explbl.Text = TempJob.Experiencefor.ToString();
                paylbl.Text = TempJob.Pay.ToString();
                citylbl.Text = TempJob.City;
            }
            else
            {
                MessageBoxForm mf = new MessageBoxForm();
                mf.StartPosition = FormStartPosition.CenterScreen;
                mf.ShowMessage("Unavailable Job.");
                mf.Show();
            }
        }
    }
}
