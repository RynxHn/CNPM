using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMQL
{
    public partial class frmHD : Form
    {
        Process ql = new Process();
        public frmHD()
        {
            InitializeComponent();
            dgvHD.DataSource = ql.Load_HD();
            dgvNM.DataSource = ql.Load_nameNM();
            dgvNB.DataSource = ql.Load_nameNB();
            dgvVP.DataSource = ql.Load_name_priceVP();

           /* DataGridView dgv_nm = new DataGridView();
            dgv_nm.ColumnCount = 7;
            dgv_nm.Columns[0].Name = "ItemID";*/
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (ql.Them_HD(idHD.Text, nameVP_HD.Text, nameNM_HD.Text, nameNB_HD.Text, giaHD.Text, ptttHD.Text, ngdHD.Text))
            {
                dgvHD.DataSource = ql.Load_HD();
                MessageBox.Show("Thêm thành công!");
            }
            else MessageBox.Show("Thêm ko thành công");
        }
        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvHD.Rows[e.RowIndex];
                idHD.Text = row.Cells[0].Value.ToString();
                nameVP_HD.Text = row.Cells[1].Value.ToString();
                nameNM_HD.Text = row.Cells[2].Value.ToString();
                nameNB_HD.Text = row.Cells[3].Value.ToString();
                giaHD.Text = row.Cells[4].Value.ToString();
                ptttHD.Text = row.Cells[5].Value.ToString();
                ngdHD.Text = row.Cells[6].Value.ToString();
            }
        }
        private void Print_Click(object sender, EventArgs e)
        {
            
            StreamWriter sw = new StreamWriter("D:\\test.txt");
            try
            {
                sw.Write(idHD.Text + " , " + nameVP_HD.Text + " , " + nameNM_HD.Text + " , " + nameNB_HD.Text + " , " + giaHD.Text + " , " + ptttHD.Text + " , " + ngdHD.Text);
                sw.Close();
                MessageBox.Show("In thành công");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi");
            }
            
        }

        private void dgvNM_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
    }
}
