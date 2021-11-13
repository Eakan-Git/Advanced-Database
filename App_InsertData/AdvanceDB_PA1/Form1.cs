using System;
using System.Data;
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
        //Place this bellow str to comment
        string str = @"Data Source=Eakan;Initial Catalog=csdlnc_pa1;Integrated Security=True";
        //Uncomment to run: @Duy
        //string str = @"Data Source=DUY-LAPTOP\SQLEXPRESS;Initial Catalog=csdlnc_pa1;Integrated Security=True";

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select* from HOADON join CT_HOADON on HOADON.MaHD = CT_HOADON.MaHD and HOADON.MaHD = @MaHD";
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@MaHD", textBox1.Text);
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
            String str = "";
            command = connection.CreateCommand();
            command.CommandText = "insert into HOADON(MaHD,MaKH,NgayLap) values (@MaHD, @MaKH, @NgayLap)";
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@MaHD", textBox1.Text);
            command.Parameters.AddWithValue("@MaKH", textBox2.Text);
            command.Parameters.AddWithValue("@NgayLap", dateTimePicker1.Text);
            if (textBox1.Text == str || textBox2.Text == str)
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin đơn hàng!");
            }
            else
            {
                try
                {
                    command.ExecuteNonQuery();
                    //loadData();
                    MessageBox.Show("Thêm Đơn Hàng Thành Công!");
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String str = "";
            command = connection.CreateCommand();
            command.CommandText = "insert into CT_HOADON(MaHD,MaSP,SoLuong,GiaBan,GiaGiam) values (@MaHD, @MaSP, @SoLuong, @GiaBan, @GiaGiam)";
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@MaHD", textBox1.Text);
            command.Parameters.AddWithValue("@MaSP", textBox4.Text);
            command.Parameters.AddWithValue("@SoLuong", textBox5.Text);
            command.Parameters.AddWithValue("@GiaBan", textBox6.Text);
            command.Parameters.AddWithValue("@GiaGiam", textBox7.Text);
            if (textBox1.Text == str || textBox2.Text == str || textBox4.Text == str || textBox5.Text == str || textBox6.Text == str || textBox7.Text == str)
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!");
            }
            else
            {
                try
                {
                    command.ExecuteNonQuery();
                    loadData();
                    MessageBox.Show("Thêm Chi Tiết Đơn Hàng Thành Công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
