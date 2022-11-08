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
    public partial class frmMenu : Form
    {
        bool Thoat = true;
        public frmMenu()
        {
            InitializeComponent();
        }

        private void moderatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMod fMod = new frmMod();
            fMod.Show();
        }

        private void ngườiMuaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNM fNM = new frmNM();
            fNM.Show();
        }

        private void ngườiBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNB fNB = new frmNB();
            fNB.Show();
        }

        private void vậtPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVP fVP = new frmVP();
            fVP.Show();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thoat = false;
            LogIn flogin = new LogIn();
            flogin.Show();
            this.Hide();
        }

        private void frmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(Thoat)
            Application.Exit();
        }

        private void thanhToánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHD fHD = new frmHD();
            fHD.Show();
        }
    }
}
