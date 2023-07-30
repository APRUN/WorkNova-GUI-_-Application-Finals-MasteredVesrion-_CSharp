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

namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.Admin_Controls.AJobControls
{
    public partial class AddJobCtrl : UserControl
    {
        public AddJobCtrl()
        {
            InitializeComponent();
        }

        private void AddJobCtrl_Load(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            bool valid = false;
            bool valid1 = false;
            bool valid2 = false;

            float exp=0;
            float pay=0;
            string category="";
            string city="";

            MessageBoxForm mf = new MessageBoxForm();


            string name = nametxt.Text;
            string pay1 = paytxt.Text;
            string compname = compnametxt.Text;

            if (catcombobox.SelectedItem == null)
            {
                valid = false;
            }
            else
            {
                category = catcombobox.SelectedItem.ToString();
                if (category == "Internship" || category == "Part Time" || category == "Full Time")
                {
                    valid = true;
                }

                city = citytxt.Text;
                string exp1 = exptxt.Text;

                if (float.TryParse(pay1,out pay)&&pay>0)
                {
                    valid1 = true;
                }
                if (float.TryParse(exp1,out exp)&&exp>0)
                {
                    valid2 = true;
                }
            }
                if (valid == true&&valid1==true&&valid2== true&&nametxt.Text.Trim().Length > 0&& compnametxt.Text.Trim().Length > 0&& citytxt.Text.Trim().Length > 0)
                {
                   Job getJob = new Job(name,compname,exp,city,category,pay);

                   JobDL.AddJob(getJob);
                   FileHandler.WriteJobDatatoFile();

                   mf.ShowMessage("Job Added.");
                   mf.Show();
                   Cleartxt();
                }
                else
                {
                   MessageBox.Show("Please Enter Valid Inputs.");
                }


        }
        private void Cleartxt()
        {
            nametxt.Text = "";
            compnametxt.Text = "";
            paytxt.Text = "";
            exptxt.Text = "";
            citytxt.Text = "";
            catcombobox.SelectedItem = null;
        }
    }
}
