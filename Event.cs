using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagemantSystem
{
    public partial class Event : Form
    {
        public Event()
        {
            InitializeComponent();
            DisplayEvents();
            FillEventsDGV();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\sem 4 N\ADT\Project\SchoolManagemantSystem\SchoolManagemantSystem\Project.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayEvents()
        {
            Con.Open();
            string Query = "Select * from EventsTb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            EventsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        void FillEventsDGV()
        {
            Con.Open();
            String myquery = "Select * from EventsTb1";
            SqlDataAdapter da = new SqlDataAdapter(myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            EventsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            EDurationTb.Text = "";
            EDescTb.Text = "";
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (EDescTb.Text == "" || EDurationTb.Text == "" )
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into EventsTb1(EDesc,EDate,EDuration) values (@EvDesc,@EvDate,@EvDur)", Con);
                    cmd.Parameters.AddWithValue("@EvDesc", EDescTb.Text);
                    cmd.Parameters.AddWithValue("@EvDate", EDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EvDur", EDurationTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Event Added");
                    Con.Close();
                    DisplayEvents();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu(); 
            Obj.Show();
            this.Hide();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (EId.Text == "")
            {
                MessageBox.Show("Select the Event");
            }
            else
            {
                Con.Open();
                string query = "delete from EventsTb1 where EId=(" + EId.Text + ")";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Event Deleted Sucessfully");
                Con.Close();
                FillEventsDGV();
            }
        }
        

        private void EventsDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        int Key = 0;
        private void EventsDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            EId.Text = EventsDGV.Rows[rowIndex].Cells[0].Value.ToString();
            EDescTb.Text = EventsDGV.Rows[rowIndex].Cells[1].Value.ToString();
            EDate.Text = EventsDGV.Rows[rowIndex].Cells[2].Value.ToString();
            EDurationTb.Text = EventsDGV.Rows[rowIndex].Cells[3].Value.ToString();

            if (EDescTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(EventsDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void EdinBtn_Click(object sender, EventArgs e)
        {
            if (EDescTb.Text == "" || EDurationTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update EventsTb1 set EDesc=@EvDesc,EDate=@EvDate,EDuration=@EvDuration where EId=@EvID", Con);
                    cmd.Parameters.AddWithValue("@EvDesc", EDescTb.Text);
                    cmd.Parameters.AddWithValue("@EvDate", EDate.Value.Date);
                    cmd.Parameters.AddWithValue("@EvDuration", EDurationTb.Text);
                    cmd.Parameters.AddWithValue("@EvID", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Event Updated");
                    Con.Close();
                    DisplayEvents();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }
       
    }
}
