using System;
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
    public partial class MM_Loading : Form
    {
        public MM_Loading()
        {
            InitializeComponent();
        }

        private void MyprogressBar_Click(object sender, EventArgs e)
        {

        }



        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 4;
            MyprogressBar.Value = startpoint;
            if (MyprogressBar.Value == 100)
            {
                MyprogressBar.Value = 0;
                timer1.Stop();
                MainMenu Obj = new MainMenu();
                this.Hide();
                Obj.Show();
            }
        }
        private void MM_Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
