using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MyLibrary
{
    public partial class Page3 : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=PC;Initial Catalog=MyVisualLibrary;Integrated Security=True");
        SqlCommand com;

        public Page3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pubName = textBox1.Text;
            string pubAdress = textBox2.Text;
            int pubNum = Convert.ToInt32(textBox3.Text);
            try
            {
                con.Open();
                com.CommandText = "insert into dbo.PUBLISHER(PUBLISHER_NAME,PUBLISHER_ADRESS,PUBLISHER_PHONE) values(@param1,@param2,@param3)";
                com.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = pubName;
                com.Parameters.Add("@param2", SqlDbType.VarChar, 50).Value = pubAdress;
                com.Parameters.Add("@param3", SqlDbType.VarChar, 50).Value = pubNum;
                com.CommandType = CommandType.Text;
                com.ExecuteNonQuery();
                MessageBox.Show("publisher başarıyla eklendi");
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
                com.CommandText = "Select PUBLISHER_NAME,PUBLISHER_ADRESS,PUBLISHER_PHONE From dbo.PUBLISHER where PUBLISHER_NAME='" + textBox1.Text + "'";
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
