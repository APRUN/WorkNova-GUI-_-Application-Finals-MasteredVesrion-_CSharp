using System;
using System.IO;
using System.Text;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.DL;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.BL;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.Universal_Forms;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.RegistrationForms;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.UserForms;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.AdminForms;


namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.RegistrationForms
{
    public partial class SignInForm : Form
    {
        MessageBoxForm mf = new MessageBoxForm();
        public SignInForm()
        {
            InitializeComponent();
        }

        private void SignUpbutton_Click(object sender, EventArgs e)
        {
            if(Nametxt.Text.Trim().Length>0&& Passwordtxt.Text.Trim().Length > 0)
            {

                string name = Nametxt.Text;
                string password = Passwordtxt.Text;

                if(PersonDL.IsPersonAvailable(name,password))
                {
                   ShowSignedUpMessage(true);
                    UserDashboard UD = new UserDashboard();
                    this.Hide();
                    UD.Show();
                }
                else if(AdminDL.AdminIsAvailable(name, password))
                {
                    MessageBoxForm mf = new MessageBoxForm();
                    mf.ShowMessage("Welcome Back.");
                    mf.ShowDialog();

                    AdminDashboard AD = new AdminDashboard();
                    this.Hide();
                    AD.Show();
                }
                else
                {
                    mf.ShowMessage("Sorry No Such User Exsist.");
               
                }
            }
            else
            {
                    ShowSignedUpMessage(false);
            }
        }
        private void ShowSignedUpMessage(bool isdone)
        {
            mf.ShowDialog();
            if (isdone)
            {
                mf.ShowMessage("Signed In Successfully.");
            }
            else
            {
                mf.ShowMessage("Please Enter Valid Inputs.");
            }
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            SignUpForm sf = new SignUpForm();
            this.Hide();
            sf.Show();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString("HH:mm");
            DateLabel.Text = DateTime.Now.ToString("MMMM ddd yyyy");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
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
