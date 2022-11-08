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

namespace PMQL
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Log_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=DESKTOP-059PDRG; Initial Catalog=CNPM;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = ID.Text;
                string mk = pass.Text;
                string sql = "Select * from NguoiDung where tk='" + tk + "' and mk='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    frmMenu Menu = new frmMenu();
                    Menu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Đăng nhập ko thành công");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối");
            }
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
