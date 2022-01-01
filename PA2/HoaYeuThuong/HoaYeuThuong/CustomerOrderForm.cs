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

namespace HoaYeuThuong
{
    public partial class CustomerOrderForm : Form
    {
        SqlConnection connection;
        SqlDataAdapter adapter = new SqlDataAdapter();
        string str = @"Data Source=(local);Initial Catalog=Hoayeuthuong;Integrated Security=True";
        string ID;
        public CustomerOrderForm(string _ID)
        {
            InitializeComponent();
            connection = new SqlConnection(str);
            connection.Open();
            ID = _ID;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }

        private void loadOrderList()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("exec KH_XemDanhSach_DH @ID", connection);
            cmd.Parameters.AddWithValue("@ID", ID);
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            orderDGV.DataSource = dt;
        }
        private void CustomerOrderForm_Load(object sender, EventArgs e)
        {
            loadOrderList();
        }
        private void loadDetailedOrder()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("exec KH_Xem_DH @ID", connection);
            cmd.Parameters.AddWithValue("@ID", orderDGV.SelectedRows[0].Cells[0].Value.ToString());
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            //nameFrom.Text = dt.Columns["TEN_DAT"].ToString();
        }
        private void orderDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            loadDetailedOrder();
        }
    }
}
