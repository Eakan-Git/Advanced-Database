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
    public partial class CartForm : Form
    {
        SqlConnection connection;
        SqlDataAdapter adapter = new SqlDataAdapter();
        string str = @"Data Source=(local);Initial Catalog=Hoayeuthuong;Integrated Security=True";
        string ID;
        string salePriceDefault = "Giá món hàng: ";
        string totalDefault = "Tổng tiền: ";
        int price;
        int totalPrice;
        public CartForm(string _ID)
        {
            InitializeComponent();
            ID = _ID;
            connection = new SqlConnection(str);
            connection.Open();
        }
        private void loadProductList()
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = new SqlCommand("exec KH_XemChiTiet_GH @ID", connection);
            cmd.Parameters.AddWithValue("@ID", ID);
            adapter.SelectCommand = cmd;
            adapter.Fill(dt);
            productDGV.DataSource = dt;
        }
        private void loadTotalPrice()
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("exec ThanhTien_GioHang_Run @ID", connection);
                cmd.Parameters.AddWithValue("@ID", ID);
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);
                labelTotal.Text = totalDefault + dt.Rows[0][0].ToString() + "đ";
                totalPrice = Convert.ToInt32(dt.Rows[0][0]);
                labelTotal.Visible = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CartForm_Load(object sender, EventArgs e)
        {
            loadProductList();
            loadTotalPrice();
            checkDGV();
        }

        private void productDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                quantity.Value = Convert.ToInt32(productDGV.SelectedRows[0].Cells[2].Value);
                DataTable dt = new DataTable();
                SqlCommand cmd = new SqlCommand("exec khachHangXemSP_CoHinh_TrongCart @TEN", connection);
                cmd.Parameters.AddWithValue("@TEN", productDGV.SelectedRows[0].Cells[0].Value.ToString());
                adapter.SelectCommand = cmd;
                adapter.Fill(dt);

                nameLabel.Text = dt.Rows[0][0].ToString();
                price = Convert.ToInt32(dt.Rows[0][1]);
                labelSalePrice.Text = salePriceDefault + (price * quantity.Value).ToString() + "đ";
                byte[] imgData = (byte[])dt.Rows[0][2];
                MemoryStream ms = new MemoryStream(imgData);
                Image img = Image.FromStream(ms);
                productImage.Image = img;
                labelSalePrice.Visible = true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void updateProductPrice()
        {
            labelSalePrice.Text = salePriceDefault + (price * quantity.Value).ToString() + "đ";
        }
        private void quantity_ValueChanged(object sender, EventArgs e)
        {
            updateProductPrice();
        }

        private void updateProductDetails()
        {
            if(quantity.Value == 0)
            {
                deleteProduct();
            }
            else
            {
                SqlCommand cmd = new SqlCommand("exec updatesoluongSPGH @ID, @TEN, @SOLUONG", connection);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@TEN", productDGV.SelectedRows[0].Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@SOLUONG", quantity.Value.ToString());
                cmd.ExecuteNonQuery();
            }
        }
        private void btnEditQuantity_Click(object sender, EventArgs e)
        {
            updateProductDetails();
            loadProductList();
            loadTotalPrice();
            checkDGV();
        }
        private void deleteProduct()
        {
            DialogResult confirm = MessageBox.Show("Bạn muốn xóa sản phẩm này khỏi giỏ hàng?", "Xóa Sản Phẩm", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                SqlCommand cmd = new SqlCommand("exec xoasanphamGH @ID, @TEN", connection);
                cmd.Parameters.AddWithValue("@ID", ID);
                cmd.Parameters.AddWithValue("@TEN", productDGV.SelectedRows[0].Cells[0].Value.ToString());
                cmd.ExecuteNonQuery();
            }
        }
        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            deleteProduct();
            loadProductList();
            checkDGV();
            loadTotalPrice();
        }
        private void checkDGV()
        {
            if (productDGV.Rows.Count < 1)
            {
                btnPurchase.Enabled = false;
                quantity.Enabled = false;
                btnEditQuantity.Enabled = false;
                btnDeleteProduct.Enabled = false;
            }
            else
            {
                btnPurchase.Enabled = true;
                quantity.Enabled = true;
                btnEditQuantity.Enabled = true;
                btnDeleteProduct.Enabled = true;
            }
        }
        private void productDGV_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            Form form = new CustomerCreateOrderForm(ID, totalPrice);
            form.Show();
        }
    }
}
