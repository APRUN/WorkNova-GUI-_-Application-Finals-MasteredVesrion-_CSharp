using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.Universal_Forms;
using WorkNova_GUI__Finals_MasteredVesrion__CSharp.BL;

namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.Universal_Forms
{
    public partial class LoadingForm : Form
    {
        public LoadingForm()
        {
            InitializeComponent();
        }

        private void LoadingForm_Load(object sender, EventArgs e)
        {
            FileHandler.LoadUserFromFile();
            FileHandler.LoadAdminFromFile();
        }
        private void LoadTimer_Tick(object sender, EventArgs e)
        {
            LoadingPanelFilled.Width += 3;
            if (LoadingPanelFilled.Width >= 599)
            {
                LoadTimer.Stop();
                WelcomeForm wf = new WelcomeForm();                
                this.Hide();
                wf.ShowDialog();
               
            }
        }
    }
}
