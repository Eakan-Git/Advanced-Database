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
    public partial class ProductForm : Form
    {
        SqlConnection connection;
        SqlDataAdapter adapter = new SqlDataAdapter();
        string str = @"Data Source=(local);Initial Catalog=Hoayeuthuong;Integrated Security=True";
        int offset;
        const int maxRowsPerPage = 15;
        const bool DEFAULT_STATUS = false;
        string placeholder = "Nhập tên sản phẩm...";
        public ProductForm()
        {
            InitializeComponent();
            connection = new SqlConnection(str);
            connection.Open();
            offset = 0;
            searchBox.Text = placeholder;
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.png; *.bmp)| *.jpg; *.jpeg; *.png; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                // display image in picture box  
                productImage.Image = new Bitmap(open.FileName);
            }
        }

        private void loadProductList()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("exec xemThongTinSanPhamKhongHinhAnh @offset, @rows", connection);
            cmd.Parameters.AddWithValue("@offset", offset);
            cmd.Parameters.AddWithValue("@rows", maxRowsPerPage);
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            productDGV.DataSource = dt;
            if (dt.Rows.Count < maxRowsPerPage)
            {
                btnNext.Enabled = false;
            }
        }
        private void ProductForm_Load(object sender, EventArgs e)
        {
            loadProductList();
        }
        private void btnUnlock_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Xác nhận mở khóa sản phẩm này?", "Mở Khóa Sản Phẩm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("update SANPHAM set SP_STATUS = 1 where SP_ID = @ID", connection);
                cmd.Parameters.AddWithValue("@ID", tbID.Text);
                cmd.ExecuteNonQuery();
                loadProductList();
            }
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Xác nhận khóa sản phẩm này?", "Khóa Sản Phẩm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("update SANPHAM set SP_STATUS = 0 where SP_ID = @ID", connection);
                cmd.Parameters.AddWithValue("@ID", tbID.Text);
                cmd.ExecuteNonQuery();
                loadProductList();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbName.Text == "" || tbPrice.Text == "" || TbSalePrice.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.");
                }
                else if(tbID.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn một sản phẩm.");
                }
                else
                {
                    if (Convert.ToInt32(tbPrice.Text) < 0 || Convert.ToInt32(TbSalePrice.Text) < 0)
                    {
                        MessageBox.Show("Vui lòng nhập giá hợp lệ.");
                        return;
                    }
                    SqlCommand checkIfProductExisted = new SqlCommand("select SP_ID from SANPHAM where SP_TEN = @SP_TEN and SP_ID != @SP_ID", connection);
                    checkIfProductExisted.Parameters.AddWithValue("@SP_TEN", tbName.Text);
                    checkIfProductExisted.Parameters.AddWithValue("@SP_ID", tbID.Text);
                    SqlDataReader reader = checkIfProductExisted.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        DialogResult confirm = MessageBox.Show("Xác nhận cập nhật sản phẩm này?", "Cập Nhật Sản Phẩm", MessageBoxButtons.YesNo);
                        if (confirm == DialogResult.Yes)
                        {
                            SqlCommand cmd = new SqlCommand("exec SuaSP @SP_ID, @SP_TEN, @SP_GIAGOC, @SP_GIABAN, @SP_HINHANH, @SP_MOTA", connection);
                            cmd.Parameters.AddWithValue("@SP_ID", tbID.Text);
                            cmd.Parameters.AddWithValue("@SP_TEN", tbName.Text);
                            cmd.Parameters.AddWithValue("@SP_GIAGOC", tbPrice.Text);
                            cmd.Parameters.AddWithValue("@SP_GIABAN", TbSalePrice.Text);
                            cmd.Parameters.AddWithValue("@SP_MOTA", tbDes.Text);

                            MemoryStream stream = new MemoryStream();
                            productImage.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                            byte[] pic = stream.ToArray();
                            cmd.Parameters.AddWithValue("@SP_HINHANH", pic);

                            cmd.ExecuteNonQuery();
                            loadProductList();
                            MessageBox.Show("Cập nhật sản phẩm thành công.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên sản phẩm đã tồn tại.");
                    }
                    reader.Close();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbName.Text == "" || tbPrice.Text == "" || TbSalePrice.Text == "" || productImage == null || productImage.Image == null)
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin.");
                }
                else
                {
                    if (Convert.ToInt32(tbPrice.Text) < 0 || Convert.ToInt32(TbSalePrice.Text) < 0)
                    {
                        MessageBox.Show("Vui lòng nhập giá hợp lệ.");
                        return;
                    }
                    SqlCommand checkIfProductExisted = new SqlCommand("select SP_ID from SANPHAM where SP_TEN = @SP_TEN", connection);
                    checkIfProductExisted.Parameters.AddWithValue("@SP_TEN", tbName.Text);
                    SqlDataReader reader = checkIfProductExisted.ExecuteReader();
                    if (!reader.HasRows)
                    {
                        reader.Close();
                        DialogResult confirm = MessageBox.Show("Xác nhận thêm sản phẩm này?", "Thêm Sản Phẩm", MessageBoxButtons.YesNo);
                        if (confirm == DialogResult.Yes)
                        {
                            SqlCommand cmd = new SqlCommand("exec ThemSP @SP_TEN, @SP_GIAGOC, @SP_GIABAN, @SP_HINHANH, @SP_MOTA, @SP_STATUS", connection);
                            cmd.Parameters.AddWithValue("@SP_TEN", tbName.Text);
                            cmd.Parameters.AddWithValue("@SP_GIAGOC", tbPrice.Text);
                            cmd.Parameters.AddWithValue("@SP_GIABAN", TbSalePrice.Text);
                            cmd.Parameters.AddWithValue("@SP_MOTA", tbDes.Text);
                            cmd.Parameters.AddWithValue("@SP_STATUS", DEFAULT_STATUS);

                            MemoryStream stream = new MemoryStream();
                            productImage.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                            byte[] pic = stream.ToArray();
                            cmd.Parameters.AddWithValue("@SP_HINHANH", pic);

                            cmd.ExecuteNonQuery();
                            loadAfterAdd();
                            loadProductList();
                            MessageBox.Show("Thêm sản phẩm thành công.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên sản phẩm đã tồn tại.");
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void loadAfterAdd()
        {
            SqlCommand checkIfProductExisted = new SqlCommand("select SP_ID from SANPHAM where SP_TEN = @SP_TEN", connection);
            checkIfProductExisted.Parameters.AddWithValue("@SP_TEN", tbName.Text);
            tbID.Text = Convert.ToString(checkIfProductExisted.ExecuteScalar());
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
            loadProductList();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnPrevious.Enabled = true;
            offset += maxRowsPerPage;
            try
            {
                loadProductList();
                btnPrevious.Enabled = true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            offset = 0;
            tbID.Text = "";
            tbName.Text = "";
            tbDes.Text = "";
            tbPrice.Text = "";
            TbSalePrice.Text = "";
            productImage.Image = null;
            loadProductList();
        }
        private void fillDetails()
        {
            try
            {
                if (productDGV.SelectedRows[0].Cells[4].Value.Equals(false))
                {
                    btnLock.Enabled = false;
                    btnUnlock.Enabled = true;
                }
                else if (productDGV.SelectedRows[0].Cells[4].Value.Equals(true))
                {
                    btnLock.Enabled = true;
                    btnUnlock.Enabled = false;
                }
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("exec xemThongTinSanPham @ID", connection);
                cmd.Parameters.AddWithValue("@ID", productDGV.SelectedRows[0].Cells[0].Value);
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                tbID.Text = dt.Rows[0][0].ToString();
                tbName.Text = dt.Rows[0][1].ToString();
                tbDes.Text = dt.Rows[0][2].ToString();
                tbPrice.Text = dt.Rows[0][3].ToString();
                TbSalePrice.Text = dt.Rows[0][4].ToString();

                byte[] imgData = (byte[])dt.Rows[0][5];
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
        private void searchProduct()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("exec nvTimSP @TEN", connection);
            cmd.Parameters.AddWithValue("@TEN", searchBox.Text);
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            productDGV.DataSource = dt;
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
            if(e.KeyChar == (char)13)
            {
                searchProduct();
            }
        }
    }
}
