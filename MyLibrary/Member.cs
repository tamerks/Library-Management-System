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
    public partial class Member : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=PC;Initial Catalog=MyVisualLibrary;Integrated Security=True");
        SqlCommand com = new SqlCommand();

        public Member()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            con.Open();
            bool hasRow = false;
            using (SqlCommand check_book_name = new SqlCommand("select MEMBER_NICKNAME from dbo.MEMBER where MEMBER_NICKNAME ='" + txtMemberName.Text + "'", con))
            using (SqlDataReader reader = check_book_name.ExecuteReader())
            {
                hasRow = reader.HasRows;
            }//If there is a nickname in exact name
            if (hasRow == true)
            {
                MessageBox.Show("The nickname was taken before !!!");
            }
            else
            {
                try
                {
                    com.Connection = con;
                    com.CommandText = "insert into dbo.MEMBER(MEMBER_NICKNAME,MEMBER_PASSWORD) values(@param1,@param2)";
                    com.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = txtMemberName.Text;
                    com.Parameters.Add("@param2", SqlDbType.VarChar, 20).Value = txtPassword.Text;
                    com.CommandType = CommandType.Text;
                    com.ExecuteNonQuery();
                    MessageBox.Show("Member was added successfully...");
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }                
            }
            con.Close();
        }
    }
}
