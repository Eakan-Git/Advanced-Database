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
    public partial class CustomerCreateOrderForm : Form
    {
        SqlConnection connection;
        SqlDataAdapter adapter = new SqlDataAdapter();
        string str = @"Data Source=(local);Initial Catalog=Hoayeuthuong;Integrated Security=True";
        string ID;
        int totalPrice;
        const int fastFee = 50000;
        public CustomerCreateOrderForm(string _ID, int _totalPrice)
        {
            InitializeComponent();
            connection = new SqlConnection(str);
            connection.Open();
            ID = _ID;
            totalPrice = _totalPrice;
            labelTotal.Text = "Giá: " + totalPrice.ToString() + "đ";
        }
        private void placeOrder()
        {
            SqlCommand cmd = new SqlCommand(@"exec taoDH @VOUCHER, @TK_ID, @SDT_DAT, @TEN_DAT, @DIACHI_DAT, @SDT_NHAN, @TEN_NHAN, @DIACHI_NHAN, @ANDANH, @LOINHAN, @NOTE, @GTGT, @PHUPHI, @THOIGIANDATHANG", connection);
            if (String.IsNullOrEmpty(tbVoucher.Text))
            {
                cmd.Parameters.AddWithValue("@VOUCHER", "");
            }
            else
            {
                cmd.Parameters.AddWithValue("@VOUCHER", tbVoucher.Text);
            }
            cmd.Parameters.AddWithValue("@TK_ID", ID);

            cmd.Parameters.AddWithValue("@SDT_DAT", tbPhoneFrom.Text);
            cmd.Parameters.AddWithValue("@TEN_DAT", tbNameFrom.Text);
            cmd.Parameters.AddWithValue("@DIACHI_DAT", tbAddressFrom.Text);

            cmd.Parameters.AddWithValue("@SDT_NHAN", tbPhoneTo.Text);
            cmd.Parameters.AddWithValue("@TEN_NHAN", tbNameTo.Text);
            cmd.Parameters.AddWithValue("@DIACHI_NHAN", tbAddressTo.Text);

            cmd.Parameters.AddWithValue("@ANDANH", anonymous.Checked.ToString());
            cmd.Parameters.AddWithValue("@LOINHAN", tbMessage.Text);
            cmd.Parameters.AddWithValue("@NOTE", tbNote.Text);
            cmd.Parameters.AddWithValue("@GTGT", GTGT.Checked.ToString());
            if(fastDelivery.Checked == true)
            {
                cmd.Parameters.AddWithValue("@PHUPHI", fastFee);
            }
            else
            {
                cmd.Parameters.AddWithValue("@PHUPHI", 0);
            }
            cmd.Parameters.AddWithValue("@THOIGIANDATHANG", DateTime.Now.ToString("yyyy-MM-dd"));

            cmd.ExecuteNonQuery();
            MessageBox.Show("Đặt hàng thành công.\nChúng tôi sẽ liên hệ với bạn trong thời gian sớm nhất có thể.");
            this.Close();
        }
        private bool validVoucher()
        {
            SqlCommand cmd = new SqlCommand("select VOUCHER_ID from VOUCHER where VOUCHER_MASUDUNG = @MA and VOUCHER_VALIDATED > @DATE", connection);
            cmd.Parameters.AddWithValue("@MA", tbVoucher.Text);
            cmd.Parameters.AddWithValue("@DATE", DateTime.Now.ToString("yyyy-MM-dd"));
            int affected = cmd.ExecuteNonQuery();
            if(affected > 0)
            {
                return false;
            }
            return true;
        }
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (validVoucher())
                {
                    try
                    {
                        placeOrder();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("Mã khuyến mại đã được sử dụng hoặc hết hạn.");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void autoFill_CheckedChanged(object sender, EventArgs e)
        {
            if(autoFill.Checked == true)
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("select HOTEN, TK_SDT, TK_DIACHI from TAIKHOAN where TK_ID = @ID", connection);
                cmd.Parameters.AddWithValue("@ID", ID);
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);

                tbNameFrom.Text = dt.Rows[0][0].ToString();
                tbPhoneFrom.Text = dt.Rows[0][1].ToString();
                tbAddressFrom.Text = dt.Rows[0][2].ToString();
            }
        }

        private void fastDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if(fastDelivery.Checked == true)
            {
                labelTotal.Text = "Giá: " + (totalPrice + fastFee).ToString() + "đ";
            }
            else
            {
                labelTotal.Text = "Giá: " + totalPrice.ToString() + "đ";
            }
        }

        private void autoFill2_CheckedChanged(object sender, EventArgs e)
        {
            if (autoFill.Checked == true)
            {
                tbNameTo.Text = tbNameFrom.Text;
                tbPhoneTo.Text = tbPhoneFrom.Text;
                tbAddressTo.Text = tbAddressFrom.Text;
            }
        }
    }
}
