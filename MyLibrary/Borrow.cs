using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MyLibrary
{
    public partial class Borrow : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=PC;Initial Catalog=MyVisualLibrary;Integrated Security=True");
        SqlCommand com = new SqlCommand();

        public Borrow()
        {
            InitializeComponent();
            using (SqlCommand member_id = new SqlCommand("select MEMBER_ID from dbo.MEMBER where MEMBER_NICKNAME ='" + + "'", con))
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txtBookID.Text = row.Cells[0].Value.ToString(); //Get data's ID from database to this unvisible textbox        

        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = @"insert into dbo.BORROW(MEMBER_ID,BOOK_ID) values (@param1,@param2)";
                com.Parameters.Add("@param2", SqlDbType.Int).Value = txtBookID.Text;
                com.Parameters.Add("@param2", SqlDbType.Int).Value = txtBookID.Text;
                com.ExecuteReader();
                MessageBox.Show("kitap alındı");
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            con.Close();
        }
        
        private void btnViewBooks_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = @"select * from dbo.BOOK";
                SqlDataAdapter da = new SqlDataAdapter(com.CommandText, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message);
            }
            con.Close();
        }

        private void Borrow_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
