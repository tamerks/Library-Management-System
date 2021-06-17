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
    public partial class Publisher : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=PC;Initial Catalog=MyVisualLibrary;Integrated Security=True");
        SqlCommand com = new SqlCommand();

        public Publisher()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isEmpty() == 0)
            {
                string pubName = textBox1.Text;
                string pubAdress = textBox2.Text;
                int pubNum = Convert.ToInt32(textBox3.Text);
                try
                {
                    con.Open();
                    com.Connection = con;
                    com.CommandText = "insert into dbo.PUBLISHER(PUBLISHER_NAME,PUBLISHER_ADRESS,PUBLISHER_PHONE) values(@param1,@param2,@param3)";
                    com.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = pubName;
                    com.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = pubAdress;
                    com.Parameters.Add("@param3", SqlDbType.Int).Value = pubNum;
                    com.CommandType = CommandType.Text;
                    com.ExecuteNonQuery();
                    MessageBox.Show("Publisher was added successfully...");
                    com.Parameters.Clear();
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }

                con.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "Select * From dbo.PUBLISHER where PUBLISHER_NAME='" + textBox1.Text + "'";
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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isEmpty() == 0)
            {
                try
                {
                    con.Open();
                    com.Connection = con;
                    com.CommandText = "update dbo.PUBLISHER set PUBLISHER_NAME ='" + textBox1.Text + "' ,PUBLISHER_ADRESS = '" + textBox2.Text + "', PUBLISHER_PHONE ='" + textBox3.Text + "' where PUBLISHER_ID ='" + txtPublisherID.Text + "'";
                    com.ExecuteNonQuery();
                    MessageBox.Show("Publisher was updated successfully...");
                    con.Close();
                }
                catch (SqlException ex)
                {

                    throw new Exception(ex.Message);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "delete from dbo.PUBLISHER where PUBLISHER_ID ='" + txtPublisherID.Text + "'";
                com.ExecuteNonQuery();
                MessageBox.Show("Publisher was deleted successfully...");
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
            con.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txtPublisherID.Text = row.Cells[0].Value.ToString();
            textBox1.Text = row.Cells[1].Value.ToString();
            textBox2.Text = row.Cells[2].Value.ToString();
            textBox3.Text = row.Cells[3].Value.ToString();
        }

        private int isEmpty()
        {
            int flag = 0;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox1.Text == string.Empty || textBox2.Text == string.Empty || textBox3.Text == string.Empty)
            {
                flag = 1;
                MessageBox.Show("There are empty fields.Please fill in the blank properties!!");
            }
            return flag;
        }
    }
}
