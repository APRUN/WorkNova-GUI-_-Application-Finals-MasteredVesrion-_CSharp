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
    public partial class SearchUserCtrl : UserControl
    {
        public SearchUserCtrl()
        {
            InitializeComponent();
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            string name = nametxt.Text;
            Person FoundUser=PersonDL.SearchPersonByName(name);

            namelbl.Text = FoundUser.Name;
            passwordlbl.Text = FoundUser.Password;
            emaillbl.Text = FoundUser.Email;
        }

        private void SearchUserCtrl_Load(object sender, EventArgs e)
        {
            
        }
    }
}
