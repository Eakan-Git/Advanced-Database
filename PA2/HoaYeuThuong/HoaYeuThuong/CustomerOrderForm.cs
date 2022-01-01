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
        public CustomerOrderForm()
        {
            InitializeComponent();
            connection = new SqlConnection(str);
            connection.Open();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }

        private void loadProductList()
        {

        }
        private void CustomerOrderForm_Load(object sender, EventArgs e)
        {
            loadProductList();
        }
    }
}
