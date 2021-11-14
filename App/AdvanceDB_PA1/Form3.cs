using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace AdvanceDB_PA1
{
    public partial class Form3 : Form
    {
        SqlConnection connection;
        SqlCommand command;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable tableHD = new DataTable();
        string str = @"Data Source=(local);Initial Catalog=csdlnc_pa1;Integrated Security=True";

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        void loadData()
        {
            try
            {
                command = connection.CreateCommand();
                command.CommandText = "select MONTH(NGAYLAP) as 'Thang', YEAR(NGAYLAP) AS 'Nam',sum(TONGTIEN) as 'DOANH THU' " +
                    "from hoadon group by month(NGAYLAP), year(NGAYLAP) ORDER BY YEAR(NGAYLAP) ASC, MONTH(NGAYLAP) ASC";
                adapter.SelectCommand = command;
                tableHD.Clear();
                
                adapter.Fill(tableHD);
                dataGridView1.DataSource = tableHD;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
