using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.BL;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.DL;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.User_Controls;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.Universal_Forms;

namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.UserForms
{
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }
        MessageBoxForm mf = new MessageBoxForm();
        HomeCtrl home = new HomeCtrl();
        ApplyJobCtrl apjob = new ApplyJobCtrl();
        ViewMyJob vmjob = new ViewMyJob();
        ViewMeCtrl viewme = new ViewMeCtrl();
        ViewJobsCtrl vjc = new ViewJobsCtrl();
        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString("HH:mm");
            DateLabel.Text = DateTime.Now.ToString("MMMM ddd yyyy");
        }
        bool sidebarExpand = false;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                SidebarPanel.Width -= 10;
                if (SidebarPanel.Width <= 65)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();
                    Homepn.Width = SidebarPanel.Width;
                    Applypn.Width = SidebarPanel.Width;
                    Jobspn.Width = SidebarPanel.Width;
                    Editpn.Width = SidebarPanel.Width;
                    Viewpn.Width = SidebarPanel.Width;
                    Logoutpn.Width = SidebarPanel.Width;
                }
            }
            else
            {
                SidebarPanel.Width += 10;
                if (SidebarPanel.Width >= 227)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();
                    Homepn.Width = SidebarPanel.Width;
                    Applypn.Width = SidebarPanel.Width;
                    Jobspn.Width = SidebarPanel.Width;
                    Editpn.Width = SidebarPanel.Width;
                    Viewpn.Width = SidebarPanel.Width;
                    Logoutpn.Width = SidebarPanel.Width;
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WelcomeForm wf = new WelcomeForm();
            this.Hide();
            wf.Show();
        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            FileHandler.loadJobData();
            FileHandler.loadEmpData();
            MainPanel.Controls.Add(home);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Add(home);
            MainPanel.Controls.Remove(viewme);
            MainPanel.Controls.Remove(vmjob);
            MainPanel.Controls.Remove(apjob);
            MainPanel.Controls.Remove(vjc);

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Remove(home);
            MainPanel.Controls.Add(apjob);
            MainPanel.Controls.Remove(viewme);
            MainPanel.Controls.Remove(vmjob);
            MainPanel.Controls.Remove(vjc);

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //View All Jobs code
            MainPanel.Controls.Remove(home);
            MainPanel.Controls.Remove(viewme);
            MainPanel.Controls.Remove(vmjob);
            MainPanel.Controls.Remove(apjob);
            MainPanel.Controls.Add(vjc);

        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Remove(vjc);
            MainPanel.Controls.Remove(home);
            MainPanel.Controls.Remove(apjob);
            MainPanel.Controls.Remove(viewme);
            MainPanel.Controls.Add(vmjob);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Remove(vjc);
            MainPanel.Controls.Remove(home);
            MainPanel.Controls.Remove(apjob);
            MainPanel.Controls.Add(viewme);
            MainPanel.Controls.Remove(vmjob);
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            mf.ShowMessage("Logging Out...");
            mf.Show();

            WelcomeForm wf = new WelcomeForm();
            this.Hide();
            wf.Show();
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            WelcomeForm wf = new WelcomeForm();
            this.Hide();
            wf.Show();
        }
    }
}
