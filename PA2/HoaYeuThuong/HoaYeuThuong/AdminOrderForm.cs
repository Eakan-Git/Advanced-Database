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
    public partial class AdminOrderForm : Form
    {
        const int DANGXULI = 0;
        const int DANGGIAO = 1;
        const int DAGIAO = 2;
        const int DAHUY = 3;
        SqlConnection connection;
        SqlDataAdapter adapter = new SqlDataAdapter();
        string str = @"Data Source=(local);Initial Catalog=Hoayeuthuong;Integrated Security=True";
        int offset;
        const int maxRowsPerPage = 12;
        const bool DEFAULT_STATUS = false;
        string placeholder = "Nhập SĐT...";
        public AdminOrderForm()
        {
            InitializeComponent();
            searchBox.Text = placeholder;
            connection = new SqlConnection(str);
            connection.Open();
            offset = 0;
        }
        private void loadOrderList(int value)
        {
            string type = "Đang xử lý";
            if (value == 0) type = "Đang xử lý";
            else if (value == 1) type = "Đang giao";
            else if (value == 2) type = "Đã giao";
            else if (value == 3) type = "Đã hủy";
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand("exec checklistDH @offset, @rows, @type", connection);
            command.Parameters.AddWithValue("@offset", offset);
            command.Parameters.AddWithValue("@rows", maxRowsPerPage);
            command.Parameters.AddWithValue("@type", type);
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            OrderDGV.DataSource = dt;
        }
        private void type_SelectedIndexChanged(object sender, EventArgs e)
        {
            offset = 0;
            if(type.SelectedIndex == DANGXULI)
            {
                btnCheck.Enabled = true;
                btnCancel.Enabled = true;
                btnShipped.Enabled = false;
                loadOrderList(DANGXULI);
            }
            else if(type.SelectedIndex == DANGGIAO)
            {
                btnCheck.Enabled = false;
                btnCancel.Enabled = true;
                btnShipped.Enabled = true;
                loadOrderList(DANGGIAO);
            }
            else if(type.SelectedIndex == DAGIAO)
            {
                btnCheck.Enabled = false;
                btnCancel.Enabled = false;
                btnShipped.Enabled = false;
                loadOrderList(DAGIAO);
            }
            else if(type.SelectedIndex == DAHUY)
            {
                btnCheck.Enabled = false;
                btnCancel.Enabled = false;
                btnShipped.Enabled = false;
                loadOrderList(DAHUY);
            }
        }
        private void refresh()
        {
            if (type.SelectedIndex == DANGXULI)
            {
                loadOrderList(DANGXULI);
            }
            else if (type.SelectedIndex == DANGGIAO)
            {
                loadOrderList(DANGGIAO);
            }
            else if (type.SelectedIndex == DAGIAO)
            {
                loadOrderList(DAGIAO);
            }
            else if (type.SelectedIndex == DAHUY)
            {
                loadOrderList(DAHUY);
            }
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
            refresh();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            btnPrevious.Enabled = true;
            offset += maxRowsPerPage;
            try
            {
                refresh();
                btnPrevious.Enabled = true;
            }
            catch (Exception)
            {
                throw;
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

        private void searchOrder()
        {
            DataTable dt = new DataTable();
            SqlCommand command = new SqlCommand("exec NV_TimKiem_DH_Theo_SDTDAT @SDT", connection);
            command.Parameters.AddWithValue("@SDT", searchBox.Text);
            adapter.SelectCommand = command;
            adapter.Fill(dt);
            OrderDGV.DataSource = dt;
        }

        private void searchBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                searchOrder();
            }
        }

        private void AdminOrderForm_Load(object sender, EventArgs e)
        {
            btnCancel.Enabled = false;
            btnCheck.Enabled = false;
            btnShipped.Enabled = false;
            type.SelectedIndex = DANGXULI;
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            offset = 0;
            refresh();
        }
        private void popProductImage()
        {
            Form form = new ProductImage(Convert.ToInt32(DetailOrderDGV.SelectedRows[0].Cells[0].Value));
            form.Show();
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void btnShipped_Click(object sender, EventArgs e)
        {

        }
        private void popDetails(int ID_DH)
        {
            Form form = new OrderDetailsForm(ID_DH);
            form.Show();
        }
        private void fillOrderData()
        {
            DataSet ds = new DataSet();
            SqlCommand command = new SqlCommand("exec Xem_SP_DH @ID_DH", connection);
            command.Parameters.AddWithValue("@ID_DH", Convert.ToInt32(OrderDGV.SelectedRows[0].Cells[0].Value));
            adapter.SelectCommand = command;
            adapter.Fill(ds);
            DataTable dt = new DataTable();
            DataTable dt2 = new DataTable();
            dt = ds.Tables[0];
            dt2 = ds.Tables[1];
            labelName.Text = "Khách hàng: " + dt.Rows[0][0].ToString();
            labelPhone.Text = "Số điện thoại: " + dt.Rows[0][1].ToString();
            DetailOrderDGV.DataSource = dt2;
        }
        private void OrderDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                fillOrderData();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void OrderDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                popDetails(Convert.ToInt32(OrderDGV.SelectedRows[0].Cells[0].Value));
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void DetailOrderDGV_DoubleClick(object sender, EventArgs e)
        {

        }

        private void DetailOrderDGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            popProductImage();
        }
    }
}
