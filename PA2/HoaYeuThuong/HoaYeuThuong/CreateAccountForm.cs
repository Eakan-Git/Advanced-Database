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
    public partial class CreateAccountForm : Form
    {
        SqlConnection connection;
        string str = @"Data Source=(local);Initial Catalog=Hoayeuthuong;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        public CreateAccountForm(string role)
        {
            InitializeComponent();
            if (role == "2") btnStaff.Visible = true;
            connection = new SqlConnection(str);
            connection.Open();
        }

        private void btnStaff_CheckedChanged(object sender, EventArgs e)
        {
            if(btnStaff.Checked == true)
            {
                loadDepartmentsList();
                labelDepartment.Visible = true;
                comboBox1.Visible = true;
            }
            else
            {
                labelDepartment.Visible = false;
                comboBox1.Visible = false;
            }
        }

        private int checkIfDataExisted(int role)
        {
            SqlCommand checkIfPhoneExisted = new SqlCommand("select TK_ID from TAIKHOAN where TK_ROLE = @role and TK_SDT = @SDT", connection);
            checkIfPhoneExisted.Parameters.AddWithValue("@SDT", phoneNumTb.Text);
            checkIfPhoneExisted.Parameters.AddWithValue("@role", role);
            SqlDataReader reader = checkIfPhoneExisted.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                return -1;
            }
            reader.Close();

            SqlCommand checkIfUsernameExisted = new SqlCommand("select TK_USERNAME from TAIKHOAN where TK_ROLE = @role and TK_USERNAME = @TK_USERNAME", connection);
            checkIfUsernameExisted.Parameters.AddWithValue("@TK_USERNAME", tbUsername.Text);
            checkIfUsernameExisted.Parameters.AddWithValue("@role", role);
            SqlDataReader reader2 = checkIfUsernameExisted.ExecuteReader();
            if (reader2.HasRows)
            {
                reader2.Close();
                return -2;
            }
            reader2.Close();

            SqlCommand checkIfEmailExisted = new SqlCommand("select TK_ID from TAIKHOAN where TK_ROLE = @role and TK_EMAIL = @EMAIL", connection);
            checkIfEmailExisted.Parameters.AddWithValue("@EMAIL", emailTb.Text);
            checkIfEmailExisted.Parameters.AddWithValue("@role", role);
            SqlDataReader reader3 = checkIfEmailExisted.ExecuteReader();
            if (reader3.HasRows)
            {
                reader3.Close();
                return -3;
            }
            reader3.Close();
            SqlCommand checkIfCMNDExisted = new SqlCommand("select TK_ID from TAIKHOAN where TK_ROLE = @role and TK_CMND = @CMND", connection);
            checkIfCMNDExisted.Parameters.AddWithValue("@CMND", tbCMND.Text);
            checkIfCMNDExisted.Parameters.AddWithValue("@role", role);
            SqlDataReader reader4 = checkIfCMNDExisted.ExecuteReader();
            if (reader4.HasRows)
            {
                reader4.Close();
                return -4;
            }
            reader4.Close();

            return 1;
        }

        private void createStaffAccount()
        {
            if (String.IsNullOrEmpty(tbUsername.Text) || String.IsNullOrEmpty(tbPassword.Text) || String.IsNullOrEmpty(addressTb.Text) || String.IsNullOrEmpty(phoneNumTb.Text) || String.IsNullOrEmpty(emailTb.Text) || String.IsNullOrEmpty(tbCMND.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
            }
            else if (String.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Mật khẩu không được có khoảng trống.");
            }
            else
            {
                int dataCheck = checkIfDataExisted(1);
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
                else if (dataCheck == -5)
                {
                    MessageBox.Show("Mật khẩu không khớp.");
                }
                else if (dataCheck == 1)
                {
                    SqlCommand cmd = new SqlCommand("exec taoAccNV @username, @password, @hoten, @email, @cmnd,  @diachi, @sdt, @CN_ID", connection);
                    cmd.Parameters.AddWithValue("@username", tbUsername.Text);
                    cmd.Parameters.AddWithValue("@password", tbPassword.Text);
                    cmd.Parameters.AddWithValue("@hoten", nameTb.Text);
                    cmd.Parameters.AddWithValue("@email", emailTb.Text);
                    cmd.Parameters.AddWithValue("@cmnd", tbCMND.Text);
                    cmd.Parameters.AddWithValue("@diachi", addressTb.Text);
                    cmd.Parameters.AddWithValue("@sdt", phoneNumTb.Text);
                    cmd.Parameters.AddWithValue("@CN_ID", comboBox1.SelectedValue);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Tạo tài khoản thành công.");
                }
                else
                {
                    MessageBox.Show("Lỗi dữ liệu.");
                }
            }
        }
        private void loadDepartmentsList()
        {
            try
            {
                SqlCommand command = new SqlCommand();
                command = connection.CreateCommand();
                command.CommandText = "select CN_ID, CN_DIACHI from CHINHANH";
                command.CommandType = CommandType.Text;
                adapter.SelectCommand = command;
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                comboBox1.DataSource = dt;
                comboBox1.DisplayMember = "CN_DIACHI";
                comboBox1.ValueMember = "CN_ID";
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi kết nối với cơ sở dữ liệu!");
            }
        }
        private void createCustomerAccount()
        {
            if (String.IsNullOrEmpty(tbUsername.Text) || String.IsNullOrEmpty(tbPassword.Text) || String.IsNullOrEmpty(addressTb.Text) || String.IsNullOrEmpty(phoneNumTb.Text) || String.IsNullOrEmpty(emailTb.Text) || String.IsNullOrEmpty(tbCMND.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
            }
            else if (String.IsNullOrWhiteSpace(tbPassword.Text))
            {
                MessageBox.Show("Mật khẩu không được có khoảng trống.");
            }
            else
            {
                int dataCheck = checkIfDataExisted(0);
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
                else if (dataCheck == -5)
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
                }
                else
                {
                    MessageBox.Show("Lỗi dữ liệu.");
                }
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {
            if(btnStaff.Checked == false)
            {
                createCustomerAccount();
            }
            else
            {
                createStaffAccount();
            }
        }
    }
}
