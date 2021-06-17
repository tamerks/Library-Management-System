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
    public partial class Author : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=PC;Initial Catalog=MyVisualLibrary;Integrated Security=True");
        SqlCommand com = new SqlCommand();

        public Author()
        {
            InitializeComponent();
        }

        //add author
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (isEmpty() == 0)
            {
                string autName = textBox1.Text;
                string autSurName = textBox2.Text;
                try
                {
                    con.Open();
                    com.Connection = con;
                    com.CommandText = "insert into dbo.AUTHOR(AUTHOR_NAME,AUTHOR_SURNAME) values(@param1,@param2)";
                    com.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = autName;
                    com.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = autSurName;
                    com.CommandType = CommandType.Text;
                    com.ExecuteNonQuery();
                    MessageBox.Show("Author was added successfully...");
                    con.Close();
                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }
            }

        }

        //search author
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "Select * From dbo.AUTHOR where AUTHOR_NAME='" + textBox1.Text + "'";
                SqlDataAdapter da = new SqlDataAdapter(com.CommandText, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                //dr2 = com.ExecuteReader();
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
            txtAutID.Text = row.Cells[0].Value.ToString(); //Get data's ID from database to this unvisible textbox          
            textBox1.Text = row.Cells[1].Value.ToString();
            textBox2.Text = row.Cells[2].Value.ToString();

        }

        //update author
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isEmpty() == 0)
            {
                try
                {
                    con.Open();
                    com.Connection = con;
                    com.CommandText = "update dbo.AUTHOR set AUTHOR_NAME = '" + textBox1.Text + "', AUTHOR_SURNAME = '" + textBox2.Text + "' where AUTHOR_ID ='" + txtAutID.Text + "'";
                    com.ExecuteNonQuery();
                    MessageBox.Show("Author was updated successfully...");

                }
                catch (SqlException ex)
                {

                    throw new Exception(ex.Message);
                }
                con.Close();
            }
        }

        private int isEmpty()
        {
            int flag = 0;
            if (textBox1.Text == "" || textBox2.Text == "" || textBox1.Text == string.Empty || textBox2.Text == string.Empty)
            {
                flag = 1;
                MessageBox.Show("There are empty fields.Please fill in the blank properties!!");
            }
            return flag;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "delete from dbo.AUTHOR where AUTHOR_ID ='" + txtAutID.Text + "'";
                com.ExecuteNonQuery();
                MessageBox.Show("Author was deleted successfully...");
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
            con.Close();
        }
    }
}
