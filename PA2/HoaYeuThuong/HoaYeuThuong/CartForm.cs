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
using System.IO;

namespace HoaYeuThuong
{
    public partial class CartForm : Form
    {
        SqlConnection connection;
        SqlDataAdapter adapter = new SqlDataAdapter();
        string str = @"Data Source=(local);Initial Catalog=Hoayeuthuong;Integrated Security=True";
        int offset;
        string ID;
        public CartForm(string _ID)
        {
            InitializeComponent();
            ID = _ID;
            connection = new SqlConnection(str);
            connection.Open();
        }
        private void loadProductList()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("exec KH_XemChiTiet_GH @ID", connection);
            cmd.Parameters.AddWithValue("@ID", ID);
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            productDGV.DataSource = dt;
        }
        private void CartForm_Load(object sender, EventArgs e)
        {
            loadProductList();
        }
    }
}
