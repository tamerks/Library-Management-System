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
    public partial class Page2 : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=PC;Initial Catalog=MyVisualLibrary;Integrated Security=True");
        SqlCommand com;

        public Page2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string autName = textBox1.Text;
            string autSurName = textBox2.Text;
            try
            {
                com = new SqlCommand();
                con.Open();
                com.Connection = con;
                com.CommandText = "insert into dbo.AUTHOR(AUTHOR_NAME,AUTHOR_SURNAME) values(@param1,@param2)";
                com.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = autName;
                com.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = autSurName;
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                MessageBox.Show("yazar başarıyla eklendi");
                con.Close();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

        }


        private void button2_Click(object sender, EventArgs e)
        {            
            try
            {
                com = new SqlCommand();
                con.Open();
                com.Connection = con;
                com.CommandText = "Select AUTHOR_NAME, AUTHOR_SURNAME From dbo.AUTHOR where AUTHOR_NAME='" + textBox1.Text + "'";
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
    }
}
