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
        private void loadData()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("select HOTEN, TK_SDT, TK_DIACHI, TK_EMAIL from TAIKHOAN where TK_ID = @ID", connection);
            cmd.Parameters.AddWithValue("@ID", ID);
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            nameTb.Text = dt.Rows[0][0].ToString();
            phoneNumTb.Text = dt.Rows[0][1].ToString();
            addressTb.Text = dt.Rows[0][2].ToString();
            emailTb.Text = dt.Rows[0][3].ToString();
        }
        private void ProfileForm_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (nameTb.Text == "" || phoneNumTb.Text == "" || addressTb.Text == "" || emailTb.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
            }
            else
            {
                SqlCommand cmd = new SqlCommand("exec updateProfile @HOTEN, @SoDienThoai, @DiaChi, @Email, @ID", connection);
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
                        loadData();
                    }
                    catch
                    {
                        MessageBox.Show("Lỗi kết nối.");
                    }
                }
            }
        }
    }
}
