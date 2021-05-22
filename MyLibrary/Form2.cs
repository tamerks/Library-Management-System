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
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlCommand com;

        public Form2()
        {
            InitializeComponent();

            con = new SqlConnection(@"Data Source=PC;Initial Catalog=MyVisualLibrary;Integrated Security=True");
            com = new SqlCommand();
            try
            {
                con.Open();
                Console.WriteLine("Database connected!");


            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message + "here");
            }
            com.Connection = con;            

        }       

        private void page11_Load(object sender, EventArgs e)
        {

        }

        //book
        private void button1_Click(object sender, EventArgs e)
        {
            page11.BringToFront();
        }

        //publisher
        private void button2_Click(object sender, EventArgs e)
        {
            page31.BringToFront();
        }

        //author
        private void button3_Click(object sender, EventArgs e)
        {
            page21.BringToFront();
        }

    }
}
