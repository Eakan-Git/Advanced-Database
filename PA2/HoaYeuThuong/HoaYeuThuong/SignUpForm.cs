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
    public partial class SignUpForm : Form
    {
        SqlConnection connection;
        string str = @"Data Source=(local);Initial Catalog=Hoayeuthuong;Integrated Security=True";
        public SignUpForm()
        {
            InitializeComponent();
            connection = new SqlConnection(str);
            connection.Open();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private int checkIfDataExisted()
        {
            SqlCommand checkIfPhoneExisted = new SqlCommand("select TK_ID from TAIKHOAN where TK_ROLE = 0 and TK_SDT = @SDT", connection);
            checkIfPhoneExisted.Parameters.AddWithValue("@SDT", phoneNumTb.Text);
            SqlDataReader reader = checkIfPhoneExisted.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                return -1;
            }
            reader.Close();

            SqlCommand checkIfUsernameExisted = new SqlCommand("select TK_USERNAME from TAIKHOAN where TK_ROLE = 0 and TK_USERNAME = @TK_USERNAME", connection);
            checkIfUsernameExisted.Parameters.AddWithValue("@TK_USERNAME", tbUsername.Text);
            SqlDataReader reader2 = checkIfUsernameExisted.ExecuteReader();
            if (reader2.HasRows)
            {
                reader2.Close();
                return -2;
            }
            reader2.Close();

            SqlCommand checkIfEmailExisted = new SqlCommand("select TK_ID from TAIKHOAN where TK_ROLE = 0 and TK_EMAIL = @EMAIL", connection);
            checkIfEmailExisted.Parameters.AddWithValue("@EMAIL", emailTb.Text);
            SqlDataReader reader3 = checkIfEmailExisted.ExecuteReader();
            if (reader3.HasRows)
            {
                reader3.Close();
                return -3;
            }
            reader3.Close();
            SqlCommand checkIfCMNDExisted = new SqlCommand("select TK_ID from TAIKHOAN where TK_ROLE = 0 and TK_CMND = @CMND", connection);
            checkIfCMNDExisted.Parameters.AddWithValue("@CMND", tbCMND.Text);
            SqlDataReader reader4 = checkIfCMNDExisted.ExecuteReader();
            if (reader4.HasRows)
            {
                reader4.Close();
                return -4;
            }
            reader4.Close();
            if (tbPassword.Text != confirmPassTb.Text)
            {
                return -5;
            }
            return 1;
        }

        private void signUpBtn_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbUsername.Text) || String.IsNullOrEmpty(tbPassword.Text) || String.IsNullOrEmpty(addressTb.Text) || String.IsNullOrEmpty(confirmPassTb.Text) || String.IsNullOrEmpty(phoneNumTb.Text) || String.IsNullOrEmpty(emailTb.Text) || String.IsNullOrEmpty(tbCMND.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
            }
            else if(String.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Mật khẩu không được có khoảng trống.");
            }
            else
            {
                int dataCheck = checkIfDataExisted();
                if (dataCheck == -1)
                {
                    MessageBox.Show("Số điện thoại đã tồn tại.");
                }
                else if (dataCheck == -2)
                {
                    MessageBox.Show("Tên đăng nhập đã tồn tại.");
                }
                else if (dataCheck == -3)
                {
                    MessageBox.Show("Địa chỉ email đã tồn tại.");
                }
                else if (dataCheck == -4)
                {
                    MessageBox.Show("Số CMND đã tồn tại.");
                }
                else if(dataCheck == -5)
                {
                    MessageBox.Show("Mật khẩu không khớp.");
                }
                else if (dataCheck == 1)
                {
                    SqlCommand cmd = new SqlCommand("exec taoAccKhachHang @username, @password, @hoten, @email, @cmnd,  @diachi, @sdt", connection);
                    cmd.Parameters.AddWithValue("@username", tbUsername.Text);
                    cmd.Parameters.AddWithValue("@password", tbPassword.Text);
                    cmd.Parameters.AddWithValue("@hoten", nameTb.Text);
                    cmd.Parameters.AddWithValue("@email", emailTb.Text);
                    cmd.Parameters.AddWithValue("@cmnd", tbCMND.Text);
                    cmd.Parameters.AddWithValue("@diachi", addressTb.Text);
                    cmd.Parameters.AddWithValue("@sdt", phoneNumTb.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tạo tài khoản thành công.");

                    this.Hide();
                    LoginForm form = new LoginForm(tbUsername.Text);
                    form.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lỗi dữ liệu.");
                }
            }
        }

        private void confirmPassTb_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(confirmPassTb.Text))
            {
                labelValidPass.Visible = false;
            }   
            else
            {
                if (confirmPassTb.Text != tbPassword.Text)
                {
                    labelValidPass.ForeColor = Color.Red;
                    labelValidPass.Text = "Mật khẩu không khớp";
                }
                else
                {
                    labelValidPass.ForeColor = Color.Green;
                    labelValidPass.Text = "Khớp mật khẩu";
                }
            }
        }
    }
}
