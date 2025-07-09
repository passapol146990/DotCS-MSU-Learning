namespace PictureBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void LoaderComboBox(object sender, EventArgs e)
        {
            String[] strings = { "CS", "OK", "CA", "IT" };
            foreach (String s in strings)
            {
                comboBox1.Items.Add(s);
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            lbDatetime.Text = dateTimePicker1.Text;
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            lbCalenda.Text = monthCalendar1.SelectionStart.ToLongDateString();
        }

        private void btProcessbar_Click(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            for (int i = 0; i <= 100; i++)
            {
                progressBar1.Value = i;
                int percent = (int)(((double)progressBar1.Value/(double)progressBar1.Maximum)*100);
                progressBar1.Refresh();
                progressBar1.CreateGraphics().DrawString(percent + "%",
                    new Font("Arial",(float)0.8, FontStyle.Regular),
                    Brushes.Black,
                    new PointF(progressBar1.Width / 2 - 10, progressBar1.Height / 2 - 7));
                System.Threading.Thread.Sleep(10);
            }
        }
    }
}
