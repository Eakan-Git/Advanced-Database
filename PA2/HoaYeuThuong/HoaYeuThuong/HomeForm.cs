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

        private Form currentChildForm;
        public HomeForm()
        {
            InitializeComponent();
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

            OpenChildForm(new ProfileForm());
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            navMenu.Height = btnProduct.Height;
            navMenu.Top = btnProduct.Top;
            navMenu.Visible = true;
            navMenu.BringToFront();

            OpenChildForm(new ProductForm());
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            navMenu.Height = btnOrder.Height;
            navMenu.Top = btnOrder.Top;
            navMenu.Visible = true;
            navMenu.BringToFront();

            OpenChildForm(new AdminOrderForm());
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
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            navMenu.Height = btnMoney.Height;
            navMenu.Top = btnMoney.Top;
            navMenu.Visible = true;
            navMenu.BringToFront();
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
        private void btnLogout_Click(object sender, EventArgs e)
        {
            System.Threading.Thread t = new System.Threading.Thread(new System.Threading.ThreadStart(OpenLoginForm));
            t.Start();
            this.Close();
        }
    }
}
