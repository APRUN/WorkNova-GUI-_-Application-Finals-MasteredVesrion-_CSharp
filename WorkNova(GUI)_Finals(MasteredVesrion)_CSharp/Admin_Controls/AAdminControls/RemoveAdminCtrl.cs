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
    public partial class RemoveAdminCtrl : UserControl
    {
        public RemoveAdminCtrl()
        {
            InitializeComponent();
        }

        private void Removebtn_Click(object sender, EventArgs e)
        {
            string name = nametxt.Text;

            Admin FoundAdmin=AdminDL.SearchnReturnAdmin(name);

            if(FoundAdmin!=null)
            {
                namelbl.Text = FoundAdmin.Name;
                passwordlbl.Text = FoundAdmin.Password;
                emaillbl.Text = FoundAdmin.Email;

                AdminDL.RemoveAdmin(FoundAdmin);
                FileHandler.WriteJobDatatoFile();

                MessageBoxForm mf = new MessageBoxForm();
                mf.StartPosition = FormStartPosition.CenterScreen;
                mf.ShowMessage("Removed.");
                mf.Show();
            }
            else
            {
                MessageBoxForm mf = new MessageBoxForm();
                mf.StartPosition = FormStartPosition.CenterScreen;
                mf.ShowMessage("Not Present.");
                mf.Show();
            }
        }

        private void RemoveAdminCtrl_Load(object sender, EventArgs e)
        {
            
        }
    }
}
