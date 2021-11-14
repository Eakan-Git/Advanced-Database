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
        DataTable tableHD = new DataTable();
        DataTable tableCTHD = new DataTable();
        //Place this bellow str to comment
        string str = @"Data Source=(local);Initial Catalog=csdlnc_pa1;Integrated Security=True";
        //string str = @"Data Source=Eakan;Initial Catalog=csdlnc_pa1;Integrated Security=True";
        //Uncomment to run: @Duy
        //string str = @"Data Source=DUY-LAPTOP\SQLEXPRESS;Initial Catalog=csdlnc_pa1;Integrated Security=True";

        void loadDataHD()
        {
            try
            {
                //connection.Open();
                command = connection.CreateCommand();
                command.CommandText = "select HOADON.MaHD, HOADON.MaKH, HOADON.NgayLap, HOADON.TongTien" +
                    " from HOADON where HOADON.MaHD = @MaHD";
                // "select* from HOADON join CT_HOADON on HOADON.MaHD = CT_HOADON.MaHD and HOADON.MaHD = @MaHD";
                command.CommandType = CommandType.Text;
                command.Parameters.AddWithValue("@MaHD", tbMaHD.Text);
                adapter.SelectCommand = command;
                //connection.Close();
                tableHD.Clear();
                adapter.Fill(tableHD);
                dataGridView1.DataSource = tableHD;
                loadDataCTHD();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            };
        }
        private void autoLoadHD(object sender, EventArgs e)
        {
            if(tbMaHD.Text != "")
            {
                try
                {
                    //connection.Open();
                    command = connection.CreateCommand();
                    command.CommandText = "select HOADON.MaHD, HOADON.MaKH, HOADON.NgayLap, HOADON.TongTien" +
                        " from HOADON where HOADON.MaHD = @MaHD";
                    // "select* from HOADON join CT_HOADON on HOADON.MaHD = CT_HOADON.MaHD and HOADON.MaHD = @MaHD";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@MaHD", tbMaHD.Text);
                    adapter.SelectCommand = command;
                    //connection.Close();
                    tableHD.Clear();
                    adapter.Fill(tableHD);
                    dataGridView1.DataSource = tableHD;
                    tbMaKH.Text = tableHD.Rows[0].ItemArray[1].ToString();
                    dateTimePicker1.Text = tableHD.Rows[0].ItemArray[2].ToString();
                    loadDataCTHD();
                }
                catch(Exception ex)
                {
                    //MessageBox.Show(ex.Message);
                }
            }
        }
        //private void autoLoadCTHD()
        //{
        //    try
        //    {
        //        //connection.Open();
        //        command = connection.CreateCommand();
        //        command.CommandText = "select MaSp, SoLuong, GiaBan, GiaGiam, ThanhTien" +
        //            " from CT_HOADON where MaHD = @MaHD";
        //        // "select* from HOADON join CT_HOADON on HOADON.MaHD = CT_HOADON.MaHD and HOADON.MaHD = @MaHD";
        //        command.CommandType = CommandType.Text;
        //        command.Parameters.AddWithValue("@MaHD", tbMaHD.Text);
        //        adapter.SelectCommand = command;
        //        //connection.Close();
        //        tableCTHD.Clear();
        //        adapter.Fill(tableCTHD);
        //        dataGridView2.DataSource = tableCTHD;
        //    }
        //    catch (Exception ex) { };
        //}
        void loadDataCTHD()
        {
            //connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "select MaSp, SoLuong, GiaBan, GiaGiam, ThanhTien" +
                " from CT_HOADON where MaHD = @MaHD";
            // "select* from HOADON join CT_HOADON on HOADON.MaHD = CT_HOADON.MaHD and HOADON.MaHD = @MaHD";
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@MaHD", tbMaHD.Text);
            adapter.SelectCommand = command;
            //connection.Close();
            tableCTHD.Clear();
            adapter.Fill(tableCTHD);

            dataGridView2.DataSource = tableCTHD;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            //loadData();
        }
        private void btnHD_Click(object sender, EventArgs e)
        {
            String str = "";
            //connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "insert into HOADON(MaHD,MaKH,NgayLap) values (@MaHD, @MaKH, @NgayLap)";
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@MaHD", tbMaHD.Text);
            command.Parameters.AddWithValue("@MaKH", tbMaKH.Text);
            command.Parameters.AddWithValue("@NgayLap", dateTimePicker1.Text);
            if (tbMaHD.Text == str || tbMaKH.Text == str)
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin đơn hàng!");
            }
            else
            {
                try
                {
                    command.ExecuteNonQuery();
                    loadDataHD();
                    MessageBox.Show("Thêm Đơn Hàng Thành Công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //connection.Close();
        }

        private void btnCTDH_Click(object sender, EventArgs e)
        {
            String str = "";
            //connection.Open();
            command = connection.CreateCommand();
            command.CommandText = "insert into CT_HOADON(MaHD,MaSP,SoLuong,GiaBan,GiaGiam) values (@MaHD, @MaSP, @SoLuong, @GiaBan, @GiaGiam)";
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@MaHD", tbMaHD.Text);
            command.Parameters.AddWithValue("@MaSP", tbMaSP.Text);
            command.Parameters.AddWithValue("@SoLuong", tbSoLuong.Text);
            command.Parameters.AddWithValue("@GiaBan", tbGiaBan.Text);
            command.Parameters.AddWithValue("@GiaGiam", tbGiaGiam.Text);
            if (tbMaHD.Text == str || tbMaKH.Text == str || tbMaSP.Text == str || tbSoLuong.Text == str || tbGiaBan.Text == str || tbGiaGiam.Text == str)
            {
                MessageBox.Show("Hãy điền đầy đủ thông tin!");
            }
            else
            {
                try
                {
                    command.ExecuteNonQuery();
                    loadDataCTHD();
                    loadDataHD();
                    MessageBox.Show("Thêm Chi Tiết Đơn Hàng Thành Công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            //connection.Close();
        }
    }
}
