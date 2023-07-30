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
    public partial class ViewMyJob : UserControl
    {
        public ViewMyJob()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string jobname = nametxt.Text;

            Job MyJob=JobDL.SearchJob(jobname);
            if(MyJob!=null)
            {
                jobnamelbl.Text = MyJob.Job_name;
                complbl.Text = MyJob.Companyname;
                paylbl.Text = MyJob.Pay.ToString();
                
            }
            else
            {
                MessageBoxForm mf = new MessageBoxForm();
                mf.ShowMessage("Invalid Entries.");
                mf.Show();
            }
        }
    }
}
