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

namespace AdvanceDB_PA1
{
    
    public partial class Form1 : Form
    {
        SqlConnection connection ;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        string str = @"Data Source=DUY-LAPTOP\SQLEXPRESS;Initial Catalog=csdlnc_pa1;Integrated Security=True";


        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select* from HOADON join CT_HOADON on HOADON.MaHD = CT_HOADON.MaHD and HOADON.MaHD='" + textBox1.Text + "'" ;
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }



        public Form1()
        {
            InitializeComponent();
   
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();

        }
        private void button2_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "insert into HOADON(MaHD,MaKH,NgayLap) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "')";
            command.ExecuteNonQuery();
            command.CommandText = "insert into CT_HOADON(MaHD,MaSP,SoLuong,GiaBan,GiaGiam) values ('" + textBox1.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "')";
            command.ExecuteNonQuery();
            loadData();
        }
    }
}
