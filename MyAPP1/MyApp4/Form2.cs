using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyApp4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] menu = { "ชายเขียว", "ชานมเย็น" };
            foreach (var item in menu)
            {
                Button btn = new Button();
                btn.Text = item.ToString();
                btn.Size = new Size(214, 98);
                btn.BackColor = Color.White;
                btn.ForeColor = Color.Black;
                btn.Click += btn_click;
                flowLayoutPanel1.Controls.Add(btn);

            }
        }

        private void btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show(" "+ btn.Text);

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
