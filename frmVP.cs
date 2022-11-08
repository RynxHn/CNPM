using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMQL
{
    public partial class frmVP : Form
    {
        Process ql = new Process();
        public frmVP()
        {
            InitializeComponent();
            VPdgv.DataSource = ql.Load_VP();
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (ql.Them_VP(VPid.Text, VPname.Text, VPprice.Text, VPtype.Text, VPrarity.Text))
            {
                VPdgv.DataSource = ql.Load_VP();
                MessageBox.Show("Thêm thành công!");
            }
            else MessageBox.Show("Thêm ko thành công");
        }
        private void Upd_Click(object sender, EventArgs e)
        {
            if (ql.CheckMaVP(VPid.Text))
            {
                if (ql.Sua_VP(VPid.Text, VPname.Text, VPprice.Text, VPtype.Text, VPrarity.Text))
                {
                    VPdgv.DataSource = ql.Load_VP();
                    MessageBox.Show("Cập nhật thành công!");
                }
                else MessageBox.Show("Cập nhật ko thành công");
            }
            else
                MessageBox.Show("Ko có mã vp");
        }
        private void Del_Click(object sender, EventArgs e)
        {
            if (ql.CheckMaVP(VPid.Text))
            {
                if (ql.Xoa_VP_by_id_name(VPid.Text, VPname.Text))
                {
                    VPdgv.DataSource = ql.Load_VP();
                    MessageBox.Show("Xoá thành công!");
                }
                else MessageBox.Show("Xoá ko thành công");
            }
            else
                MessageBox.Show("Ko có mã vp");
        }
        private void Src_Click(object sender, EventArgs e)
        {
            VPdgv.DataSource = ql.Load_TimVP(VPid.Text, VPname.Text, VPprice.Text, VPtype.Text, VPrarity.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            VPdgv.DataSource = ql.Load_VP();
        }

        private void VPdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.VPdgv.Rows[e.RowIndex];
                VPid.Text = row.Cells[0].Value.ToString();
                VPname.Text = row.Cells[1].Value.ToString();
                VPprice.Text = row.Cells[2].Value.ToString();
                VPtype.Text = row.Cells[3].Value.ToString();
                VPrarity.Text = row.Cells[4].Value.ToString();
            }
        }

        private void VPdgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
