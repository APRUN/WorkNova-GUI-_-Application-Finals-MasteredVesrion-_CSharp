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
    public partial class ViewAdminsCtrl : UserControl
    {
        public ViewAdminsCtrl()
        {
            InitializeComponent();
        }

        private void LoadDatatoListView()
        {
            foreach (Admin admin in AdminDL.AdminList1)
            {
                ListViewItem item = new ListViewItem(admin.Name);
                item.SubItems.Add(admin.Password);
                item.SubItems.Add(admin.Email);
                AdminListView.Items.Add(item);
            }
        }
        private void ViewAdminsCtrl_Load(object sender, EventArgs e)
        {
            AdminListView.Columns.Add("Name", 150);
            AdminListView.Columns.Add("Password", 160);
            AdminListView.Columns.Add("E-Mail", 150);
            LoadDatatoListView();
        }
    }
}
