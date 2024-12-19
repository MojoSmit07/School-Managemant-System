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
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
            DisplayTeachers();
            FillTeacherDGV();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\sem 4 N\ADT\Project\SchoolManagemantSystem\SchoolManagemantSystem\Project.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayTeachers()
        {
            Con.Open();
            string Query = "Select * from TeachersTb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            TeacherDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Reset()
        {
            Tname.Text = "";
            subCb.SelectedIndex = 0;
            TGenCb.SelectedIndex = 0;
            TPhoneTb.Text = "";
            TAddTb.Text = "";
        }

        void FillTeacherDGV()
        {
            Con.Open();
            String myquery = "Select * from TeachersTb1";
            SqlDataAdapter da = new SqlDataAdapter(myquery, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            var ds = new DataSet();
            da.Fill(ds);
            TeacherDGV.DataSource = ds.Tables[0];
            Con.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (Tname.Text == "" || TPhoneTb.Text == "" || TAddTb.Text == "" || TGenCb.SelectedIndex == -1 || subCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into TeachersTb1(Tname,TGen,TPhone,TSub,TAdd,TDOB) values(@Tname,@TGen,@TPhone,@TSub,@TAdd,@TDOB)", Con);
                    cmd.Parameters.AddWithValue("@Tname", Tname.Text);
                    cmd.Parameters.AddWithValue("@TGen", TGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TPhone", TPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@TSub", subCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TAdd", TAddTb.Text);
                    cmd.Parameters.AddWithValue("@TDOB", TDOB.Value.Date);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher Added");
                    Con.Close();
                    DisplayTeachers();
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
        int Key = 0;
        private void TeacherDGV_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            TId.Text = TeacherDGV.Rows[rowIndex].Cells[0].Value.ToString();
            Tname.Text = TeacherDGV.Rows[rowIndex].Cells[1].Value.ToString();
            TGenCb.SelectedItem = TeacherDGV.Rows[rowIndex].Cells[2].Value.ToString();
            TPhoneTb.Text = TeacherDGV.Rows[rowIndex].Cells[3].Value.ToString();
            subCb.SelectedItem = TeacherDGV.Rows[rowIndex].Cells[4].Value.ToString();
            TAddTb.Text = TeacherDGV.Rows[rowIndex].Cells[5].Value.ToString();
            TDOB.Text = TeacherDGV.Rows[rowIndex].Cells[6].Value.ToString();

            if (Tname.Text == "")
            {
                Key = 0;
            }
            else
            {
                Key = Convert.ToInt32(TeacherDGV.SelectedRows[0].Cells[0].Value.ToString());
            }
        }

        private void TeacherDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (TId.Text == "")
            {
                MessageBox.Show("Select the Teacher");
            }
            else
            {
                Con.Open();
                string query = "delete from TeachersTb1 where TId=(" + TId.Text + ")";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Teacher Deleted Sucessfully");
                Con.Close();
                FillTeacherDGV();
            }
        }

            private void EditBtn_Click(object sender, EventArgs e)
        {
            if (Tname.Text == "" || TPhoneTb.Text == "" || TAddTb.Text == "" || TGenCb.SelectedIndex == -1 || subCb.SelectedIndex == -1)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    SqlCommand cmd = new SqlCommand("Update TeachersTb1 set tname=@Tname,TGen=@TGen,TPhone=@TPhone,TSub=@TSub,TAdd=@TAdd,TDOB=@TDOB where TId=@TeachID", Con);

                    cmd.Parameters.AddWithValue("@Tname", Tname.Text);
                    cmd.Parameters.AddWithValue("@TGen", TGenCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TPhone", TPhoneTb.Text);
                    cmd.Parameters.AddWithValue("@TSub", subCb.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@TAdd", TAddTb.Text);
                    cmd.Parameters.AddWithValue("@TDOB", TDOB.Value.Date);
                    cmd.Parameters.AddWithValue("@TeachID", Key);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Teacher Updated");
                    Con.Close();
                    DisplayTeachers();
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
            MainMenu obj = new MainMenu();
            obj.Show();
            this.Hide();
        }

       
    }
}
