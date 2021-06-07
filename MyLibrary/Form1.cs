using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace MyLibrary
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=PC;Initial Catalog=MyVisualLibrary;Integrated Security=True");
        SqlDataReader dr;
        SqlCommand com;
        public Form1()
        {
            InitializeComponent();
        }                

        private void button1_Click(object sender, EventArgs e)
        {
             string user = txtUserName.Text;
             string password = txtPassword.Text;

            /* com = new SqlCommand();
             try
             {
                 con.Open();
                 Console.WriteLine("Database connected!");
                 com.Connection = con;
                 com.CommandText = "Select*From dbo.USERS where USER_NAME='" + txtUserName.Text +
                                     "'And USER_PASSWORD='" + txtPassword.Text + "'";
             }
             catch (SqlException ex)
             {

                 throw new Exception(ex.Message + "here");
             }

             dr = com.ExecuteReader();

             if (dr.Read())
             {
                 MessageBox.Show("başarılı");
                 Form2 form = new Form2();
                 form.Show();
                 this.Hide();
             }

             else
                 MessageBox.Show("hatalı giriş");

             con.Close();   */    
            Form2 form = new Form2();
            //this.Hide();
            form.ShowDialog();
            

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
