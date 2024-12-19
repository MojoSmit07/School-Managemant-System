
namespace SchoolManagemantSystem
{
    partial class Event
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Event));
            this.Events = new System.Windows.Forms.Label();
            this.EDescTb = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.EDurationTb = new System.Windows.Forms.TextBox();
            this.EventsDGV = new System.Windows.Forms.DataGridView();
            this.EdinBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.EId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventsDGV)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Events
            // 
            this.Events.AutoSize = true;
            this.Events.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Events.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Events.Location = new System.Drawing.Point(457, 19);
            this.Events.Name = "Events";
            this.Events.Size = new System.Drawing.Size(284, 47);
            this.Events.TabIndex = 1;
            this.Events.Text = "Events Details";
            // 
            // EDescTb
            // 
            this.EDescTb.BackColor = System.Drawing.Color.Tan;
            this.EDescTb.Location = new System.Drawing.Point(104, 152);
            this.EDescTb.Name = "EDescTb";
            this.EDescTb.Size = new System.Drawing.Size(237, 34);
            this.EDescTb.TabIndex = 98;
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
            // EDurationTb
            // 
            this.EDurationTb.BackColor = System.Drawing.Color.Tan;
            this.EDurationTb.Location = new System.Drawing.Point(695, 151);
            this.EDurationTb.Name = "EDurationTb";
            this.EDurationTb.Size = new System.Drawing.Size(224, 34);
            this.EDurationTb.TabIndex = 109;
            // 
            // EventsDGV
            // 
            this.EventsDGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.EventsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventsDGV.Location = new System.Drawing.Point(67, 284);
            this.EventsDGV.Name = "EventsDGV";
            this.EventsDGV.RowHeadersWidth = 51;
            this.EventsDGV.RowTemplate.Height = 24;
            this.EventsDGV.Size = new System.Drawing.Size(974, 299);
            this.EventsDGV.TabIndex = 108;
            this.EventsDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventsDGV_CellContentClick);
            this.EventsDGV.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EventsDGV_RowHeaderMouseClick);
            // 
            // EdinBtn
            // 
            this.EdinBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.EdinBtn.BackColor = System.Drawing.Color.Tan;
            this.EdinBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdinBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.EdinBtn.Location = new System.Drawing.Point(390, 229);
            this.EdinBtn.Name = "EdinBtn";
            this.EdinBtn.Size = new System.Drawing.Size(96, 40);
            this.EdinBtn.TabIndex = 107;
            this.EdinBtn.Text = "Edit";
            this.EdinBtn.UseVisualStyleBackColor = false;
            this.EdinBtn.Click += new System.EventHandler(this.EdinBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.BackBtn.BackColor = System.Drawing.Color.Tan;
            this.BackBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.BackBtn.Location = new System.Drawing.Point(818, 229);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(96, 40);
            this.BackBtn.TabIndex = 106;
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
            this.DeleteBtn.Location = new System.Drawing.Point(590, 229);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(125, 40);
            this.DeleteBtn.TabIndex = 105;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = false;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AddBtn.BackColor = System.Drawing.Color.Tan;
            this.AddBtn.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBtn.ForeColor = System.Drawing.SystemColors.Highlight;
            this.AddBtn.Location = new System.Drawing.Point(181, 229);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(96, 40);
            this.AddBtn.TabIndex = 104;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = false;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(688, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(271, 47);
            this.label6.TabIndex = 103;
            this.label6.Text = "Duration(Hrs)";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Tan;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.Events);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 83);
            this.panel1.TabIndex = 96;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(437, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 47);
            this.label3.TabIndex = 102;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(97, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 47);
            this.label4.TabIndex = 97;
            this.label4.Text = "Event";
            // 
            // EDate
            // 
            this.EDate.CalendarForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.EDate.CalendarMonthBackground = System.Drawing.Color.Tan;
            this.EDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EDate.Location = new System.Drawing.Point(444, 151);
            this.EDate.Name = "EDate";
            this.EDate.Size = new System.Drawing.Size(135, 34);
            this.EDate.TabIndex = 101;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(32, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 47);
            this.label8.TabIndex = 111;
            this.label8.Text = "ID";
            // 
            // EId
            // 
            this.EId.BackColor = System.Drawing.Color.Tan;
            this.EId.Enabled = false;
            this.EId.Location = new System.Drawing.Point(40, 155);
            this.EId.Name = "EId";
            this.EId.Size = new System.Drawing.Size(36, 34);
            this.EId.TabIndex = 110;
            // 
            // Event
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 591);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.EId);
            this.Controls.Add(this.EDescTb);
            this.Controls.Add(this.EDurationTb);
            this.Controls.Add(this.EventsDGV);
            this.Controls.Add(this.EdinBtn);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EDate);
            this.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Event";
            this.Text = "Event";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventsDGV)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Events;
        private System.Windows.Forms.TextBox EDescTb;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox EDurationTb;
        private System.Windows.Forms.DataGridView EventsDGV;
        private System.Windows.Forms.Button EdinBtn;
        private System.Windows.Forms.Button BackBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker EDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox EId;
    }
}