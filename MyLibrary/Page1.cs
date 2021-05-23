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
    public partial class Page1 : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=PC;Initial Catalog=MyVisualLibrary;Integrated Security=True");
        SqlCommand com;
        SqlDataReader dr, dr2;

        public Page1()
        {
            InitializeComponent();
        }

        private void Page1_Load(object sender, EventArgs e)
        {

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string BookName = txtBook.Text;
            int PageCount = Convert.ToInt32(txtPageCount.Text);
            string category = (string)comboxCategory.SelectedItem;
            string AutName = txtAutName.Text;
            string AutSurname = txtAutSurname.Text;
            int numISBN = Convert.ToInt32(txtISBN.Text);
            string language = (string)comboxLan.SelectedItem;

            try
            {
                con.Open();
                bool hasRow = false;
                using (SqlCommand check_book_name = new SqlCommand("select BOOK_NAME from dbo.BOOK where BOOK_NAME ='" + BookName + "'", con))
                using (SqlDataReader reader = check_book_name.ExecuteReader())
                {
                    hasRow = reader.HasRows;
                }
                if (hasRow == true)
                {
                    MessageBox.Show("Test");
                }
                else
                {
                    com = new SqlCommand();
                    com.Connection = con;
                    com.CommandText = "insert into dbo.BOOK(BOOK_NAME,BOOK_PAGE_COUNT,BOOK_ISBN_NO,LANGUAGE) values(@param1,@param2,@param3,@param4)";
                    com.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = BookName;
                    com.Parameters.Add("@param2", SqlDbType.Int).Value = PageCount;
                    com.Parameters.Add("@param3", SqlDbType.Int).Value = numISBN;
                    com.Parameters.Add("@param4", SqlDbType.VarChar, 10).Value = language;
                    com.CommandType = CommandType.Text;
                    com.ExecuteNonQuery();
                    MessageBox.Show("book başarıyla eklendi");
                }

            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }

            con.Close();

        }

        private void comboxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            /* com = new SqlCommand();
             con.Open();
             com.Connection = con;
             com.CommandText = "select CATEGORY_NAME from dbo.CATEGORY";
             dr = com.ExecuteReader();

             while (dr.Read())
             {
                 comboxCategory.Items.Add(dr["CATEGORY_NAME"]);
             }

             con.Close();*/
        }

        private void comboxCategory_Click(object sender, EventArgs e)
        {
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText = "select CATEGORY_NAME from dbo.CATEGORY";
            dr = com.ExecuteReader();

            while (dr.Read())
            {
                comboxCategory.Items.Add(dr["CATEGORY_NAME"]);
            }

            dr.Close();
            con.Close();
        }

        private void comboxLan_Click(object sender, EventArgs e)
        {
            comboxLan.Items.Add("tr");
            comboxLan.Items.Add("eng");
            comboxLan.Items.Add("fr");
        }

        private void comboxAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            /*string SqlDataPull = ("select AUTHOR_NAME, AUTHOR_SURNAME from dbo.AUTHOR");
            SqlCommand cmd = new SqlCommand(SqlDataPull);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                SqlDataPull = dr[0].ToString();
                comboxLan.Items.Add(SqlDataPull);
            }

            dr.Close();   */
        }
    }
}
