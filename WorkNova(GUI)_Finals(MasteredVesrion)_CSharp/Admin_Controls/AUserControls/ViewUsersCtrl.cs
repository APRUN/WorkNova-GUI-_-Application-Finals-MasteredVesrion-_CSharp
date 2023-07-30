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
    public partial class ViewUsersCtrl : UserControl
    {
        public ViewUsersCtrl()
        {
            InitializeComponent();
        }
        private void LoadDatatoListView()
        {
            foreach (Person person in PersonDL.Persons1)
            {
                ListViewItem item = new ListViewItem(person.Name);
                item.SubItems.Add(person.Password);
                item.SubItems.Add(person.Email);
                UserListView.Items.Add(item);
            }
        }

        private void ViewUsersCtrl_Load(object sender, EventArgs e)
        {
            UserListView.Columns.Add("Name", 160);
            UserListView.Columns.Add("Password: ", 150);
            UserListView.Columns.Add("Email: ", 150);
            LoadDatatoListView();
        }
    }
}
