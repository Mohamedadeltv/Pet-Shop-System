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

namespace petshopforworkers
{
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=\\Mac\Home\Desktop\petshopforworkers\petshopforworkers\testpetshop.mdf;Integrated Security=True;Connect Timeout=30");
        public Form4()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public void displaydata()
        {

            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;

            cmd.CommandText = "select * from test";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dataGridView1.DataSource=dt;     
            con.Close();
           
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            displaydata();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("you haven't entered the id");
            }
            else
            {

                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from test where id ='" + int.Parse(textBox1.Text) + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                displaydata();
                textBox1.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("you haven't entered the name");
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "select * from test where name ='" + textBox2.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);

                da.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();

                textBox2.Text = "";
            }
               
        }
    }
}
