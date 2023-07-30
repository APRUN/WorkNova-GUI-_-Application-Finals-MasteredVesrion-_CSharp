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

namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.Admin_Controls.AUserControls
{
    public partial class RemoveUserCtrl : UserControl
    {
        public RemoveUserCtrl()
        {
            InitializeComponent();
        }

        private void Removebtn_Click(object sender, EventArgs e)
        {
            string name = nametxt.Text;

            Person GotUser= PersonDL.SearchPersonByName(name);
            if(!(GotUser.Name==null))
            {
                namelbl.Text = GotUser.Name;
                passwordlbl.Text = GotUser.Password;
                emaillbl.Text = GotUser.Email;

                PersonDL.RemovePerson(GotUser);
                FileHandler.WriteUsertoFile();
            }
        }

        private void RemoveUserCtrl_Load(object sender, EventArgs e)
        {
            
        }
    }
}
