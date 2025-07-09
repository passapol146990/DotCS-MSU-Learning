namespace MyApp2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textIndex = new TextBox();
            textItem = new TextBox();
            label2 = new Label();
            listBox1 = new ListBox();
            btAdd = new Button();
            btInsert = new Button();
            btRemove = new Button();
            btRemoveAt = new Button();
            btUp = new Button();
            btDown = new Button();
            lbCount = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(57, 40);
            label1.Name = "label1";
            label1.Size = new Size(72, 25);
            label1.TabIndex = 0;
            label1.Text = "index : ";
            // 
            // textIndex
            // 
            textIndex.Location = new Point(134, 40);
            textIndex.Name = "textIndex";
            textIndex.Size = new Size(132, 23);
            textIndex.TabIndex = 1;
            // 
            // textItem
            // 
            textItem.Location = new Point(134, 69);
            textItem.Name = "textItem";
            textItem.Size = new Size(132, 23);
            textItem.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(66, 67);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 0;
            label2.Text = "Item : ";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(308, 31);
            listBox1.Name = "listBox1";
            listBox1.RightToLeft = RightToLeft.No;
            listBox1.Size = new Size(276, 394);
            listBox1.TabIndex = 2;
            // 
            // btAdd
            // 
            btAdd.Location = new Point(134, 125);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(75, 23);
            btAdd.TabIndex = 3;
            btAdd.Text = "Add";
            btAdd.UseVisualStyleBackColor = true;
            btAdd.Click += btAdd_Click;
            // 
            // btInsert
            // 
            btInsert.Location = new Point(134, 154);
            btInsert.Name = "btInsert";
            btInsert.Size = new Size(75, 23);
            btInsert.TabIndex = 3;
            btInsert.Text = "Insert";
            btInsert.UseVisualStyleBackColor = true;
            btInsert.Click += btInsert_Click;
            // 
            // btRemove
            // 
            btRemove.Location = new Point(134, 183);
            btRemove.Name = "btRemove";
            btRemove.Size = new Size(75, 23);
            btRemove.TabIndex = 3;
            btRemove.Text = "Remove";
            btRemove.UseVisualStyleBackColor = true;
            btRemove.Click += btRemove_Click;
            // 
            // btRemoveAt
            // 
            btRemoveAt.Location = new Point(134, 212);
            btRemoveAt.Name = "btRemoveAt";
            btRemoveAt.Size = new Size(75, 23);
            btRemoveAt.TabIndex = 3;
            btRemoveAt.Text = "Remove at";
            btRemoveAt.UseVisualStyleBackColor = true;
            btRemoveAt.Click += btRemoveAt_Click;
            // 
            // btUp
            // 
            btUp.Location = new Point(134, 241);
            btUp.Name = "btUp";
            btUp.Size = new Size(75, 23);
            btUp.TabIndex = 3;
            btUp.Text = "Up";
            btUp.UseVisualStyleBackColor = true;
            btUp.Click += btUp_Click;
            // 
            // btDown
            // 
            btDown.Location = new Point(134, 270);
            btDown.Name = "btDown";
            btDown.Size = new Size(75, 23);
            btDown.TabIndex = 3;
            btDown.Text = "Down";
            btDown.UseVisualStyleBackColor = true;
            btDown.Click += btDown_Click;
            // 
            // lbCount
            // 
            lbCount.AutoSize = true;
            lbCount.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbCount.Location = new Point(308, 3);
            lbCount.Name = "lbCount";
            lbCount.Size = new Size(22, 25);
            lbCount.TabIndex = 0;
            lbCount.Text = "0";
            lbCount.Click += label3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(664, 450);
            Controls.Add(btDown);
            Controls.Add(btUp);
            Controls.Add(btRemoveAt);
            Controls.Add(btRemove);
            Controls.Add(btInsert);
            Controls.Add(btAdd);
            Controls.Add(listBox1);
            Controls.Add(textItem);
            Controls.Add(textIndex);
            Controls.Add(label2);
            Controls.Add(lbCount);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textIndex;
        private TextBox textItem;
        private Label label2;
        private ListBox listBox1;
        private Button btAdd;
        private Button btInsert;
        private Button btRemove;
        private Button btRemoveAt;
        private Button btUp;
        private Button btDown;
        private Label lbCount;
    }
}
