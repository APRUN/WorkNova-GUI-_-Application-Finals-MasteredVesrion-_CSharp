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

namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.Admin_Controls.AAdminControls
{
    public partial class AddAdminCtrl : UserControl
    {
        public AddAdminCtrl()
        {
            InitializeComponent();
        }

        private void AddAdminCtrl_Load(object sender, EventArgs e)
        {

        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            string name = nametxt.Text;
            string password = passwordtxt.Text;
            string email = emailtxt.Text;

            Admin GotAdmin = new Admin(name,password,email);

            if(ValidTxt())
            { 
                if(!(AdminDL.AdminIsAvailable(GotAdmin.Name,GotAdmin.Password)))
                {
                    AdminDL.AddAdmin(GotAdmin);
                    FileHandler.WriteAdmintoFile();

                    MessageBoxForm mf = new MessageBoxForm();
                    mf.StartPosition = FormStartPosition.CenterScreen;
                    mf.ShowMessage("Admin Added.");
                    mf.Show();
                }
                else
                {
                    MessageBoxForm mf = new MessageBoxForm();
                    mf.StartPosition = FormStartPosition.CenterScreen;
                    mf.ShowMessage("Already Exsist.");
                    mf.Show();
                }
            }
            else
            {
                MessageBoxForm mf = new MessageBoxForm();
                mf.StartPosition = FormStartPosition.CenterScreen;
                mf.ShowMessage("Invalid Entries.");
                mf.Show();
            }
        }
        private void Cleartxt()
        {
            nametxt.Text = "";
            passwordtxt.Text = "";
            emailtxt.Text = "";
        }
        private bool ValidTxt()
        {
            if(nametxt!=null&& passwordtxt!=null && emailtxt!=null)
            {
                return true;
            }
            return false;
        }
    }
}
