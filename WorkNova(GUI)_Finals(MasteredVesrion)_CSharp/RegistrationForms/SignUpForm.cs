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
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.UserForms;

namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.RegistrationForms
{
    public partial class SignUpForm : Form
    {
        public SignUpForm()
        {
            InitializeComponent();
        }

        private void SignUpForm_Load(object sender, EventArgs e)
        {

        }

        private void SignUpbutton_Click(object sender, EventArgs e)
        {
                string name=Nametxt.Text;
                string password = Passwordtxt.Text;
                string email = Emailtxt.Text;

                User NewUser = new User(name,password,email);
            if(Nametxt.Text.Trim().Length>0&&Passwordtxt.Text.Trim().Length > 0 && Emailtxt.Text.Trim().Length > 0&&!(PersonDL.IsPersonAvailable(NewUser.Name,NewUser.Password)))
            {

                PersonDL.AddPerson(NewUser);
                FileHandler.WriteUsertoFile();

                ShowSignedUpMessage(true);
                ClearTxtBox();
                UserDashboard UD = new UserDashboard();
                this.Hide();
                UD.Show();
            }
            else
            {
                ShowSignedUpMessage(false);
            }
        }
        private void ShowSignedUpMessage(bool isdone)
        {
            MessageBoxForm mf = new MessageBoxForm();
            if(isdone)
            {
                mf.ShowMessage("Signed Up Successfully.");
            }
            else
            {
                mf.ShowMessage("Please Enter Valid Inputs.");
            }
            mf.ShowDialog();
        }
        private void ClearTxtBox()
        {
            Nametxt.Text="";
            Passwordtxt.Text="";
            Emailtxt.Text="";
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            SignInForm sf = new SignInForm();
            this.Hide();
            sf.Show();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString("HH:mm");
            DateLabel.Text = DateTime.Now.ToString("MMMM ddd yyyy");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
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
