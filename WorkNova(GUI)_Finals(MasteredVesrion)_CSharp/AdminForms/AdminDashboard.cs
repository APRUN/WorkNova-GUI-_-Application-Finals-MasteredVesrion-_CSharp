using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.DL;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.BL;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.Universal_Forms;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.Admin_Controls.AJobControls;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.Admin_Controls.AUserControls;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.Admin_Controls.AAdminControls;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.Admin_Controls.AEmployeeControls;

namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.AdminForms
{
    public partial class AdminDashboard : Form
    {
        public AdminDashboard()
        {
            InitializeComponent();
        }

        AddJobCtrl ajc = new AddJobCtrl();
        RemoveJobCtrl rmj = new RemoveJobCtrl();
        SearchJobCtrl sjc = new SearchJobCtrl();
        ViewJobCtrl vjc = new ViewJobCtrl();
        AddUserCtrl auc = new AddUserCtrl();
        RemoveUserCtrl ruc = new RemoveUserCtrl();
        SearchUserCtrl suc = new SearchUserCtrl();
        ViewUsersCtrl vus = new ViewUsersCtrl();
        AddAdminCtrl aac = new AddAdminCtrl();
        RemoveAdminCtrl rac = new RemoveAdminCtrl();
        SearchAdminCtrl sac = new SearchAdminCtrl();
        ViewAdminsCtrl vac = new ViewAdminsCtrl();
        AddEmployeeCtrl ade = new AddEmployeeCtrl();
        RemoveEmployeeCtrl rec = new RemoveEmployeeCtrl();
        SearchEmployeeCtrl sec = new SearchEmployeeCtrl();
        ViewEmployeesCtrl vec = new ViewEmployeesCtrl();

        bool menuExpand = false;
        bool menuExpand1 = false;
        bool menuExpand2 = false;
        bool menuExpand3 = false;

        private void menuTransition_Tick(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                menuContainer.Height += 10;
                if (menuContainer.Height >= 226)
                {
                    menuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                menuContainer.Height -= 10;
                if (menuContainer.Height <= 54)
                {
                    menuTransition.Stop();
                    menuExpand = false;
                }
            }
        }

        private void JobOperation_Click(object sender, EventArgs e)
        {
            menuTransition.Start();
        }

        private void UserOperation_Click(object sender, EventArgs e)
        {
            menuTransition1.Start();
        }

        private void guna2Button15_Click(object sender, EventArgs e)
        {
            menuTransition2.Start();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            menuTransition3.Start();
        }

        private void menuTransition1_Tick_1(object sender, EventArgs e)
        {
            if (menuExpand1 == false)
            {
                menuContainer1.Height += 10;
                if (menuContainer1.Height >= 231)
                {
                    menuTransition1.Stop();
                    menuExpand1 = true;
                }
            }
            else
            {
                menuContainer1.Height -= 10;
                if (menuContainer1.Height <= 54)
                {
                    menuTransition1.Stop();
                    menuExpand1 = false;
                }
            }
        }

        private void menuTransition2_Tick_1(object sender, EventArgs e)
        {
            if (menuExpand2 == false)
            {
                menuContainer2.Height += 10;
                if (menuContainer2.Height >= 229)
                {
                    menuTransition2.Stop();
                    menuExpand2 = true;
                }
            }
            else
            {
                menuContainer2.Height -= 10;
                if (menuContainer2.Height <= 54)
                {
                    menuTransition2.Stop();
                    menuExpand2 = false;
                }
            }
        }

        private void menuTransition3_Tick_1(object sender, EventArgs e)
        {
            if (menuExpand3 == false)
            {
                menuContainer3.Height += 10;
                if (menuContainer3.Height >= 224)
                {
                    menuTransition3.Stop();
                    menuExpand3 = true;
                }
            }
            else
            {
                menuContainer3.Height -= 10;
                if (menuContainer3.Height <= 54)
                {
                    menuTransition3.Stop();
                    menuExpand3 = false;
                }
            }
        }
        bool sidebarExpand = false;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {

        }


        private void guna2Button5_Click(object sender, EventArgs e)
        {
            //Add Job Ctrl
            
            MainPanel.Controls.Add(ajc);
            MainPanel.Controls.Remove(rmj);
            MainPanel.Controls.Remove(sjc);
            MainPanel.Controls.Remove(vjc);
            MainPanel.Controls.Remove(auc);
            MainPanel.Controls.Remove(ruc);
            MainPanel.Controls.Remove(suc);
            MainPanel.Controls.Remove(vus);
            MainPanel.Controls.Remove(aac);
            MainPanel.Controls.Remove(rac);
            MainPanel.Controls.Remove(vac);
            MainPanel.Controls.Remove(sac);
            MainPanel.Controls.Remove(ade);
            MainPanel.Controls.Remove(rec);
            MainPanel.Controls.Remove(sec);
            MainPanel.Controls.Remove(vec);
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {
            //RemoveJob
            MainPanel.Controls.Remove(vjc);
            MainPanel.Controls.Remove(sjc);
            MainPanel.Controls.Remove(ajc);
            MainPanel.Controls.Remove(auc);
            MainPanel.Controls.Remove(ruc);
            MainPanel.Controls.Remove(suc);
            MainPanel.Controls.Remove(vac);
            MainPanel.Controls.Remove(vus);
            MainPanel.Controls.Remove(aac);
            MainPanel.Controls.Remove(rac);
            MainPanel.Controls.Remove(sac);
            MainPanel.Controls.Remove(ade);
            MainPanel.Controls.Remove(rec);
            MainPanel.Controls.Remove(sec);
            MainPanel.Controls.Remove(vec);
            MainPanel.Controls.Add(rmj);
        }

        private void guna2Button8_Click(object sender, EventArgs e)
        {
            //Search Job
            MainPanel.Controls.Remove(ajc);
            MainPanel.Controls.Remove(rmj);
            MainPanel.Controls.Remove(sjc);
            MainPanel.Controls.Remove(vjc);
            MainPanel.Controls.Remove(auc);
            MainPanel.Controls.Remove(ruc);
            MainPanel.Controls.Remove(suc);
            MainPanel.Controls.Remove(vac);
            MainPanel.Controls.Remove(vus);
            MainPanel.Controls.Remove(aac);
            MainPanel.Controls.Remove(rac);
            MainPanel.Controls.Remove(sac);
            MainPanel.Controls.Remove(ade);
            MainPanel.Controls.Remove(rec);
            MainPanel.Controls.Remove(sec);
            MainPanel.Controls.Remove(vec);
            MainPanel.Controls.Add(sjc);
        }

        private void guna2Button9_Click(object sender, EventArgs e)
        {
            //View Jobs
            MainPanel.Controls.Remove(ajc);
            MainPanel.Controls.Remove(rmj);
            MainPanel.Controls.Remove(sjc);
            MainPanel.Controls.Remove(vjc);
            MainPanel.Controls.Remove(auc);
            MainPanel.Controls.Remove(ruc);
            MainPanel.Controls.Remove(suc);
            MainPanel.Controls.Remove(vac);
            MainPanel.Controls.Remove(vus);
            MainPanel.Controls.Remove(aac);
            MainPanel.Controls.Remove(rac);
            MainPanel.Controls.Remove(sac);
            MainPanel.Controls.Remove(ade);
            MainPanel.Controls.Remove(rec);
            MainPanel.Controls.Remove(sec);
            MainPanel.Controls.Remove(vec);
            MainPanel.Controls.Add(vjc);
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            //Add User
            MainPanel.Controls.Remove(ajc);
            MainPanel.Controls.Remove(rmj);
            MainPanel.Controls.Remove(sjc);
            MainPanel.Controls.Remove(vjc);
            MainPanel.Controls.Remove(auc);
            MainPanel.Controls.Remove(ruc);
            MainPanel.Controls.Remove(suc);
            MainPanel.Controls.Remove(vac);
            MainPanel.Controls.Remove(vus);
            MainPanel.Controls.Remove(aac);
            MainPanel.Controls.Remove(rac);
            MainPanel.Controls.Remove(sac);
            MainPanel.Controls.Remove(ade);
            MainPanel.Controls.Remove(rec);
            MainPanel.Controls.Remove(sec);
            MainPanel.Controls.Remove(vec);
            MainPanel.Controls.Add(auc);
        }

        private void guna2Button11_Click(object sender, EventArgs e)
        {
            //Remove User
            MainPanel.Controls.Remove(ajc);
            MainPanel.Controls.Remove(rmj);
            MainPanel.Controls.Remove(sjc);
            MainPanel.Controls.Remove(vjc);
            MainPanel.Controls.Remove(auc);
            MainPanel.Controls.Remove(ruc);
            MainPanel.Controls.Remove(suc);
            MainPanel.Controls.Remove(vac);
            MainPanel.Controls.Remove(vus);
            MainPanel.Controls.Remove(aac);
            MainPanel.Controls.Remove(rac);
            MainPanel.Controls.Remove(sac);
            MainPanel.Controls.Remove(ade);
            MainPanel.Controls.Remove(rec);
            MainPanel.Controls.Remove(sec);
            MainPanel.Controls.Remove(vec);
            MainPanel.Controls.Add(ruc);
        }

        private void guna2Button13_Click(object sender, EventArgs e)
        {
            //Search User
            MainPanel.Controls.Remove(ajc);
            MainPanel.Controls.Remove(rmj);
            MainPanel.Controls.Remove(vjc);
            MainPanel.Controls.Remove(sjc);
            MainPanel.Controls.Remove(auc);
            MainPanel.Controls.Remove(ruc);
            MainPanel.Controls.Remove(vac);
            MainPanel.Controls.Remove(vus);
            MainPanel.Controls.Remove(aac);
            MainPanel.Controls.Remove(rac);
            MainPanel.Controls.Remove(sac);
            MainPanel.Controls.Remove(ade);
            MainPanel.Controls.Remove(rec);
            MainPanel.Controls.Remove(sec);
            MainPanel.Controls.Remove(vec);
            MainPanel.Controls.Add(suc);
        }

        private void guna2Button12_Click(object sender, EventArgs e)
        {
            //View Users
            MainPanel.Controls.Remove(ajc);
            MainPanel.Controls.Remove(rmj);
            MainPanel.Controls.Remove(sjc);
            MainPanel.Controls.Remove(vjc);
            MainPanel.Controls.Remove(auc);
            MainPanel.Controls.Remove(ruc);
            MainPanel.Controls.Remove(suc);
            MainPanel.Controls.Remove(vac);
            MainPanel.Controls.Remove(aac);
            MainPanel.Controls.Remove(rac);
            MainPanel.Controls.Remove(sac);
            MainPanel.Controls.Remove(ade);
            MainPanel.Controls.Remove(rec);
            MainPanel.Controls.Remove(sec);
            MainPanel.Controls.Remove(vec);
            MainPanel.Controls.Add(vus);
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            //Add admin
            MainPanel.Controls.Remove(ajc);
            MainPanel.Controls.Remove(rmj);
            MainPanel.Controls.Remove(sjc);
            MainPanel.Controls.Remove(vjc);
            MainPanel.Controls.Remove(auc);
            MainPanel.Controls.Remove(ruc);
            MainPanel.Controls.Remove(suc);
            MainPanel.Controls.Remove(vac);
            MainPanel.Controls.Remove(vus);
            MainPanel.Controls.Remove(rac);
            MainPanel.Controls.Remove(sac);
            MainPanel.Controls.Remove(ade);
            MainPanel.Controls.Remove(rec);
            MainPanel.Controls.Remove(sec);
            MainPanel.Controls.Remove(vec);
            MainPanel.Controls.Add(aac);
        }

        private void guna2Button14_Click(object sender, EventArgs e)
        {
            //Remove Admin
            MainPanel.Controls.Remove(ajc);
            MainPanel.Controls.Remove(rmj);
            MainPanel.Controls.Remove(vjc);
            MainPanel.Controls.Remove(sjc);
            MainPanel.Controls.Remove(auc);
            MainPanel.Controls.Remove(ruc);
            MainPanel.Controls.Remove(suc);
            MainPanel.Controls.Remove(vac);
            MainPanel.Controls.Remove(vus);
            MainPanel.Controls.Remove(aac);
            MainPanel.Controls.Remove(sac);
            MainPanel.Controls.Remove(ade);
            MainPanel.Controls.Remove(rec);
            MainPanel.Controls.Remove(sec);
            MainPanel.Controls.Remove(vec);
            MainPanel.Controls.Add(rac);
        }

        private void guna2Button17_Click(object sender, EventArgs e)
        {
            //Search Admin
            MainPanel.Controls.Remove(ajc);
            MainPanel.Controls.Remove(rmj);
            MainPanel.Controls.Remove(sjc);
            MainPanel.Controls.Remove(vjc);
            MainPanel.Controls.Remove(auc);
            MainPanel.Controls.Remove(ruc);
            MainPanel.Controls.Remove(suc);
            MainPanel.Controls.Remove(vac);
            MainPanel.Controls.Remove(vus);
            MainPanel.Controls.Remove(aac);
            MainPanel.Controls.Remove(rac);
            MainPanel.Controls.Remove(ade);
            MainPanel.Controls.Remove(rec);
            MainPanel.Controls.Remove(sec);
            MainPanel.Controls.Remove(vec);
            MainPanel.Controls.Add(sac);
        }

        private void guna2Button16_Click(object sender, EventArgs e)
        {
            //View Admin
            MainPanel.Controls.Remove(ajc);
            MainPanel.Controls.Remove(rmj);
            MainPanel.Controls.Remove(sjc);
            MainPanel.Controls.Remove(vjc);
            MainPanel.Controls.Remove(auc);
            MainPanel.Controls.Remove(ruc);
            MainPanel.Controls.Remove(suc);
            MainPanel.Controls.Remove(vus);
            MainPanel.Controls.Remove(aac);
            MainPanel.Controls.Remove(rac);
            MainPanel.Controls.Remove(sac);
            MainPanel.Controls.Remove(ade);
            MainPanel.Controls.Remove(rec);
            MainPanel.Controls.Remove(sec);
            MainPanel.Controls.Remove(vec);
            MainPanel.Controls.Add(vac);
        }

        private void guna2Button18_Click(object sender, EventArgs e)
        {
            //Add Employee
            MainPanel.Controls.Remove(ajc);
            MainPanel.Controls.Remove(rmj);
            MainPanel.Controls.Remove(sjc);
            MainPanel.Controls.Remove(vjc);
            MainPanel.Controls.Remove(auc);
            MainPanel.Controls.Remove(ruc);
            MainPanel.Controls.Remove(suc);
            MainPanel.Controls.Remove(vac);
            MainPanel.Controls.Remove(vus);
            MainPanel.Controls.Remove(aac);
            MainPanel.Controls.Remove(rac);
            MainPanel.Controls.Remove(sac);
            MainPanel.Controls.Remove(rec);
            MainPanel.Controls.Remove(sec);
            MainPanel.Controls.Remove(vec);
            MainPanel.Controls.Add(ade);
        }

        private void guna2Button19_Click(object sender, EventArgs e)
        {
            //Remove Employee
            MainPanel.Controls.Remove(ajc);
            MainPanel.Controls.Remove(rmj);
            MainPanel.Controls.Remove(sjc);
            MainPanel.Controls.Remove(vjc);
            MainPanel.Controls.Remove(auc);
            MainPanel.Controls.Remove(ruc);
            MainPanel.Controls.Remove(suc);
            MainPanel.Controls.Remove(vac);
            MainPanel.Controls.Remove(vus);
            MainPanel.Controls.Remove(aac);
            MainPanel.Controls.Remove(rac);
            MainPanel.Controls.Remove(sac);
            MainPanel.Controls.Remove(ade);
            MainPanel.Controls.Remove(sec);
            MainPanel.Controls.Remove(vec);
            MainPanel.Controls.Add(rec);
        }

        private void guna2Button21_Click(object sender, EventArgs e)
        {
            //Search Employee
            MainPanel.Controls.Remove(ajc);
            MainPanel.Controls.Remove(rmj);
            MainPanel.Controls.Remove(sjc);
            MainPanel.Controls.Remove(vjc);
            MainPanel.Controls.Remove(auc);
            MainPanel.Controls.Remove(ruc);
            MainPanel.Controls.Remove(suc);
            MainPanel.Controls.Remove(vac);
            MainPanel.Controls.Remove(vus);
            MainPanel.Controls.Remove(aac);
            MainPanel.Controls.Remove(rac);
            MainPanel.Controls.Remove(sac);
            MainPanel.Controls.Remove(ade);
            MainPanel.Controls.Remove(rec);
            MainPanel.Controls.Remove(vec);
            MainPanel.Controls.Add(sec);
        }

        private void guna2Button20_Click(object sender, EventArgs e)
        {
            //View Emoployees
            MainPanel.Controls.Remove(ajc);
            MainPanel.Controls.Remove(rmj);
            MainPanel.Controls.Remove(sjc);
            MainPanel.Controls.Remove(vjc);
            MainPanel.Controls.Remove(auc);
            MainPanel.Controls.Remove(ruc);
            MainPanel.Controls.Remove(suc);
            MainPanel.Controls.Remove(vus);
            MainPanel.Controls.Remove(vac);
            MainPanel.Controls.Remove(aac);
            MainPanel.Controls.Remove(rac);
            MainPanel.Controls.Remove(sac);
            MainPanel.Controls.Remove(ade);
            MainPanel.Controls.Remove(rec);
            MainPanel.Controls.Remove(sec);

            MainPanel.Controls.Add(vec);


        }

        private void AdminDashboard_Load(object sender, EventArgs e)
        {
            FileHandler.LoadUserFromFile();
            FileHandler.loadJobData();
            FileHandler.loadEmpData();
            MainPanel.Controls.Add(vjc);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            WelcomeForm wf = new WelcomeForm();
            this.Hide();
            wf.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
        }

        private void sidebartimer_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                SidebarPanel.Width -= 10;
                if (SidebarPanel.Width <= 65)
                {
                    sidebarExpand = false;
                    sidebartimer.Stop();
                    menuContainer.Width = SidebarPanel.Width;
                    menuContainer1.Width = SidebarPanel.Width;
                    menuContainer2.Width = SidebarPanel.Width;
                    menuContainer3.Width = SidebarPanel.Width;
                    LogoutPn.Width = SidebarPanel.Width;
                }
            }
            else
            {
                SidebarPanel.Width += 10;
                if (SidebarPanel.Width >= 227)
                {
                    sidebarExpand = true;
                    sidebartimer.Stop();
                    menuContainer.Width = SidebarPanel.Width;
                    menuContainer1.Width = SidebarPanel.Width;
                    menuContainer2.Width = SidebarPanel.Width;
                    menuContainer3.Width = SidebarPanel.Width;
                    LogoutPn.Width = SidebarPanel.Width;
                }
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            WelcomeForm wf = new WelcomeForm();
            this.Hide();
            wf.Show();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            MessageBoxForm mf = new MessageBoxForm();
            mf.ShowMessage("Logging Out...");
            mf.Show();

            WelcomeForm wf = new WelcomeForm();
            this.Hide();
            wf.Show();
        }
    }
}
