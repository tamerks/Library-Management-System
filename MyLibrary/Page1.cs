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
        SqlCommand com = new SqlCommand();
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
            if (isEmpty() == 0)
            {
                string BookName = txtBook.Text;
                int PageCount = Convert.ToInt32(txtPageCount.Text);
                string category = comboxCategory.Text;
                string AutName = txtAutName.Text;
                string AutSurname = txtAutSurname.Text;
                int numISBN = Convert.ToInt32(txtISBN.Text);
                string language = (string)comboxLan.SelectedItem;

                try
                {

                    con.Open();
                    //Control whether the book was added before or not
                    bool hasRow = false;
                    using (SqlCommand check_book_name = new SqlCommand("select BOOK_NAME from dbo.BOOK where BOOK_NAME ='" + BookName + "'", con))
                    using (SqlDataReader reader = check_book_name.ExecuteReader())
                    {
                        hasRow = reader.HasRows;
                    }//If there is a book in exact name
                    if (hasRow == true)
                    {
                        MessageBox.Show("The book was added before !!!");
                    }
                    else//If there is not book like entered book name
                    {
                        //Check if author was on in database or not.If not,add to the database as a new author
                        bool hasRow2 = false;
                        using (SqlCommand check_author_name = new SqlCommand("select AUTHOR_NAME,AUTHOR_SURNAME from dbo.AUTHOR where AUTHOR_NAME='" + AutName + "' and AUTHOR_SURNAME = '" + AutSurname + "'", con))
                        using (SqlDataReader reader = check_author_name.ExecuteReader())
                        {
                            hasRow2 = reader.HasRows;
                        }
                        if (hasRow2 == false)
                        {
                            SqlCommand com2 = new SqlCommand("insert into dbo.AUTHOR(AUTHOR_NAME,AUTHOR_SURNAME) values ('" + AutName + "', '" + AutSurname + "' )", con);
                            MessageBox.Show("There was not an author like that but don't be afraid.We added for you :) ");
                        }
                        com.CommandText = "insert into dbo.BOOK(BOOK_NAME, BOOK_PAGE_COUNT, CATEGORY_ID, AUTHOR_ID, BOOK_ISBN_NO, LANGUAGE)" +
                                                "values(@param1, @param2, (select dbo.CATEGORY.CATEGORY_ID from dbo.CATEGORY where CATEGORY_NAME = '" + category + "')," +
                                                "(select dbo.AUTHOR.AUTHOR_ID from dbo.AUTHOR where AUTHOR_NAME = '" + AutName + "'" +
                                                " and AUTHOR_SURNAME = '" + AutSurname + "'),'" + numISBN + "','" + language + "')";
                        com.Parameters.Add("@param1", SqlDbType.VarChar, 50).Value = BookName;
                        com.Parameters.Add("@param2", SqlDbType.Int).Value = PageCount;
                        com.Parameters.Add("@param3", SqlDbType.Int).Value = numISBN;
                        com.Parameters.Add("@param4", SqlDbType.VarChar, 10).Value = language;
                        com.CommandType = CommandType.Text;
                        com.ExecuteNonQuery();
                        MessageBox.Show("book başarıyla eklendi");
                        com.Parameters.Clear();

                    }


                }
                catch (Exception ex)
                {

                    throw new Exception(ex.Message);
                }

                con.Close();
            }                   
            

        }      

        private void comboxCategory_Click(object sender, EventArgs e)
        {            
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
            txtBookID.Text = row.Cells[0].Value.ToString();
            txtBook.Text = row.Cells[1].Value.ToString();
            txtPageCount.Text = row.Cells[2].Value.ToString();
            comboxCategory.Text = row.Cells[3].Value.ToString();
            txtAutName.Text = row.Cells[4].Value.ToString();
            txtAutSurname.Text = row.Cells[5].Value.ToString();
            txtISBN.Text = row.Cells[6].Value.ToString();
            comboxLan.Text = row.Cells[7].Value.ToString();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isEmpty() == 0)
            {
                string category = comboxCategory.Text;
                string language = (string)comboxLan.SelectedItem;

                try
                {

                    con.Open();
                    bool hasRow = false;
                    using (SqlCommand check_author_name = new SqlCommand("select AUTHOR_NAME,AUTHOR_SURNAME from dbo.AUTHOR where AUTHOR_NAME='" + txtAutName.Text + "' and AUTHOR_SURNAME = '" + txtAutSurname.Text + "'", con))
                    using (SqlDataReader reader = check_author_name.ExecuteReader())
                    {
                        hasRow = reader.HasRows;
                    }

                    if (hasRow == false)
                    {
                        com.Connection = con;
                        com.CommandText = "insert into dbo.AUTHOR(AUTHOR_NAME,AUTHOR_SURNAME) values ('" + txtAutName.Text + "', '" + txtAutSurname.Text + "' )";
                        com.ExecuteNonQuery();
                        MessageBox.Show("There was not an author like that but don't be afraid.We added for you :) ");
                    }
                    System.Threading.Thread.Sleep(120);
                    com.Connection = con;
                    com.CommandText = "update dbo.BOOK set  BOOK_NAME = '" + txtBook.Text + "',BOOK_PAGE_COUNT = '" + txtPageCount.Text + "',CATEGORY_ID = (select c.CATEGORY_ID from dbo.CATEGORY as c where c.CATEGORY_NAME = '" + category + "')," +
                        "AUTHOR_ID = (select a.AUTHOR_ID from dbo.AUTHOR as a where a.AUTHOR_NAME = '" + txtAutName.Text + "'and a.AUTHOR_SURNAME = '" + txtAutSurname.Text + "'),BOOK_ISBN_NO = '" + txtISBN.Text + "',LANGUAGE = '" + language + "'" +
                        "From dbo.BOOK as b where BOOK_ID = '" + txtBookID.Text + "'";
                    com.ExecuteNonQuery();
                    MessageBox.Show("Book was added successfully...");


                }
                catch (SqlException ex)
                {
                    throw new Exception(ex.Message);
                }

                con.Close();
            }         
            
        }

        //search        
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();             
                com.Connection = con;
                com.CommandText = @"select BOOK_ID,BOOK_NAME,BOOK_PAGE_COUNT,CATEGORY_NAME,AUTHOR_NAME,AUTHOR_SURNAME,BOOK_ISBN_NO,LANGUAGE from dbo.BOOK as b 
                                    inner join dbo.AUTHOR as a on b.AUTHOR_ID = a.AUTHOR_ID
                                    inner join dbo.CATEGORY as c on b.CATEGORY_ID = c.CATEGORY_ID
                                    where b.BOOK_NAME ='"+ txtBook.Text +"'";
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
        
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                com.Connection = con;
                com.CommandText = "delete from dbo.BOOK where BOOK_ID='" + txtBookID.Text + "'";
                com.ExecuteNonQuery();
                MessageBox.Show("The book was deleted successfully...");
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
            con.Close();
        }

        private int isEmpty()
        {
            int flag = 0;

            if (txtBook.Text == "" || txtAutName.Text == "" || txtAutSurname.Text == "" || txtISBN.Text == "" || txtPageCount.Text == "" || txtISBN.Text == "" ||
               txtBook.Text == string.Empty || txtAutName.Text == string.Empty || txtAutSurname.Text == string.Empty || txtISBN.Text == string.Empty || txtPageCount.Text == string.Empty || txtISBN.Text == string.Empty)
            {
                flag = 1;
                MessageBox.Show("There are empty fields.Please fill in the blank properties!!");                
            }
            
            return flag;
        }

    }
}
