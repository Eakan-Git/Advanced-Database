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
    public partial class ProfileForm : Form
    {
        string ID, role;
        SqlConnection connection;
        SqlDataAdapter adapter = new SqlDataAdapter();
        string str = @"Data Source=(local);Initial Catalog=Hoayeuthuong;Integrated Security=True";
        public ProfileForm(string _ID, string _role)
        {
            InitializeComponent();
            ID = _ID;
            role = _role;
            connection = new SqlConnection(str);
            connection.Open();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            nameTb.ReadOnly = false;
            addressTb.ReadOnly = false;
            phoneNumTb.ReadOnly = false;
            emailTb.ReadOnly = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("update TAIKHOAN set HoTen = @HoTen, SoDienThoai = @SoDienThoai, DiaChi = @DiaChi, Email = @Email where ID = @ID", connection);
            cmd.Parameters.AddWithValue("@ID", ID);
            cmd.Parameters.AddWithValue("@HoTen", nameTb.Text);
            cmd.Parameters.AddWithValue("@SoDienThoai", phoneNumTb.Text);
            cmd.Parameters.AddWithValue("@Diachi", addressTb.Text);
            cmd.Parameters.AddWithValue("@Email", emailTb.Text);
            DialogResult confirm = MessageBox.Show("Xác nhận thay đổi thông tin?", "Chỉnh Sửa Thông Tin Cá Nhân", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Chỉnh sửa thông tin thành công.");
                    nameTb.ReadOnly = true;
                    addressTb.ReadOnly = true;
                    phoneNumTb.ReadOnly = true;
                    emailTb.ReadOnly = true;
                }
                catch
                {
                    MessageBox.Show("Lỗi kết nối.");
                }
            }
        }
    }
}
