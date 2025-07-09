namespace PictureBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new System.Windows.Forms.PictureBox();
            fileSystemWatcher1 = new FileSystemWatcher();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            monthCalendar1 = new MonthCalendar();
            lbDatetime = new Label();
            lbCalenda = new Label();
            progressBar1 = new ProgressBar();
            btProcessbar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.ErrorImage = (Image)resources.GetObject("pictureBox1.ErrorImage");
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(39, 34);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(317, 276);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // fileSystemWatcher1
            // 
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher1.SynchronizingObject = this;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(39, 347);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = "yyyy MMMM dddd hh:ss";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(531, 34);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(178, 23);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(531, 112);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 3;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged;
            // 
            // lbDatetime
            // 
            lbDatetime.AutoSize = true;
            lbDatetime.Location = new Point(531, 74);
            lbDatetime.Name = "lbDatetime";
            lbDatetime.Size = new Size(65, 15);
            lbDatetime.TabIndex = 4;
            lbDatetime.Text = "xx/xx/xxxx";
            // 
            // lbCalenda
            // 
            lbCalenda.AutoSize = true;
            lbCalenda.Location = new Point(531, 295);
            lbCalenda.Name = "lbCalenda";
            lbCalenda.Size = new Size(65, 15);
            lbCalenda.TabIndex = 4;
            lbCalenda.Text = "xx/xx/xxxx";
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(531, 337);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(178, 23);
            progressBar1.TabIndex = 5;
            // 
            // btProcessbar
            // 
            btProcessbar.Location = new Point(531, 375);
            btProcessbar.Name = "btProcessbar";
            btProcessbar.Size = new Size(75, 23);
            btProcessbar.TabIndex = 6;
            btProcessbar.Text = "start";
            btProcessbar.UseVisualStyleBackColor = true;
            btProcessbar.Click += btProcessbar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btProcessbar);
            Controls.Add(progressBar1);
            Controls.Add(lbCalenda);
            Controls.Add(lbDatetime);
            Controls.Add(monthCalendar1);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            Load += LoaderComboBox;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private FileSystemWatcher fileSystemWatcher1;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private MonthCalendar monthCalendar1;
        private Label lbCalenda;
        private Label lbDatetime;
        private Button btProcessbar;
        private ProgressBar progressBar1;
    }
}
