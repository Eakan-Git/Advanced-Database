using System;
using System.Windows.Forms;
using System.Drawing;
namespace AdvanceDB_PA1
{
    public partial class Form0 : Form
    {
        private Form currentChildForm;
        public Form0()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form1());
        }
        private void OpenChildForm(Form childForm)
        {
            if(currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel3.Controls.Add(childForm);
            panel3.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
  
        private void label1_Click(object sender, EventArgs e)
        {
            currentChildForm.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form2());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Form3());
        }
    }
}
