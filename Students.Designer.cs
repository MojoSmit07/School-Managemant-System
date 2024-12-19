
namespace SchoolManagemantSystem
{
    partial class Students
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Students));
            this.StudentsDGV = new System.Windows.Forms.DataGridView();
            this.EditBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ClassCb = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.FeesTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DOBPicker = new System.Windows.Forms.DateTimePicker();
            this.StNameTb = new System.Windows.Forms.TextBox();
            this.StGenCb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.AddressTb = new System.Windows.Forms.TextBox();
            this.StId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDGV)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // StudentsDGV
            // 
            this.StudentsDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.StudentsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentsDGV.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.StudentsDGV.Location = new System.Drawing.Point(154, 321);
            this.StudentsDGV.Name = "StudentsDGV";
            this.StudentsDGV.RowHeadersWidth = 51;
            this.StudentsDGV.RowTemplate.Height = 24;
            this.StudentsDGV.Size = new System.Drawing.Size(763, 263);
            this.StudentsDGV.TabIndex = 62;
            this.StudentsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentsGDV_CellContentClick);
            this.StudentsDGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.StudentsDGV_RowHeaderMouseClick);
            // 
            // EditBtn
            // 
            this.EditBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.EditBtn.BackColor = System.Drawing.Color.Tan;
            this.EditBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.EditBtn.Location = new System.Drawing.Point(393, 266);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(96, 40);
            this.EditBtn.TabIndex = 61;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = false;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.BackBtn.BackColor = System.Drawing.Color.Tan;
            this.BackBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BackBtn.Location = new System.Drawing.Point(821, 266);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(96, 40);
            this.BackBtn.TabIndex = 60;
            this.BackBtn.Text = "Back";
            this.BackBtn.UseVisualStyleBackColor = false;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DeleteBtn.BackColor = System.Drawing.Color.Tan;
            this.DeleteBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.DeleteBtn.Location = new System.Drawing.Point(593, 266);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(130, 40);
            this.DeleteBtn.TabIndex = 59;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.SaveBtn.BackColor = System.Drawing.Color.Tan;
            this.SaveBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.SaveBtn.Location = new System.Drawing.Point(184, 266);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(96, 40);
            this.SaveBtn.TabIndex = 58;
            this.SaveBtn.Text = "Add";
            this.SaveBtn.UseVisualStyleBackColor = false;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ClassCb
            // 
            this.ClassCb.BackColor = System.Drawing.Color.Tan;
            this.ClassCb.FormattingEnabled = true;
            this.ClassCb.Items.AddRange(new object[] {
            "8th",
            "9th",
            "10th",
            "11th",
            "12th"});
            this.ClassCb.Location = new System.Drawing.Point(102, 224);
            this.ClassCb.Name = "ClassCb";
            this.ClassCb.Size = new System.Drawing.Size(147, 33);
            this.ClassCb.TabIndex = 57;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(94, 174);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 47);
            this.label6.TabIndex = 56;
            this.label6.Text = "Class";
            // 
            // FeesTb
            // 
            this.FeesTb.BackColor = System.Drawing.Color.Tan;
            this.FeesTb.Location = new System.Drawing.Point(337, 211);
            this.FeesTb.Name = "FeesTb";
            this.FeesTb.Size = new System.Drawing.Size(136, 34);
            this.FeesTb.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(379, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 47);
            this.label1.TabIndex = 1;
            this.label1.Text = "Student Details";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1098, 83);
            this.panel1.TabIndex = 47;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1036, 19);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 61);
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label5.Location = new System.Drawing.Point(330, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 47);
            this.label5.TabIndex = 54;
            this.label5.Text = "Fees";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(545, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 47);
            this.label3.TabIndex = 53;
            this.label3.Text = "DOB";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(92, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 47);
            this.label4.TabIndex = 48;
            this.label4.Text = "Username";
            // 
            // DOBPicker
            // 
            this.DOBPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DOBPicker.Location = new System.Drawing.Point(552, 137);
            this.DOBPicker.Name = "DOBPicker";
            this.DOBPicker.Size = new System.Drawing.Size(135, 34);
            this.DOBPicker.TabIndex = 52;
            // 
            // StNameTb
            // 
            this.StNameTb.BackColor = System.Drawing.Color.Tan;
            this.StNameTb.Location = new System.Drawing.Point(97, 138);
            this.StNameTb.Name = "StNameTb";
            this.StNameTb.Size = new System.Drawing.Size(202, 34);
            this.StNameTb.TabIndex = 49;
            // 
            // StGenCb
            // 
            this.StGenCb.BackColor = System.Drawing.Color.Tan;
            this.StGenCb.FormattingEnabled = true;
            this.StGenCb.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
            this.StGenCb.Location = new System.Drawing.Point(337, 138);
            this.StGenCb.Name = "StGenCb";
            this.StGenCb.Size = new System.Drawing.Size(147, 33);
            this.StGenCb.TabIndex = 51;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(330, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 47);
            this.label2.TabIndex = 50;
            this.label2.Text = "Gender";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(770, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 47);
            this.label7.TabIndex = 63;
            this.label7.Text = "Address";
            // 
            // AddressTb
            // 
            this.AddressTb.BackColor = System.Drawing.Color.Tan;
            this.AddressTb.Location = new System.Drawing.Point(777, 137);
            this.AddressTb.Multiline = true;
            this.AddressTb.Name = "AddressTb";
            this.AddressTb.Size = new System.Drawing.Size(228, 97);
            this.AddressTb.TabIndex = 64;
            // 
            // StId
            // 
            this.StId.BackColor = System.Drawing.Color.Tan;
            this.StId.Enabled = false;
            this.StId.Location = new System.Drawing.Point(32, 141);
            this.StId.Name = "StId";
            this.StId.Size = new System.Drawing.Size(36, 34);
            this.StId.TabIndex = 65;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(24, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 47);
            this.label8.TabIndex = 66;
            this.label8.Text = "ID";
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(1098, 591);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.StId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AddressTb);
            this.Controls.Add(this.StudentsDGV);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.ClassCb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.FeesTb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DOBPicker);
            this.Controls.Add(this.StNameTb);
            this.Controls.Add(this.StGenCb);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Students";
            this.Text = "Students";
            ((System.ComponentModel.ISupportInitialize)(this.StudentsDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StudentsDGV;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.ComboBox ClassCb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox FeesTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DOBPicker;
        private System.Windows.Forms.TextBox StNameTb;
        private System.Windows.Forms.ComboBox StGenCb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AddressTb;
        private System.Windows.Forms.TextBox StId;
        private System.Windows.Forms.Label label8;
    }
}