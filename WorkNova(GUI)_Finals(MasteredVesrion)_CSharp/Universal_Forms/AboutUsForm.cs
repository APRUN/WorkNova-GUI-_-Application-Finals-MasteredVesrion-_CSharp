using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkNova_GUI__Finals_MasteredVesrion__CSharp.Universal_Forms
{
    public partial class AboutUsForm : Form
    {
        public AboutUsForm()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            WelcomeForm wf = new WelcomeForm();
            this.Hide();
            wf.Show();
        }

        private void ControlBoxCrossMark_Click(object sender, EventArgs e)
        {
            WelcomeForm wf = new WelcomeForm();
            this.Hide();
            wf.Show();
        }
    }
}
