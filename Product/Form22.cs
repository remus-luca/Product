using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Product
{
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=DESKTOP-MK5GMMO\\SQLEXPRESS;Initial Catalog=Product_SP_DB;Integrated Security=True");

        private void Form22_Load(object sender, EventArgs e)
        {
            LoadAllProducts();
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
            dataGridView2.DataSource = dt;

        }
       

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}

