using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Permissions;

namespace SchoolManagemantSystem
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
            DisplayStudent();
            FillStudentsDGV();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\sem 4 N\ADT\Project\SchoolManagemantSystem\SchoolManagemantSystem\Project.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayStudent()
        {
            Con.Open(); 
            string Query = "Select * from StudentTb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda); 
            var ds = new DataSet();
            sda.Fill(ds);
            StudentsDGV.DataSource = ds.Tables[0]; 
            Con.Close();
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || FeesTb.Text == "" || AddressTb.Text == "" || StGenCb.SelectedIndex == -1 || ClassCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                     Con.Open();
                     SqlCommand cmd = new SqlCommand("insert into StudentTb1(StName,StGen,StDOB,StClass,StFees,StAdd) values(@Sname,@SGen,@SDob,@SClass,@SFees,@SAdd)", Con);
                     cmd.Parameters.AddWithValue("@SName", StNameTb.Text);
                     cmd.Parameters.AddWithValue("@SGen", StGenCb.SelectedItem.ToString());
                     cmd.Parameters.AddWithValue("@SDob", DOBPicker.Value.Date);
                     cmd.Parameters.AddWithValue("@SClass", ClassCb.SelectedItem.ToString());
                     cmd.Parameters.AddWithValue("@SFees", FeesTb.Text);
                     cmd.Parameters.AddWithValue("@SAdd", AddressTb.Text);
                     cmd.ExecuteNonQuery();
                     MessageBox.Show("Student Added");
                     Con.Close();
                     DisplayStudent();
                     Reset();
                }
                catch(Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
                
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        void FillStudentsDGV()
        {
            Con.Open();
            String myquery = "Select * from StudentTb1";
            SqlDataAdapter da = new SqlDataAdapter(myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            StudentsDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            Key = 0;
            StNameTb.Text = "";
            FeesTb.Text = "";
            AddressTb.Text = "";
            StGenCb.SelectedIndex = 0;
            ClassCb.SelectedIndex = 0;
        }
       
        private void StudentsGDV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            
        }
        int Key = 0;
        private void StudentsDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            StId.Text = StudentsDGV.Rows[rowIndex].Cells[0].Value.ToString();
            StNameTb.Text = StudentsDGV.Rows[rowIndex].Cells[1].Value.ToString();
            StGenCb.SelectedItem = StudentsDGV.Rows[rowIndex].Cells[2].Value.ToString();
            DOBPicker.Text = StudentsDGV.Rows[rowIndex].Cells[3].Value.ToString();
            ClassCb.SelectedItem = StudentsDGV.Rows[rowIndex].Cells[4].Value.ToString();
            FeesTb.Text = StudentsDGV.Rows[rowIndex].Cells[5].Value.ToString();
            AddressTb.Text = StudentsDGV.Rows[rowIndex].Cells[6].Value.ToString();
            if (StNameTb.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(StudentsDGV.Rows[rowIndex].Cells[0].Value.ToString());
            }
        }
        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (StId.Text == "")
            {
                MessageBox.Show("Select the Student");
            }
            else
            {
                Con.Open();
                string query = "delete from StudentTb1 where StId=(" + StId.Text + ")";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Deleted Sucessfully");
                Con.Close();
                FillStudentsDGV();
            }

        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || FeesTb.Text == "" || AddressTb.Text == "" || StGenCb.SelectedIndex == -1 || ClassCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update StudentTb1 set StName=@SName,StGen=@SGen,StDOB=@SDob,StClass=@SClass,StFees=@SFees,StAdd=@SAdd where StId=@SID",Con);
                    cmd.Parameters.AddWithValue("@SName", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@SGen", StGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SDob", DOBPicker.Value.Date);
                    cmd.Parameters.AddWithValue("@SClass", ClassCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@SFees", FeesTb.Text);
                    cmd.Parameters.AddWithValue("@SAdd", AddressTb.Text);
                    cmd.Parameters.AddWithValue("@SID", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Updated");
                    Con.Close();
                    DisplayStudent();
                    Reset();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }

            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu(); 
            Obj.Show();
            this.Hide();
        }

       
    }
}
