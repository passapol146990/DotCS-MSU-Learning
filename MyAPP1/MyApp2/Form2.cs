using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal sum = numericUpDown1.Value + numericUpDown2.Value;
            MessageBox.Show(String.Format("Total is {0:C}", sum),"sumation",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
