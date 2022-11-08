
namespace PMQL
{
    partial class frmNB
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
            this.NBdgv = new System.Windows.Forms.DataGridView();
            this.NBstk = new System.Windows.Forms.TextBox();
            this.NBname = new System.Windows.Forms.TextBox();
            this.NBid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Src = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.Upd = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NBdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(421, 163);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Làm mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NBdgv
            // 
            this.NBdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NBdgv.Location = new System.Drawing.Point(54, 192);
            this.NBdgv.Name = "NBdgv";
            this.NBdgv.Size = new System.Drawing.Size(479, 215);
            this.NBdgv.TabIndex = 27;
            this.NBdgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NBdgv_CellClick);
            // 
            // NBstk
            // 
            this.NBstk.Location = new System.Drawing.Point(203, 107);
            this.NBstk.Name = "NBstk";
            this.NBstk.Size = new System.Drawing.Size(159, 20);
            this.NBstk.TabIndex = 2;
            // 
            // NBname
            // 
            this.NBname.Location = new System.Drawing.Point(203, 74);
            this.NBname.Name = "NBname";
            this.NBname.Size = new System.Drawing.Size(159, 20);
            this.NBname.TabIndex = 1;
            // 
            // NBid
            // 
            this.NBid.Location = new System.Drawing.Point(203, 43);
            this.NBid.Name = "NBid";
            this.NBid.Size = new System.Drawing.Size(159, 20);
            this.NBid.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(85, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Số tài khoản Steam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Tên người bán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Mã người bán";
            // 
            // Src
            // 
            this.Src.Location = new System.Drawing.Point(421, 122);
            this.Src.Name = "Src";
            this.Src.Size = new System.Drawing.Size(75, 23);
            this.Src.TabIndex = 6;
            this.Src.Text = "Tìm kiếm";
            this.Src.UseVisualStyleBackColor = true;
            this.Src.Click += new System.EventHandler(this.Src_Click);
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(421, 84);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(75, 23);
            this.Del.TabIndex = 5;
            this.Del.Text = "Xóa";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Upd
            // 
            this.Upd.Location = new System.Drawing.Point(421, 51);
            this.Upd.Name = "Upd";
            this.Upd.Size = new System.Drawing.Size(75, 23);
            this.Upd.TabIndex = 4;
            this.Upd.Text = "Sửa";
            this.Upd.UseVisualStyleBackColor = true;
            this.Upd.Click += new System.EventHandler(this.Upd_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(421, 20);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 3;
            this.Add.Text = "Thêm";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // frmNB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NBdgv);
            this.Controls.Add(this.NBstk);
            this.Controls.Add(this.NBname);
            this.Controls.Add(this.NBid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Src);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.Upd);
            this.Controls.Add(this.Add);
            this.Name = "frmNB";
            this.Text = "Người bán";
            ((System.ComponentModel.ISupportInitialize)(this.NBdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView NBdgv;
        private System.Windows.Forms.TextBox NBstk;
        private System.Windows.Forms.TextBox NBname;
        private System.Windows.Forms.TextBox NBid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Src;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button Upd;
        private System.Windows.Forms.Button Add;
    }
}