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
    public partial class MessageBoxForm : Form
    {
        public MessageBoxForm()
        {
            InitializeComponent();
        }

        private void MessageBoxForm_Load(object sender, EventArgs e)
        {

        }
        public void ShowMessage(string message)
        {
            label1.Text = message;
        }

        private void Okbtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
