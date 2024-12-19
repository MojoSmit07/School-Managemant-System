using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;

namespace SchoolManagemantSystem
{
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
            DisplayFees();
            FillStudId();
        }
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\sem 4 N\ADT\Project\SchoolManagemantSystem\SchoolManagemantSystem\Project.mdf;Integrated Security=True;Connect Timeout=30");
        private void DisplayFees()
        {
            Con.Open();
            string Query = "Select * from FeesTb1";
            SqlDataAdapter sda = new SqlDataAdapter(Query, Con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            FeesDGV.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void FillStudId()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("select StId from StudentTb1", Con);
            SqlDataReader rdr;
            rdr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("StId", typeof(int));
            dt.Load(rdr);
            StdIdCb.ValueMember = "StId";
            StdIdCb.DataSource = dt;

            Con.Close();
        }
        private void GetStudName()
        {
            Con.Open();
            SqlCommand cmd = new SqlCommand("Select *from StudentTb1 where StId=@SID", Con);
            cmd.Parameters.AddWithValue("@SID", StdIdCb.SelectedValue.ToString());
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                StNameTb.Text = dr["StName"].ToString();
            }
            Con.Close();
        }
        private void Reset()
        {
            AmountTb.Text = "";
            StNameTb.Text = "";
            StdIdCb.SelectedIndex = -1;
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            if (StNameTb.Text == "" || AmountTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }

            else
            {
                string paymentperiode;
                paymentperiode = PeriodDate.Value.Month.ToString() +"/"+ PeriodDate.Value.Year.ToString();
                Con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select COUNT(*) from FeesTb1 where StId = '" + StdIdCb.SelectedValue.ToString() + "' and Month = '" + paymentperiode.ToString() + "'", Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("There is No Due for This Month");
                }
                else
                {
                    //Con.Open();
                    SqlCommand cmd = new SqlCommand("insert into FeesTb1(StId,StName,Month,Amt) values (@StdIdCb,@StNameTb,@SMonth,@SAmt)", Con);
                    cmd.Parameters.AddWithValue("@StdIdCb", StdIdCb.SelectedValue.ToString());
                    cmd.Parameters.AddWithValue("@StNameTb", StNameTb.Text);
                    cmd.Parameters.AddWithValue("@SMonth", paymentperiode);
                    cmd.Parameters.AddWithValue("@SAmt", AmountTb.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fees SuccessFully paid");
                }
                Con.Close();
                DisplayFees();
                Reset();
            }


        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StdIdCb_SelectionChangeCommitted(object sender, EventArgs e)
        {
            GetStudName();
        }

        private void AmountTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            MainMenu Obj = new MainMenu(); 
            Obj.Show();
            this .Hide();
        }
    }
}
