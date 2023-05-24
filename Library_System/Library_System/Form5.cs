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

namespace Library_System
{
    public partial class Form5 : Form
    {
        string connectionstring = "Data Source=DESKTOP-GPVHL6N;Initial Catalog=final;Integrated Security=True";
        public Form5()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionstring))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDA = new SqlDataAdapter("select type,title from category join books on cat_id = book_id; ", sqlcon);
                DataTable DT = new DataTable();
                sqlDA.Fill(DT);


                dataGridView1.DataSource = DT;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm main = new MainForm();
            main.Show();
        }
    }
}
