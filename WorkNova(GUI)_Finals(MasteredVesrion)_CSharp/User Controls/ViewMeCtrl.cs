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

namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.User_Controls
{
    public partial class ViewMeCtrl : UserControl
    {
        public ViewMeCtrl()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            string name = nametxt.Text;

            Employee Me=EmployeeDL.SearchnReturnEmployee(name);
            Person user = PersonDL.SearchPersonByName(name);
            if(Me!=null)
            {
                username.Text = Me.CurrentUser.Name;
                userjobname.Text = Me.Job.Job_name;
                usercontact.Text = Me.Contact;
                citylbl.Text = Me.City;
            }
            else if(user!=null)
            {
                username.Text = user.Name;
                userjobname.Text = "Null";
                usercontact.Text = "Null";
                citylbl.Text = "Null";
            }
            else
            {
                MessageBoxForm mf = new MessageBoxForm();
                mf.ShowMessage("Invalid Name.");
                mf.Show();
            }
        }
    }
}
