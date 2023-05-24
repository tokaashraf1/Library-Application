using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_System
{
    public partial class Profile : Form
    {
        public Profile()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection SqlConnection = new SqlConnection("Data Source=DESKTOP-GPVHL6N;Initial Catalog=final;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SqlConnection;
            SqlConnection.Open();
            sqlCommand.CommandText = "UPDATE reader SET fname = '" + textBox1.Text + "' , lname='" + textBox2.Text + "' , gender='" + textBox3.Text + "' , password='" + textBox5.Text + "' , userName='" + textBox6.Text + "' WHERE email = '" + textBox4.Text + "'";
            sqlCommand.ExecuteNonQuery();
            SqlConnection.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection SqlConnection = new SqlConnection("Data Source=DESKTOP-GPVHL6N;Initial Catalog=final;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SqlConnection;
            SqlConnection.Open();
            sqlCommand.CommandText = "UPDATE Admin_ SET fname = '" + textBox1.Text + "' , lname='" + textBox2.Text + "' , gender='" + textBox3.Text + "' , password='" + textBox5.Text + "' , userName='" + textBox6.Text + "' WHERE email = '" + textBox4.Text + "'";
            sqlCommand.ExecuteNonQuery();
            SqlConnection.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection SqlConnection = new SqlConnection("Data Source=DESKTOP-GPVHL6N;Initial Catalog=final;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SqlConnection;
            SqlConnection.Open();
            sqlCommand.CommandText = "UPDATE author SET fname = '" + textBox1.Text + "' , lname='" + textBox2.Text + "' , gender='" + textBox3.Text + "' , password='" + textBox5.Text + "' , userName='" + textBox6.Text + "', num_upload_books='" + textBox7.Text +  "'WHERE email = '" + textBox4.Text + "'";
            sqlCommand.ExecuteNonQuery();
            SqlConnection.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection SqlConnection = new SqlConnection("Data Source=DESKTOP-GPVHL6N;Initial Catalog=final;Integrated Security=True");
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = SqlConnection;
            SqlConnection.Open();
            sqlCommand.CommandText = "UPDATE publisher SET fname = '" + textBox1.Text + "' , lname='" + textBox2.Text + "' , gender='" + textBox3.Text + "' , password='" + textBox5.Text + "' , userName='" + textBox6.Text + "' WHERE email = '" + textBox4.Text + "'";
            sqlCommand.ExecuteNonQuery();
            SqlConnection.Close();
        }

        private void Profile_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
