using System;
using System.Data;
using System.Data.SqlClient;
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
            SqlCommand comIns = new SqlCommand("exec dbo.SP_Product_Insert '" + int.Parse(textBox1.Text) + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + status + "','" + DateTime.Parse(dateTimePicker1.Text) + "'", con);
            comIns.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Saved");
            LoadAllProducts();

        }

        void LoadAllProducts()
        {
            SqlCommand comView = new SqlCommand("exec dbo.SP_Product_View", con);
            SqlDataAdapter da = new SqlDataAdapter(comView);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadAllProducts();
        }

        private void button2_Click(object sender, EventArgs e)
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
            SqlCommand comUp = new SqlCommand("exec dbo.SP_Product_Update '" + int.Parse(textBox1.Text) + "','" + textBox2.Text + "','" + comboBox1.Text + "','" + status + "','" + DateTime.Parse(dateTimePicker1.Text) + "'", con);
            comUp.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Updated");
            LoadAllProducts();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand comUp = new SqlCommand("exec dbo.SP_Product_Delete'" + int.Parse(textBox1.Text) + "'", con);
            comUp.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Successfully Deleted");
            LoadAllProducts();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form22 form = new Form22();
            form.ShowDialog();

        }
    }
}
