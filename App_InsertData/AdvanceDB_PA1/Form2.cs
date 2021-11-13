using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace AdvanceDB_PA1
{
    public partial class Form2 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        //Place this bellow str to comment
        string str = @"Data Source=Eakan;Initial Catalog=csdlnc_pa1;Integrated Security=True";
        string placeholder = "Nhập mã đơn hàng...";
        //Uncomment to run: @Duy
        //string str = @"Data Source=DUY-LAPTOP\SQLEXPRESS;Initial Catalog=csdlnc_pa1;Integrated Security=True";
        private int offset;
        const int maxRowsPerPage = 10;
        public Form2()
        {
            InitializeComponent();
            offset = 0;
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
            textBox1.Text = placeholder;
        }
        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select* from HOADON order by MaHD offset " + Convert.ToString(offset) + 
                " rows fetch next " + Convert.ToString(maxRowsPerPage) + "rows only";

            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
            if(offset <= 0)
            {
                btnPrevious.Enabled = false;
            }
        }
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            offset -= 10;
            if (offset <= 0)
            {
                offset = 0;
            }
            loadData();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnPrevious.Enabled = true;
            offset += 10;
            try
            {
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void search()
        {
            command = connection.CreateCommand();
            command.CommandText = "select* from HOADON where MaHD = @MaHD";
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@MaHD", textBox1.Text);
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Hãy nhập mã đơn hàng");
            }
            try
            {
                search();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == placeholder)
                textBox1.Text = "";
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
                textBox1.Text = placeholder;
        }
    }
}
