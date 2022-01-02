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
    public partial class CustomerForm : Form
    {
        SqlConnection connection;
        SqlDataAdapter adapter = new SqlDataAdapter();
        string str = @"Data Source=(local);Initial Catalog=Hoayeuthuong;Integrated Security=True";
        int offset;
        const int maxRowsPerPage = 15;
        const bool DEFAULT_STATUS = false;
        string placeholder = "Nhập SĐT...";
        public CustomerForm()
        {
            InitializeComponent();
            connection = new SqlConnection(str);
            connection.Open();
            offset = 0;
            searchBox.Text = placeholder;
            btnLock.Enabled = false;
            btnUnlock.Enabled = false;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            offset -= maxRowsPerPage;
            if (offset <= 0)
            {
                offset = 0;
                btnPrevious.Enabled = false;
            }
            btnNext.Enabled = true;
            loadCustomerList();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnPrevious.Enabled = true;
            offset += maxRowsPerPage;
            try
            {
                loadCustomerList();
                btnPrevious.Enabled = true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void searchCustomer()
        {

        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchCustomer();
        }
        private int checkIfDataExisted()
        {
            SqlCommand checkIfPhoneExisted = new SqlCommand("select TK_ID from TAIKHOAN where TK_ROLE = 0 and TK_SDT = @SDT and TK_ID != @ID", connection);
            checkIfPhoneExisted.Parameters.AddWithValue("@ID", tbID.Text);
            checkIfPhoneExisted.Parameters.AddWithValue("@SDT", tbPhone.Text);
            SqlDataReader reader = checkIfPhoneExisted.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                return -1;
            }
            reader.Close();

            SqlCommand checkIfCMNDExisted = new SqlCommand("select TK_ID from TAIKHOAN where TK_ROLE = 0 and TK_CMND = @CMND and TK_ID != @ID", connection);
            checkIfCMNDExisted.Parameters.AddWithValue("@ID", tbID.Text);
            checkIfCMNDExisted.Parameters.AddWithValue("@CMND", tbCMND.Text);
            SqlDataReader reader2 = checkIfCMNDExisted.ExecuteReader();
            if (reader2.HasRows)
            {
                reader2.Close();
                return -2;
            }
            reader2.Close();

            SqlCommand checkIfEmailExisted = new SqlCommand("select TK_ID from TAIKHOAN where TK_ROLE = 0 and TK_EMAIL = @EMAIL and TK_ID != @ID", connection);
            checkIfEmailExisted.Parameters.AddWithValue("@ID", tbID.Text);
            checkIfEmailExisted.Parameters.AddWithValue("@EMAIL", tbEmail.Text);
            SqlDataReader reader3 = checkIfEmailExisted.ExecuteReader();
            if (reader3.HasRows)
            {
                reader3.Close();
                return -3;
            }
            reader3.Close();

            return 1;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbName.Text == "" || tbPhone.Text == "" || tbAddress.Text == "" || tbEmail.Text == "" || tbCMND.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.");
                }
                else if (tbID.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn một khách hàng.");
                }
                else
                {
                    int checkData = checkIfDataExisted();
                    if (checkData == 1)
                    {
                        DialogResult confirm = MessageBox.Show("Xác nhận cập nhật khách hàng này?", "Cập Nhật Khách Hàng", MessageBoxButtons.YesNo);
                        if (confirm == DialogResult.Yes)
                        {
                            SqlCommand cmd = new SqlCommand("exec updateKH @ID, @TEN, @SDT, @DIACHI, @EMAIL, @CMND", connection);
                            cmd.Parameters.AddWithValue("@ID", tbID.Text);
                            cmd.Parameters.AddWithValue("@TEN", tbName.Text);
                            cmd.Parameters.AddWithValue("@SDT", tbPhone.Text);
                            cmd.Parameters.AddWithValue("@DIACHI", tbAddress.Text);
                            cmd.Parameters.AddWithValue("@EMAIL", tbEmail.Text);
                            cmd.Parameters.AddWithValue("@CMND", tbCMND.Text);
                            cmd.ExecuteNonQuery();
                            loadCustomerList();
                            MessageBox.Show("Cập nhật khách hàng thành công.");
                        }
                    }
                    else
                    {
                        if (checkData == -1)
                        {
                            MessageBox.Show("Số điện thoại đã tồn tại.");
                            return;
                        }
                        else if (checkData == -2)
                        {
                            MessageBox.Show("Số CMND đã tồn tại.");
                            return;
                        }
                        else if (checkData == -3)
                        {
                            MessageBox.Show("Email đã tồn tại.");
                            return;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Xác nhận khóa khách hàng này?", "Khóa Khách Hàng", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("update TAIKHOAN set TK_STATUS = 0 where TK_ID = @ID", connection);
                cmd.Parameters.AddWithValue("@ID", tbID.Text);
                cmd.ExecuteNonQuery();
                loadCustomerList();
            }
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Xác nhận mở khóa khách hàng này?", "Mở Khóa Khách Hàng", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("update TAIKHOAN set TK_STATUS = 1 where TK_ID = @ID", connection);
                cmd.Parameters.AddWithValue("@ID", tbID.Text);
                cmd.ExecuteNonQuery();
                loadCustomerList();
            }
        }
        private void searchBox_Enter(object sender, EventArgs e)
        {
            if (searchBox.Text != "")
                searchBox.Text = "";
        }

        private void searchBox_Leave(object sender, EventArgs e)
        {
            if (searchBox.Text == "")
                searchBox.Text = placeholder;
        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                searchCustomer();
            }
        }
        private void loadCustomerList()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("exec NV_XemDanhSach_KH @offset, @rows", connection);
            cmd.Parameters.AddWithValue("@offset", offset);
            cmd.Parameters.AddWithValue("@rows", maxRowsPerPage);
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            customerDGV.DataSource = dt;
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            tbID.Text = "";
            tbName.Text = "";
            tbPhone.Text = "";
            tbAddress.Text = "";
            tbEmail.Text = "";
            tbCMND.Text = "";
            offset = 0;
            loadCustomerList();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            loadCustomerList();
        }
        private void fillDetails()
        {
            try
            {
                if (customerDGV.SelectedRows[0].Cells[4].Value.Equals(false))
                {
                    btnLock.Enabled = false;
                    btnUnlock.Enabled = true;
                }
                else if (customerDGV.SelectedRows[0].Cells[4].Value.Equals(true))
                {
                    btnLock.Enabled = true;
                    btnUnlock.Enabled = false;
                }
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("exec NV_XemThongTin_KH @ID", connection);
                cmd.Parameters.AddWithValue("@ID", customerDGV.SelectedRows[0].Cells[0].Value);
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                tbID.Text = dt.Rows[0][0].ToString();
                tbName.Text = dt.Rows[0][1].ToString();
                tbPhone.Text = dt.Rows[0][2].ToString();
                tbAddress.Text = dt.Rows[0][3].ToString();
                tbEmail.Text = dt.Rows[0][4].ToString();
                tbCMND.Text = dt.Rows[0][5].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void customerDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillDetails();
        }
    }
}
