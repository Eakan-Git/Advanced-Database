using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HoaYeuThuong
{
    public partial class HomeForm : Form
    {
        string ID, role, username;
        const string CUSTOMER = "0";
        const string STAFF = "1";
        const string MANAGER = "2";
        private Form currentChildForm;
        public HomeForm(string _ID, string _role, string _username)
        {
            InitializeComponent();
            ID = _ID;
            role = _role;
            username = _username;
            greetingLabel.Text = "Xin chào, " + username;
        }
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnProfile_Click(object sender, EventArgs e)
        {
            navMenu.Height = btnProfile.Height;
            navMenu.Top = btnProfile.Top;
            navMenu.Visible = true;
            navMenu.BringToFront();

            OpenChildForm(new ProfileForm(ID, role));
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            navMenu.Height = btnProduct.Height;
            navMenu.Top = btnProduct.Top;
            navMenu.Visible = true;
            navMenu.BringToFront();
            if (role == STAFF || role == MANAGER)
            {
                OpenChildForm(new ProductForm());
            }
            else //CUSTOMER
            {
                OpenChildForm(new CustomerProductViewForm(ID));
            }
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            navMenu.Height = btnOrder.Height;
            navMenu.Top = btnOrder.Top;
            navMenu.Visible = true;
            navMenu.BringToFront();
            if(role == STAFF || role == MANAGER)
            {
                OpenChildForm(new AdminOrderForm());
            }
            else
            {
                OpenChildForm(new CustomerOrderForm(ID));
            }
            
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            navMenu.Height = btnCustomer.Height;
            navMenu.Top = btnCustomer.Top;
            navMenu.Visible = true;
            navMenu.BringToFront();

            OpenChildForm(new CustomerForm());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            navMenu.Height = btnStaff.Height;
            navMenu.Top = btnStaff.Top;
            navMenu.Visible = true;
            navMenu.BringToFront();

            OpenChildForm(new StaffForm());
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            navMenu.Height = btnMoney.Height;
            navMenu.Top = btnMoney.Top;
            navMenu.Visible = true;
            navMenu.BringToFront();

            OpenChildForm(new MoneyForm());
        }

        private void logoPic_Click(object sender, EventArgs e)
        {
            navMenu.Visible = false;
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
        }
        public static void OpenLoginForm()
        {
            Application.Run(new LoginForm());
        }

        private void btnCart_Click(object sender, EventArgs e)
        {
            navMenu.Height = btnCart.Height;
            navMenu.Top = btnCart.Top;
            navMenu.Visible = true;
            navMenu.BringToFront();

            OpenChildForm(new CartForm(ID));
        }

        private void btnOrderForCustomer_Click(object sender, EventArgs e)
        {
            navMenu.Height = btnOrderForCustomer.Height;
            navMenu.Top = btnOrderForCustomer.Top;
            navMenu.Visible = true;
            navMenu.BringToFront();

            OpenChildForm(new OrderForCustomerForm());
        }

        private void btnCreateAccout_Click(object sender, EventArgs e)
        {
            navMenu.Height = btnCreateAccout.Height;
            navMenu.Top = btnCreateAccout.Top;
            navMenu.Visible = true;
            navMenu.BringToFront();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            if(role == MANAGER)
            {
                btnCart.Visible = false;
                btnOrderForCustomer.Visible = false;
                btnOrder.Visible = false;
                btnCustomer.Visible = false;
            }
            else if(role == STAFF)
            {
                btnStaff.Visible = false;
                btnMoney.Visible = false;
                btnCart.Visible = false;
            }
            else //CUSTOMER (default = 0)
            {
                btnCustomer.Visible = false;
                btnStaff.Visible = false;
                btnMoney.Visible = false;
                btnCreateAccout.Visible = false;
                btnOrderForCustomer.Visible = false;
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLoginForm));
            t.Start();
            this.Close();
        }
    }
}
