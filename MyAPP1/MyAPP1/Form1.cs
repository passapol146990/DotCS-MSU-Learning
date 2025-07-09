using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            lbDetail.Focus();
            MessageBox.Show("Hello passapol", "Show Message Box!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void inputName_TextChanged(object sender, EventArgs e)
        {
            lbName.Text = inputName.Text;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
