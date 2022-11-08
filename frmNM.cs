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
    public partial class frmNM : Form
    {
        Process ql = new Process();
        public frmNM()
        {
            InitializeComponent();
            NMdgv.DataSource = ql.Load_NM();
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (ql.Them_NM(NMid.Text, NMname.Text, NMstk.Text))
            {
                NMdgv.DataSource = ql.Load_NM();
                MessageBox.Show("Thêm thành công!");
            }
            else MessageBox.Show("Thêm ko thành công");
        }
        private void Upd_Click(object sender, EventArgs e)
        {
            if (ql.CheckMaNM(NMid.Text))
            {
                if (ql.Sua_NM(NMid.Text, NMname.Text, NMstk.Text))
                {
                    NMdgv.DataSource = ql.Load_NM();
                    MessageBox.Show("Cập nhật thành công!");
                }
                else MessageBox.Show("Cập nhật ko thành công");
            }
            else
                MessageBox.Show("Ko có mã nm");
        }
        private void Del_Click(object sender, EventArgs e)
        {
            //if (ql.CheckMaNM(NMid.Text))
            //{
            if (ql.Xoa_NM_by_name_stk(NMname.Text, NMstk.Text))
            {
                NMdgv.DataSource = ql.Load_NM();
                MessageBox.Show("Xoá thành công!");
            }
            else MessageBox.Show("Xoá ko thành công");
            //}
            //else
            //MessageBox.Show("Ko có mã sv");
        }
        private void Src_Click(object sender, EventArgs e)
        {
            NMdgv.DataSource = ql.Load_TimNM(NMid.Text, NMname.Text, NMstk.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            NMdgv.DataSource = ql.Load_NM();
        }

        private void NMdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.NMdgv.Rows[e.RowIndex];
                NMid.Text = row.Cells[0].Value.ToString();
                NMname.Text = row.Cells[1].Value.ToString();
                NMstk.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
