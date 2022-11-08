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
    public partial class frmNB : Form
    {
        Process ql = new Process();
        public frmNB()
        {
            InitializeComponent();
            NBdgv.DataSource = ql.Load_NB();
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (ql.Them_NB(NBid.Text, NBname.Text, NBstk.Text))
            {
                NBdgv.DataSource = ql.Load_NB();
                MessageBox.Show("Thêm thành công!");
            }
            else MessageBox.Show("Thêm ko thành công");
        }
        private void Upd_Click(object sender, EventArgs e)
        {
            if (ql.CheckMaNM(NBid.Text))
            {
                if (ql.Sua_NM(NBid.Text, NBname.Text, NBstk.Text))
                {
                    NBdgv.DataSource = ql.Load_NB();
                    MessageBox.Show("Cập nhật thành công!");
                }
                else MessageBox.Show("Cập nhật ko thành công");
            }
            else
                MessageBox.Show("Ko có mã nb");
        }
        private void Del_Click(object sender, EventArgs e)
        {
            if (ql.Xoa_NB_by_name_stk(NBname.Text, NBstk.Text))
            {
                NBdgv.DataSource = ql.Load_NB();
                MessageBox.Show("Xoá thành công!");
            }
            else MessageBox.Show("Xoá ko thành công");
        }
        private void Src_Click(object sender, EventArgs e)
        {
            NBdgv.DataSource = ql.Load_TimNB(NBid.Text, NBname.Text, NBstk.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            NBdgv.DataSource = ql.Load_NB();
        }

        private void NBdgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.NBdgv.Rows[e.RowIndex];
                NBid.Text = row.Cells[0].Value.ToString();
                NBname.Text = row.Cells[1].Value.ToString();
                NBstk.Text = row.Cells[2].Value.ToString();
            }
        }
    }
}
