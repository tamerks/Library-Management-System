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
    public partial class LoginMember : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=PC;Initial Catalog=MyVisualLibrary;Integrated Security=True");
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;
        
        public LoginMember()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();                
                com.Connection = con;
                com.CommandText = "Select * From dbo.MEMBER where MEMBER_NICKNAME='" + textBox1.Text +
                                    "'And MEMBER_PASSWORD='" + textBox2.Text + "'";
            }
            catch (SqlException ex)
            {
                throw new Exception(ex.Message + "Something went wrong with database");
            }

            dr = com.ExecuteReader();

            if (dr.Read())
            {
                MessageBox.Show("Successfull");
                Borrow borrow = new Borrow();
                this.Hide();
                borrow.ShowDialog();               
            }

            else
                MessageBox.Show("Wrong password or nickname!!");
            con.Close();
        }
    }
}
