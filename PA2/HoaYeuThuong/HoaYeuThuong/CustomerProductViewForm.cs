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
    public partial class CustomerProductViewForm : Form
    {
        public CustomerProductViewForm()
        {
            InitializeComponent();
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
                //Look up trending products
            }
            else
            {
                //default DGV
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

        private void productDGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
