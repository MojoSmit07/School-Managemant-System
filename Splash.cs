﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagemantSystem
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 4;
            MyprogressBar.Value = startpoint;
            if(MyprogressBar.Value == 100)
            {
                MyprogressBar.Value = 0;
                timer1.Stop();
                Login Obj = new Login();
                this.Hide();
                Obj.Show();
            }
               
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void MyprogressBar_Click(object sender, EventArgs e)
        {

        }
    }
}
