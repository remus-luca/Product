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

namespace Product
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-MK5GMMO\\SQLEXPRESS;Initial Catalog=Product_SP_DB;Integrated Security=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            string status = "";
            if (radioButton1.Checked == true)
            {
                status = radioButton1.Text;
            }
            else
            {
                status = radioButton2.Text;

            }
            SqlCommand com = new SqlCommand("exec dbo.SP_Product_Insert '"+int.Parse(textBox1.Text)+"','"+textBox2.Text+ "','" + comboBox1.Text + "','" + status+ "','" +DateTime.Parse( dateTimePicker1.Text) + "'", con);
            com.ExecuteNonQuery();
            MessageBox.Show("Successfully Saved");
        
        
        }


    }
}
