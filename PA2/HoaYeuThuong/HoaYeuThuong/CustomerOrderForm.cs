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
using System.Globalization;

namespace HoaYeuThuong
{
    public partial class CustomerOrderForm : Form
    {
        CultureInfo provider = CultureInfo.InvariantCulture;
        SqlConnection connection;
        SqlDataAdapter adapter = new SqlDataAdapter();
        string str = @"Data Source=(local);Initial Catalog=Hoayeuthuong;Integrated Security=True";
        string ID;
        bool payState = false;
        public CustomerOrderForm(string _ID)
        {
            InitializeComponent();
            connection = new SqlConnection(str);
            connection.Open();
            ID = _ID;
            btnCancel.Enabled = false;
            btnPay.Enabled = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (payState)
            {
                DialogResult confirm = MessageBox.Show("Bạn muốn thanh toán bằng hình thức chuyển khoản?", "Thanh Toán Đơn Hàng", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand("update THANHTOAN set THANHTOAN_TYPE = 1 where DH_ID = @DH_ID", connection);
                    cmd.Parameters.AddWithValue("@DH_ID", orderDGV.SelectedRows[0].Cells[0].Value.ToString());
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Chuyển hình thức thanh toán thành công\nChúng tôi sẽ cập nhật thông tin sau khi nhận được chuyển khoản từ bạn");
                }
            }
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

            nameFrom.Text = "Người đặt: " + dt.Rows[0]["TEN_DAT"].ToString();
            phoneFrom.Text = "Số điện thoại: " + dt.Rows[0]["SDT_DAT"].ToString();
            addressFrom.Text = "Địa chỉ: " + dt.Rows[0]["DIACHI_DAT"].ToString();

            nameTo.Text = "Người nhận: " + dt.Rows[0]["TEN_NHAN"].ToString();
            phoneTo.Text = "Số điện thoại: " + dt.Rows[0]["SDT_NHAN"].ToString();
            addressTo.Text = "Địa chỉ: " + dt.Rows[0]["DIACHI_NHAN"].ToString();

            if (dt.Rows[0]["ANDANH"].Equals(true))
            {
                anonymous.Text = "Ẩn danh: Có";
            }
            else
            {
                anonymous.Text = "Ẩn danh: Không";
            }

            message.Text = "Lời nhắn: " + dt.Rows[0]["LOINHAN"].ToString();
            note.Text = dt.Rows[0]["NOTE"].ToString();
            if (dt.Rows[0]["XUAT_GTGT"].Equals(true))
            {
                GTGT.Text = "Xuất GTGT: Có";
            }
            else
            {
                GTGT.Text = "Xuất GTGT: Không";
                GTGT.ForeColor = Color.Black;
            }

            placedTime.Text = "Ngày đặt: " + Convert.ToDateTime(orderDGV.SelectedRows[0].Cells[3].Value).Date.ToString("MM/dd/yyyy");

            if (orderDGV.SelectedRows[0].Cells[4].Value.Equals(null))
            {
                deliveryTime.Text = "Ngày giao: " + Convert.ToDateTime(orderDGV.SelectedRows[0].Cells[4].Value).Date.ToString("MM/dd/yyyy");                
            }    
            else
            {
                deliveryTime.Text = "Không có ngày giao hàng";
            }

            status.Text = "Trạng thái: " + dt.Rows[0]["TINHTRANG"].ToString();
            extraCost.Text = "Phụ phí: " + dt.Rows[0]["PHUPHI"].ToString();
            voucher.Text = "Giảm giá: " + dt.Rows[0]["GIAGIAM"].ToString();
            total.Text = "Thành tiền: " + dt.Rows[0]["THANHTIEN"].ToString();

            nameFrom.Visible = true;
            phoneFrom.Visible = true;
            addressFrom.Visible = true;

            nameTo.Visible = true;
            phoneTo.Visible = true;
            addressTo.Visible = true;

            anonymous.Visible = true;
            message.Visible = true;
            note.Visible = true;
            GTGT.Visible = true;
            placedTime.Visible = true;
            deliveryTime.Visible = true;
            status.Visible = true;
            extraCost.Visible = true;
            voucher.Visible = true;
            total.Visible = true;

            if(orderDGV.SelectedRows[0].Cells[4].Value.Equals(null))
            {
                type.Visible = false;
                payStatus.Visible = false;
                btnCancel.Enabled = false;
                btnPay.Enabled = false;
            }    
            else
            {
                
            }    
        }
        private void orderDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                loadDetailedOrder();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
