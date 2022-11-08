
namespace PMQL
{
    partial class frmNM
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
            this.button1 = new System.Windows.Forms.Button();
            this.NMdgv = new System.Windows.Forms.DataGridView();
            this.NMstk = new System.Windows.Forms.TextBox();
            this.NMname = new System.Windows.Forms.TextBox();
            this.NMid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Src = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.Upd = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NMdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(423, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Làm mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NMdgv
            // 
            this.NMdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NMdgv.Location = new System.Drawing.Point(56, 207);
            this.NMdgv.Name = "NMdgv";
            this.NMdgv.Size = new System.Drawing.Size(479, 215);
            this.NMdgv.TabIndex = 15;
            this.NMdgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NMdgv_CellClick);
            // 
            // NMstk
            // 
            this.NMstk.Location = new System.Drawing.Point(205, 122);
            this.NMstk.Name = "NMstk";
            this.NMstk.Size = new System.Drawing.Size(159, 20);
            this.NMstk.TabIndex = 2;
            // 
            // NMname
            // 
            this.NMname.Location = new System.Drawing.Point(205, 89);
            this.NMname.Name = "NMname";
            this.NMname.Size = new System.Drawing.Size(159, 20);
            this.NMname.TabIndex = 1;
            // 
            // NMid
            // 
            this.NMid.Location = new System.Drawing.Point(205, 58);
            this.NMid.Name = "NMid";
            this.NMid.Size = new System.Drawing.Size(159, 20);
            this.NMid.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số tài khoản Steam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên người mua";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Mã người mua";
            // 
            // Src
            // 
            this.Src.Location = new System.Drawing.Point(423, 137);
            this.Src.Name = "Src";
            this.Src.Size = new System.Drawing.Size(75, 23);
            this.Src.TabIndex = 6;
            this.Src.Text = "Tìm kiếm";
            this.Src.UseVisualStyleBackColor = true;
            this.Src.Click += new System.EventHandler(this.Src_Click);
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(423, 99);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(75, 23);
            this.Del.TabIndex = 5;
            this.Del.Text = "Xóa";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Upd
            // 
            this.Upd.Location = new System.Drawing.Point(423, 66);
            this.Upd.Name = "Upd";
            this.Upd.Size = new System.Drawing.Size(75, 23);
            this.Upd.TabIndex = 4;
            this.Upd.Text = "Sửa";
            this.Upd.UseVisualStyleBackColor = true;
            this.Upd.Click += new System.EventHandler(this.Upd_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(423, 35);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 3;
            this.Add.Text = "Thêm";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // frmNM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(609, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NMdgv);
            this.Controls.Add(this.NMstk);
            this.Controls.Add(this.NMname);
            this.Controls.Add(this.NMid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Src);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.Upd);
            this.Controls.Add(this.Add);
            this.Name = "frmNM";
            this.Text = "Người Mua";
            ((System.ComponentModel.ISupportInitialize)(this.NMdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView NMdgv;
        private System.Windows.Forms.TextBox NMstk;
        private System.Windows.Forms.TextBox NMname;
        private System.Windows.Forms.TextBox NMid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Src;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button Upd;
        private System.Windows.Forms.Button Add;
    }
}