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

namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.Admin_Controls.AUserControls
{
    public partial class AddUserCtrl : UserControl
    {
        public AddUserCtrl()
        {
            InitializeComponent();
        }

        private void AddUserCtrl_Load(object sender, EventArgs e)
        {
            
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            string name=nametxt.Text;
            string password = passwordtxt.Text;
            string email = emailtxt.Text;

            User TempUser = new User(name,password,email);

            if(!(PersonDL.IsPersonAvailable(TempUser.Name,TempUser.Password)))
            {
                PersonDL.AddPerson(TempUser);
                FileHandler.WriteUsertoFile();
                Cleartxt(); 

                MessageBoxForm mf = new MessageBoxForm();
                mf.StartPosition = FormStartPosition.CenterScreen;
                mf.ShowMessage("User Added.");
                mf.Show();
            }
            else
            {
                MessageBoxForm mf = new MessageBoxForm();
                mf.StartPosition = FormStartPosition.CenterScreen;
                mf.ShowMessage("User Already Exsist.");
                mf.Show();
            }
        }
        private void Cleartxt()
        {
            nametxt.Text = "";
            passwordtxt.Text = "";
            emailtxt.Text = "";

        }
    }
}
