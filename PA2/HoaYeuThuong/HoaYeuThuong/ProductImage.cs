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
    public partial class ProductImage : Form
    {
        SqlConnection connection;
        SqlDataAdapter adapter = new SqlDataAdapter();
        string str = @"Data Source=(local);Initial Catalog=Hoayeuthuong;Integrated Security=True";
        int ID;
        public ProductImage(int _ID)
        {
            InitializeComponent();
            connection = new SqlConnection(str);
            connection.Open();
            ID = _ID;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ProductImage_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("exec xemThongTinSanPham @ID", connection);
            cmd.Parameters.AddWithValue("@ID", ID);
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            byte[] imgData = (byte[])dt.Rows[0][5];
            MemoryStream ms = new MemoryStream(imgData);
            Image img = Image.FromStream(ms);
            pic.Image = img;
        }
    }
}
