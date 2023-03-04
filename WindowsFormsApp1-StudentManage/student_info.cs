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

namespace WindowsFormsApp1_StudentManage
{
    public partial class student_info : Form
    {

        SqlConnection con=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\akila\Documents\Form1DB.mdf;Integrated Security=True;Connect Timeout=30");


        public student_info()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Table1 VALUES('"+textBox1.Text+"','"+textBox2.Text+"','"+textBox3.Text+ "','"+textBox4.Text+"')",con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Data inserted successfully");
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Table1 SET name='" + textBox2.Text + "', address= '" + textBox3.Text + "',class= '" + textBox4.Text + "' " +
                "Where id='" + textBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data updated successfully");
            con.Close();
              
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE Table1 Where id='" + textBox1.Text + "'", con);
            cmd.ExecuteNonQuery();
            MessageBox.Show("data deleted successfully");
            con.Close();
        }
    }
}
