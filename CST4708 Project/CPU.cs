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

namespace CST4708_Project
{
    public partial class CPU : Form
    {
        SqlConnection myconn;
        SqlDataAdapter myadapter = new SqlDataAdapter();
        SqlCommand incmd = new SqlCommand();

        public CPU()
        {
            InitializeComponent();
        }

        private void CPU_Load(object sender, EventArgs e)
        {
            myconn = new SqlConnection();
            myconn.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Hookg\\Downloads\\CST4708Project-master\\CST4708Project-master\\FinalProjectDB.mdf;Integrated Security=True;Connect Timeout=30";
            myconn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter("Select * from Item where ItemCategory = 'CPU'", myconn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;

            label1.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            label2.Text = dataGridView1.Rows[1].Cells[1].Value.ToString();
            label3.Text = dataGridView1.Rows[2].Cells[1].Value.ToString();
            label4.Text = dataGridView1.Rows[3].Cells[1].Value.ToString();

            label5.Text = "$" + dataGridView1.Rows[0].Cells[3].Value.ToString();
            label6.Text = "$" + dataGridView1.Rows[1].Cells[3].Value.ToString();
            label7.Text = "$" + dataGridView1.Rows[2].Cells[3].Value.ToString();
            label8.Text = "$" + dataGridView1.Rows[3].Cells[3].Value.ToString();

        }

    }

    internal class dataGridView1
    {
    }
}
