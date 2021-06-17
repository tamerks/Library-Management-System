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
    public partial class Personel : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=PC;Initial Catalog=MyVisualLibrary;Integrated Security=True");
        SqlCommand com = new SqlCommand();
        SqlDataReader dr, dr2;

        public Personel()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if(isEmpty() == 0)
            {
                try
                {
                    con.Open();
                    com.Connection = con;
                    com.CommandText = "insert into dbo.PERSONEL(PERSONEL_NAME,PERSONEL_SURNAME,PERSONEL_GENDER,PERSONEL_ADDRESS,PERSONEL_PHONE_NUMBER) values(@param1,@param2,@param3,@param4,@param5)";
                    com.Parameters.Add("@param1", SqlDbType.NVarChar, 50).Value = txtName.Text;
                    com.Parameters.Add("@param2", SqlDbType.NVarChar, 50).Value = txtSurname.Text;
                    com.Parameters.Add("@param3", SqlDbType.NVarChar, 10).Value = comboGender.Text;
                    com.Parameters.Add("@param4", SqlDbType.NVarChar, 200).Value = txtAddress.Text;
                    com.Parameters.Add("@param5", SqlDbType.Int).Value = txtPhoneNumber.Text;
                    com.CommandType = CommandType.Text;
                    com.ExecuteNonQuery();
                    MessageBox.Show("Personel was added successfully...");
                    con.Close();
                }
                catch (SqlException ex)
                {

                    throw new Exception (ex.Message);
                }

                con.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (isEmpty() == 0)
            {
                try
                {
                    con.Open();
                    com.Connection = con;
                    com.CommandText = "update dbo.PERSONEL set PERSONEL_NAME = '"+ txtName.Text +"', PERSONEL_SURNAME = '"+ txtSurname.Text +"', PERSONEL_GENDER = '"+comboGender.Text+"', " +
                                        "PERSONEL_ADDRESS = '"+txtAddress.Text+"', PERSONEL_PHONE_NUMBER = '"+txtPhoneNumber.Text+"' where PERSONEL_ID = '"+ txtPersonelID.Text +"'";
                    com.ExecuteNonQuery();
                    MessageBox.Show("Personel was updated successfully...");

                }
                catch (SqlException ex)
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
                com.CommandText = "Select * From dbo.PERSONEL where PERSONEL_NAME ='" + txtName.Text + "'";
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
                com.CommandText = "delete from dbo.PERSONEL where PERSONEL_ID ='" + txtPersonelID.Text + "'";
                com.ExecuteNonQuery();
                MessageBox.Show("Personel was deleted successfully...");
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
            txtPersonelID.Text = row.Cells[0].Value.ToString(); //Get data's ID from database to this unvisible textbox          
            txtName.Text = row.Cells[1].Value.ToString();
            txtSurname.Text = row.Cells[2].Value.ToString();
            comboGender.Text = row.Cells[3].Value.ToString();
            txtAddress.Text = row.Cells[4].Value.ToString();
            txtPhoneNumber.Text = row.Cells[5].Value.ToString();

        }

        private int isEmpty()
        {
            int flag = 0;

            if (txtName.Text == "" || txtSurname.Text == "" || txtPhoneNumber.Text == "" || txtAddress.Text == "" || comboGender.Text == "" ||
               txtName.Text == string.Empty || txtSurname.Text == string.Empty || txtPhoneNumber.Text == string.Empty || txtAddress.Text == string.Empty || comboGender.Text == string.Empty)
            {
                flag = 1;
                MessageBox.Show("There are empty fields.Please fill in the blank properties!!");
            }

            return flag;
        }
    }
}
