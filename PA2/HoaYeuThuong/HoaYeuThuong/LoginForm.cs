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
    public partial class LoginForm : Form
    {
        string str = @"Data Source=(local);Initial Catalog=Hoayeuthuong;Integrated Security=True";
        SqlDataAdapter adapter;
        public LoginForm()
        {
            InitializeComponent();
            adapter = new SqlDataAdapter();
        }
        public LoginForm(string username)
        {
            InitializeComponent();
            adapter = new SqlDataAdapter();
            usernameTxt.Text = username;
        }
        private void signUpBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.ShowDialog();
            this.Close();
        }
        private void login()
        {
            if (usernameTxt.Text == "" || passTxt.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin đăng nhập.");
            }
            else
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(str))
                    {
                        try
                        {
                            SqlCommand loginCommand = new SqlCommand("exec checkTK @username, @password", connection);
                            loginCommand.Parameters.AddWithValue("@username", usernameTxt.Text);
                            loginCommand.Parameters.AddWithValue("@password", passTxt.Text);
                            adapter.SelectCommand = loginCommand;
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            string _ID = dataTable.Rows[0][0].ToString();
                            string _role = dataTable.Rows[0][1].ToString();
                            //MessageBox.Show(_ID + _role);

                            HomeForm homeForm = new HomeForm(_ID, _role, usernameTxt.Text);
                            this.Hide();
                            homeForm.ShowDialog();
                            this.Close();
                        }
                        catch
                        {
                            MessageBox.Show("Sai thông tin đăng nhập hoặc tài khoản đã bị khóa.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void loginBtn_Click(object sender, EventArgs e)
        {
            login();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void usernameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                login();
            }
        }

        private void passTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                login();
            }
        }
    }
}
