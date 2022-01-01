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
using System.IO;

namespace HoaYeuThuong
{
    public partial class CustomerProductViewForm : Form
    {
        SqlConnection connection;
        SqlDataAdapter adapter = new SqlDataAdapter();
        string str = @"Data Source=(local);Initial Catalog=Hoayeuthuong;Integrated Security=True";
        int offset;
        const int maxRowsPerPage = 12;
        const bool DEFAULT_STATUS = false;
        string placeholder = "Nhập tên sản phẩm...";
        string priceLabelDefault = "Giá gốc ";
        string salePriceLabelDefault = "Giá bán ";
        string ID;
        public CustomerProductViewForm(string _ID)
        {
            InitializeComponent();
            connection = new SqlConnection(str);
            connection.Open();
            offset = 0;
            searchBox.Text = placeholder;
            ID = _ID;
        }

        private void panelControl_Paint(object sender, PaintEventArgs e)
        {

        }

        bool isChecked = false;
        private void btnTrending_CheckedChanged(object sender, EventArgs e)
        {
            isChecked = btnTrending.Checked;
            if(btnTrending.Checked)
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("exec top10product", connection);
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                productDGV.DataSource = dt;
            }
            else
            {
                offset = 0;
                loadProductsList();
            }
        }

        private void btnTrending_Click(object sender, EventArgs e)
        {
            if (btnTrending.Checked && !isChecked)
                btnTrending.Checked = false;
            else
            {
                btnTrending.Checked = true;
                isChecked = false;
            }
        }

        private void fillDetails()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("exec khachHangXemSP_CoHinh @SP_TEN", connection);
                cmd.Parameters.AddWithValue("@SP_TEN", productDGV.SelectedRows[0].Cells[0].Value);
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                labelName.Text = dt.Rows[0][0].ToString();
                labelPrice.Text = priceLabelDefault + dt.Rows[0][1].ToString() + "đ";
                labelSalePrice.Text = salePriceLabelDefault + dt.Rows[0][2].ToString() + "đ";
                labelDescription.Text = dt.Rows[0][3].ToString();
                byte[] imgData = (byte[])dt.Rows[0][4];
                MemoryStream ms = new MemoryStream(imgData);
                Image img = Image.FromStream(ms);
                productImage.Image = img;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void productDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            fillDetails();
        }
        private void loadProductsList()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand command = new SqlCommand("exec khachHangXemSP @offset, @rows", connection);
                command.Parameters.AddWithValue("@offset", offset);
                command.Parameters.AddWithValue("@rows", maxRowsPerPage);
                adapter.SelectCommand = command;
                adapter.Fill(dt);
                productDGV.DataSource = dt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CustomerProductViewForm_Load(object sender, EventArgs e)
        {
            loadProductsList();
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
            loadProductsList();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnPrevious.Enabled = true;
            offset += maxRowsPerPage;
            try
            {
                loadProductsList();
                btnPrevious.Enabled = true;
                if(productDGV.Rows.Count < maxRowsPerPage)
                {
                    btnNext.Enabled = false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void searchProduct()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("exec khachHangTimSP @TEN", connection);
            cmd.Parameters.AddWithValue("@TEN", searchBox.Text);
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            productDGV.DataSource = dt;
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            offset = 0;
            loadProductsList();
        }
        private void searchBtn_Click(object sender, EventArgs e)
        {
            searchProduct();
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
                searchProduct();
            }
        }

        private void btnAddToCart_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd_add = new SqlCommand("exec KH_Them_SP_Vao_GH @TK_ID, @SP_TEN", connection);
                cmd_add.Parameters.AddWithValue("@TK_ID", ID);
                cmd_add.Parameters.AddWithValue("@SP_TEN", productDGV.SelectedRows[0].Cells[0].Value.ToString());
                cmd_add.ExecuteNonQuery();
                MessageBox.Show("Thêm vào giỏ hàng thành công.");
            }
            catch(Exception)
            {
                MessageBox.Show("Sản phẩm đã tồn tại trong giỏ hàng.");
            }
        }
    }
}
