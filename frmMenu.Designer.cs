
namespace PMQL
{
    partial class frmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moderatorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngườiMuaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngườiBánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vậtPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thanhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.thanhToánToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moderatorToolStripMenuItem,
            this.ngườiMuaToolStripMenuItem,
            this.ngườiBánToolStripMenuItem,
            this.vậtPhẩmToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // moderatorToolStripMenuItem
            // 
            this.moderatorToolStripMenuItem.Name = "moderatorToolStripMenuItem";
            this.moderatorToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.moderatorToolStripMenuItem.Text = "Moderator";
            this.moderatorToolStripMenuItem.Click += new System.EventHandler(this.moderatorToolStripMenuItem_Click);
            // 
            // ngườiMuaToolStripMenuItem
            // 
            this.ngườiMuaToolStripMenuItem.Name = "ngườiMuaToolStripMenuItem";
            this.ngườiMuaToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.ngườiMuaToolStripMenuItem.Text = "Người mua";
            this.ngườiMuaToolStripMenuItem.Click += new System.EventHandler(this.ngườiMuaToolStripMenuItem_Click);
            // 
            // ngườiBánToolStripMenuItem
            // 
            this.ngườiBánToolStripMenuItem.Name = "ngườiBánToolStripMenuItem";
            this.ngườiBánToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.ngườiBánToolStripMenuItem.Text = "Người bán";
            this.ngườiBánToolStripMenuItem.Click += new System.EventHandler(this.ngườiBánToolStripMenuItem_Click);
            // 
            // vậtPhẩmToolStripMenuItem
            // 
            this.vậtPhẩmToolStripMenuItem.Name = "vậtPhẩmToolStripMenuItem";
            this.vậtPhẩmToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.vậtPhẩmToolStripMenuItem.Text = "Vật phẩm";
            this.vậtPhẩmToolStripMenuItem.Click += new System.EventHandler(this.vậtPhẩmToolStripMenuItem_Click);
            // 
            // thanhToánToolStripMenuItem
            // 
            this.thanhToánToolStripMenuItem.Name = "thanhToánToolStripMenuItem";
            this.thanhToánToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.thanhToánToolStripMenuItem.Text = "Thanh toán";
            this.thanhToánToolStripMenuItem.Click += new System.EventHandler(this.thanhToánToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.Text = "Menu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMenu_FormClosed);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moderatorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngườiMuaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngườiBánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vậtPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thanhToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}