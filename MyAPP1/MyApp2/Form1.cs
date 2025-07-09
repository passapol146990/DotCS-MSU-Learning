namespace MyApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void setCount(int mode)
        {
            int i = listBox1.Items.Count;
            if (mode == 0)
            {
                if (i > 0)
                {
                    lbCount.Text = (i - 1).ToString();
                }
            }
            else
            {
                lbCount.Text = (i + 1).ToString();
            }
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            if (textItem.Text != "")
            {
                this.setCount(1);
                listBox1.Items.Add(textItem.Text);
                textItem.Text = "";
                textItem.Focus();
            }
        }

        private void btInsert_Click(object sender, EventArgs e)
        {
            if (textIndex.Text != "" && textItem.Text != "")
            {
                this.setCount(1);
                listBox1.Items.Insert(Convert.ToInt16(textIndex.Text) - 1, textItem.Text);
                textItem.Text = "";
                textItem.Focus();
            }
        }

        private void btRemove_Click(object sender, EventArgs e)
        {
            if (textItem.Text != "")
            {
                this.setCount(0);
                listBox1.Items.Remove(textItem.Text);
            }
        }

        private void btRemoveAt_Click(object sender, EventArgs e)
        {
            if (textIndex.Text != "" && listBox1.Items.Count != 0)
            {
                this.setCount(0);
                listBox1.Items.RemoveAt(Convert.ToInt16(textIndex.Text) - 1);
            }
        }

        private void btUp_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;

            if (i > 0)
            {
                object item = listBox1.SelectedItem;
                listBox1.Items.RemoveAt(i);
                listBox1.Items.Insert(i - 1, item);
                listBox1.SetSelected(i - 1, true);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btDown_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if (i < listBox1.Items.Count - 1 && i != -1)
            {
                object item = listBox1.SelectedItem;
                listBox1.Items.RemoveAt(i);
                listBox1.Items.Insert(i + 1, item);
                listBox1.SetSelected(i + 1, true);
            }
        }
    }
}
