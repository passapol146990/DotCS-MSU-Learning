namespace MyApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bt_ok = new Button();
            lbName = new Label();
            label1 = new Label();
            inputName = new TextBox();
            lbDetail = new RichTextBox();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // bt_ok
            // 
            bt_ok.BackColor = Color.FromArgb(0, 192, 0);
            bt_ok.Cursor = Cursors.Hand;
            bt_ok.FlatStyle = FlatStyle.Popup;
            bt_ok.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_ok.ForeColor = SystemColors.ButtonHighlight;
            bt_ok.Location = new Point(110, 235);
            bt_ok.Name = "bt_ok";
            bt_ok.Size = new Size(134, 48);
            bt_ok.TabIndex = 0;
            bt_ok.Text = "ok";
            bt_ok.UseVisualStyleBackColor = false;
            bt_ok.Click += bt_ok_Click;
            // 
            // lbName
            // 
            lbName.AutoSize = true;
            lbName.Location = new Point(110, 204);
            lbName.Name = "lbName";
            lbName.Size = new Size(0, 15);
            lbName.TabIndex = 1;
            lbName.Click += label1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 23);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 2;
            label1.Text = "Input Name : ";
            // 
            // inputName
            // 
            inputName.Location = new Point(110, 20);
            inputName.Name = "inputName";
            inputName.Size = new Size(178, 23);
            inputName.TabIndex = 3;
            inputName.TextChanged += inputName_TextChanged;
            // 
            // lbDetail
            // 
            lbDetail.Location = new Point(110, 69);
            lbDetail.Name = "lbDetail";
            lbDetail.Size = new Size(178, 96);
            lbDetail.TabIndex = 4;
            lbDetail.Text = "";
            lbDetail.TextChanged += richTextBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 72);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 2;
            label3.Text = "Detail : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(56, 204);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 1;
            label2.Text = "Name : ";
            label2.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(358, 334);
            Controls.Add(lbDetail);
            Controls.Add(inputName);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(lbName);
            Controls.Add(bt_ok);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bt_ok;
        private Label lbName;
        private Label label1;
        private TextBox inputName;
        private RichTextBox lbDetail;
        private Label label3;
        private Label label2;
    }
}