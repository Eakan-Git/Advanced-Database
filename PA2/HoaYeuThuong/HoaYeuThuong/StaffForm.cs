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
    public partial class StaffForm : Form
    {
        SqlConnection connection;
        SqlDataAdapter adapter = new SqlDataAdapter();
        string str = @"Data Source=(local);Initial Catalog=Hoayeuthuong;Integrated Security=True";
        int offset;
        const int maxRowsPerPage = 10;
        const bool DEFAULT_STATUS = false;
        string placeholder = "Nhập CMND...";
        public StaffForm()
        {
            InitializeComponent();
            connection = new SqlConnection(str);
            connection.Open();
            offset = 0;
            searchBox.Text = placeholder;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            tbID.Text = "";
            tbName.Text = "";
            tbPhone.Text = "";
            tbAddress.Text = "";
            tbEmail.Text = "";
            tbCMND.Text = "";
            //cbbDepartment.SelectedIndex = 0;
            offset = 0;
            loadStaffList();
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
            loadStaffList();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnPrevious.Enabled = true;
            offset += maxRowsPerPage;
            try
            {
                loadStaffList();
                btnPrevious.Enabled = true;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void searchStaff()
        {
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand("exec timKiemNhanVien @CMND", connection);
            command.Parameters.AddWithValue("@CMND", searchBox.Text);
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            staffDGV.DataSource = dt;
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchStaff();
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
                searchStaff();
            }
        }
        private void loadStaffList()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("exec xemDanhSachNhanVien @offset, @rows", connection);
            cmd.Parameters.AddWithValue("@offset", offset);
            cmd.Parameters.AddWithValue("@rows", maxRowsPerPage);
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            staffDGV.DataSource = dt;
            if (dt.Rows.Count < maxRowsPerPage)
            {
                btnNext.Enabled = false;
            }
        }
        private void StaffForm_Load(object sender, EventArgs e)
        {
            loadStaffList();
            loadDepartmentsList();
        }

        private void cbbDepartment_Click(object sender, EventArgs e)
        {

        }

        private void fillDetails()
        {
            try
            {
                if (staffDGV.SelectedRows[0].Cells[5].Value.Equals(false))
                {
                    btnLock.Enabled = false;
                    btnUnlock.Enabled = true;
                }
                else if (staffDGV.SelectedRows[0].Cells[5].Value.Equals(true))
                {
                    btnLock.Enabled = true;
                    btnUnlock.Enabled = false;
                }
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("exec xemThongTinNhanVien @ID", connection);
                cmd.Parameters.AddWithValue("@ID", staffDGV.SelectedRows[0].Cells[0].Value);
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                tbID.Text = dt.Rows[0][0].ToString();
                tbName.Text = dt.Rows[0][1].ToString();

                SqlCommand getDepartmentID = new SqlCommand("select CN_ID from CHINHANH where CN_DIACHI = @CN_DIACHI", connection);
                getDepartmentID.Parameters.AddWithValue("@CN_DIACHI", staffDGV.SelectedRows[0].Cells[2].Value.ToString());
                int departmentID = Convert.ToInt32(getDepartmentID.ExecuteScalar());
                cbbDepartment.SelectedIndex = departmentID-1;

                tbPhone.Text = dt.Rows[0][3].ToString();
                tbAddress.Text = dt.Rows[0][4].ToString();
                tbEmail.Text = dt.Rows[0][5].ToString();
                tbCMND.Text = dt.Rows[0][6].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                cbbDepartment.DataSource = dt;
                cbbDepartment.DisplayMember = "CN_DIACHI";
                cbbDepartment.ValueMember = "CN_ID";
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi khi kết nối với cơ sở dữ liệu!");
            }
        }
        private void staffDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillDetails();
        }
        private int checkIfDataExisted()
        {
            SqlCommand checkIfPhoneExisted = new SqlCommand("select TK_ID from TAIKHOAN where TK_ROLE = 1 and TK_SDT = @SDT and TK_ID != @ID", connection);
            checkIfPhoneExisted.Parameters.AddWithValue("@ID", tbID.Text);
            checkIfPhoneExisted.Parameters.AddWithValue("@SDT", tbPhone.Text);
            SqlDataReader reader = checkIfPhoneExisted.ExecuteReader();
            if (reader.HasRows)
            {
                reader.Close();
                return -1;
            }
            reader.Close();

            SqlCommand checkIfCMNDExisted = new SqlCommand("select TK_ID from TAIKHOAN where TK_ROLE = 1 and TK_CMND = @CMND and TK_ID != @ID", connection);
            checkIfCMNDExisted.Parameters.AddWithValue("@ID", tbID.Text);
            checkIfCMNDExisted.Parameters.AddWithValue("@CMND", tbCMND.Text);
            SqlDataReader reader2 = checkIfCMNDExisted.ExecuteReader();
            if (reader2.HasRows)
            {
                reader2.Close();
                return -2;
            }
            reader2.Close();

            SqlCommand checkIfEmailExisted = new SqlCommand("select TK_ID from TAIKHOAN where TK_ROLE = 1 and TK_EMAIL = @EMAIL and TK_ID != @ID", connection);
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
                    MessageBox.Show("Vui lòng chọn một nhân viên.");
                }
                else
                {
                    int checkData = checkIfDataExisted();
                    if (checkData == 1)
                    {
                        DialogResult confirm = MessageBox.Show("Xác nhận cập nhật nhân viên này?", "Cập Nhật Nhân Viên", MessageBoxButtons.YesNo);
                        if (confirm == DialogResult.Yes)
                        {
                            SqlCommand cmd = new SqlCommand("exec updateNV @ID, @TEN, @SDT, @DIACHI, @EMAIL, @CMND, @CN_ID", connection);
                            cmd.Parameters.AddWithValue("@ID", tbID.Text);
                            cmd.Parameters.AddWithValue("@TEN", tbName.Text);
                            cmd.Parameters.AddWithValue("@SDT", tbPhone.Text);
                            cmd.Parameters.AddWithValue("@DIACHI", tbAddress.Text);
                            cmd.Parameters.AddWithValue("@EMAIL", tbEmail.Text);
                            cmd.Parameters.AddWithValue("@CMND", tbCMND.Text);
                            cmd.Parameters.AddWithValue("@CN_ID", cbbDepartment.SelectedValue);
                            cmd.ExecuteNonQuery();
                            loadStaffList();
                            MessageBox.Show("Cập nhật nhân viên thành công.");
                        }
                    }
                    else
                    {
                        if(checkData == -1)
                        {
                            MessageBox.Show("Số điện thoại đã tồn tại.");
                            return;
                        }
                        else if (checkData == -2)
                        {
                            MessageBox.Show("Số CMND đã tồn tại.");
                            return;
                        }
                        else if(checkData == -3)
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
            DialogResult confirm = MessageBox.Show("Xác nhận khóa nhân viên này?", "Khóa Nhân Viên", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("update TAIKHOAN set TK_STATUS = 0 where TK_ID = @ID", connection);
                cmd.Parameters.AddWithValue("@ID", tbID.Text);
                cmd.ExecuteNonQuery();
                loadStaffList();
            }
        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Xác nhận mở khóa nhân viên này?", "Mở Khóa Nhân Viên", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("update TAIKHOAN set TK_STATUS = 1 where TK_ID = @ID", connection);
                cmd.Parameters.AddWithValue("@ID", tbID.Text);
                cmd.ExecuteNonQuery();
                loadStaffList();
            }
        }
    }
}
