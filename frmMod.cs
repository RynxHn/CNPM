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
    public partial class frmMod : Form
    {
        Process ql = new Process();
        public frmMod()
        {
            InitializeComponent();
            Moddgv.DataSource = ql.Load_Mod();
        }
        private void Add_Click(object sender, EventArgs e)
        {
            if (ql.Them_Mod(Modid.Text, Modname.Text, Modsdt.Text, Moddc.Text, Modrank.Text))
            {
                Moddgv.DataSource = ql.Load_Mod();
                MessageBox.Show("Thêm thành công!");
            }
            else MessageBox.Show("Thêm ko thành công");
        }
        private void Upd_Click(object sender, EventArgs e)
        {
            if (ql.CheckMaMod(Modid.Text))
            {
                if (ql.Sua_Mod(Modid.Text, Modname.Text, Modsdt.Text, Moddc.Text, Modrank.Text))
                {
                    Moddgv.DataSource = ql.Load_Mod();
                    MessageBox.Show("Cập nhật thành công!");
                }
                else MessageBox.Show("Cập nhật ko thành công");
            }
            else
                MessageBox.Show("Ko có mã moderator");
        }
        private void Del_Click(object sender, EventArgs e)
        {
            if (ql.Xoa_Mod_by_name_sdt(Modname.Text, Modsdt.Text))
            {
                Moddgv.DataSource = ql.Load_Mod();
                MessageBox.Show("Xoá thành công!");
            }
            else MessageBox.Show("Xoá ko thành công");
        }
        private void Src_Click(object sender, EventArgs e)
        {
            Moddgv.DataSource = ql.Load_TimMod(Modid.Text, Modname.Text, Modsdt.Text, Moddc.Text, Modrank.Text);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            Moddgv.DataSource = ql.Load_Mod();
        }

        private void Moddgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.Moddgv.Rows[e.RowIndex];
                Modid.Text = row.Cells[0].Value.ToString();
                Modname.Text = row.Cells[1].Value.ToString();
                Modsdt.Text = row.Cells[2].Value.ToString();
                Moddc.Text = row.Cells[3].Value.ToString();
                Modrank.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
