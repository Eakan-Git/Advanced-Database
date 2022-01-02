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
    public partial class OrderForCustomerForm : Form
    {
        SqlConnection connection;
        SqlDataAdapter adapter = new SqlDataAdapter();
        string str = @"Data Source=(local);Initial Catalog=Hoayeuthuong;Integrated Security=True";
        string ID;
        int totalPrice;
        const int fastFee = 50000;
        public OrderForCustomerForm()
        {
            InitializeComponent();
            connection = new SqlConnection(str);
            connection.Open();

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
