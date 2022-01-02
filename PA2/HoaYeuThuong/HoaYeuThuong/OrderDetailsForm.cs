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
    public partial class OrderDetailsForm : Form
    {
        int ID_DH;
        SqlConnection connection;
        SqlDataAdapter adapter = new SqlDataAdapter();
        string str = @"Data Source=(local);Initial Catalog=Hoayeuthuong;Integrated Security=True";
        public OrderDetailsForm(int _ID_DH)
        {
            InitializeComponent();
            ID_DH = _ID_DH;
            connection = new SqlConnection(str);
            connection.Open();
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fillDetails()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("exec KH_Xem_DH @ID", connection);
            cmd.Parameters.AddWithValue("@ID", ID_DH);
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            tbNameFrom.Text = dt.Rows[0]["TEN_DAT"].ToString();
            tbPhoneFrom.Text = dt.Rows[0]["SDT_DAT"].ToString();
            tbAddressFrom.Text = dt.Rows[0]["DIACHI_DAT"].ToString();

            tbNameTo.Text = dt.Rows[0]["TEN_NHAN"].ToString();
            tbPhoneTo.Text = dt.Rows[0]["SDT_NHAN"].ToString();
            tbAddressTo.Text = dt.Rows[0]["DIACHI_NHAN"].ToString();

            if (dt.Rows[0]["ANDANH"].Equals(true))
            {
                anonymous.Checked = true;
            }
            else
            {
                anonymous.Checked = false;
            }

            tbMessage.Text = dt.Rows[0]["LOINHAN"].ToString();
            tbNote.Text = dt.Rows[0]["NOTE"].ToString();
            if (dt.Rows[0]["XUAT_GTGT"].Equals(true))
            {
                GTGT.Checked = true;
            }
            else
            {
                GTGT.Checked = false;
            }
        }
        private void OrderDetailsForm_Load(object sender, EventArgs e)
        {
            fillDetails();
        }
    }
}
