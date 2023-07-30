using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.RegistrationForms;

namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.Universal_Forms
{
    public partial class WelcomeForm : Form
    {

        public WelcomeForm()
        {
            InitializeComponent();
        }

        private void ClockTimer_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = DateTime.Now.ToString("HH:mm");
            dateLabel1.Text = DateTime.Now.ToString("MMMM ddd yyyy");
        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void SignUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm sf = new SignUpForm();
            this.Hide();
            sf.ShowDialog();
        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {

        }

        private void AboutUsButton_Click(object sender, EventArgs e)
        {
            AboutUsForm abs = new AboutUsForm();
            this.Hide();
            abs.Show();
        }

        private void ContactUsButton_Click(object sender, EventArgs e)
        {
            ContactUsForm csf = new ContactUsForm();
            this.Hide();
            csf.Show();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            SignInForm sif = new SignInForm();
            this.Hide();
            sif.Show();
        }

        private void ControlBoxCrossMark_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
