using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PA1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            openChildForm(new Form2());
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Form2());
        }
        private void listBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Form3());
        }
        private void statBtn_Click(object sender, EventArgs e)
        {
            openChildForm(new Form4());
        }
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private Form activeFrom = null;
        private void openChildForm(Form childForm)
        {
            if (activeFrom != null)
                activeFrom.Close();
            activeFrom = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childFormPanel.Controls.Add(childForm);
            childFormPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
