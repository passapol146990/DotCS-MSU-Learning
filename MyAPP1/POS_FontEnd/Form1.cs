namespace POS_FontEnd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            for (int i = 0; i < 20; i++)
            {
                Button newItem = new Button();
                Item_demo.BackColor = Color.FromArgb(255, 128, 128);
                Item_demo.FlatStyle = FlatStyle.Flat;
                Item_demo.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
                Item_demo.ForeColor = SystemColors.ControlText;
                Item_demo.ImageAlign = ContentAlignment.BottomCenter;
                Item_demo.ImageIndex = 0;
                Item_demo.ImageList = imageList2;
                Item_demo.Location = new Point(3, 3);
                Item_demo.Name = "Item_demo";
                Item_demo.Size = new Size(108, 112);
                Item_demo.TabIndex = 0;
                Item_demo.Text = "A" + i;
                Item_demo.TextAlign = ContentAlignment.TopCenter;
                Item_demo.UseVisualStyleBackColor = false;
                ShowItems.Controls.Add(newItem);
            }
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BodyLists_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
