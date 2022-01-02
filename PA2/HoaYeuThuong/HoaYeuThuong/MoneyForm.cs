using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace HoaYeuThuong
{
    public partial class MoneyForm : Form
    {
        public MoneyForm()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

        }

        private void btnFetch_Click(object sender, EventArgs e)
        {
            if(dtpFrom.Value >= dtpTo.Value)
            {
                MessageBox.Show("Thời gian không hợp lệ");
            }
            else if(cbbDepartment.SelectedValue == null)
            {
                MessageBox.Show("Chi nhánh không hợp lệ");
            }
            else
            {

            }
        }

        private void cbbDepartment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
