
namespace PMQL
{
    partial class frmMod
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
            this.Moddgv = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.Src = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.Upd = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Modrank = new System.Windows.Forms.ComboBox();
            this.Moddc = new System.Windows.Forms.TextBox();
            this.Modsdt = new System.Windows.Forms.TextBox();
            this.Modname = new System.Windows.Forms.TextBox();
            this.Modid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Moddgv)).BeginInit();
            this.SuspendLayout();
            // 
            // Moddgv
            // 
            this.Moddgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Moddgv.Location = new System.Drawing.Point(34, 185);
            this.Moddgv.Name = "Moddgv";
            this.Moddgv.Size = new System.Drawing.Size(499, 241);
            this.Moddgv.TabIndex = 20;
            this.Moddgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Moddgv_CellClick);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(409, 134);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Làm mới";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Src
            // 
            this.Src.Location = new System.Drawing.Point(409, 105);
            this.Src.Name = "Src";
            this.Src.Size = new System.Drawing.Size(75, 23);
            this.Src.TabIndex = 8;
            this.Src.Text = "Tìm kiếm";
            this.Src.UseVisualStyleBackColor = true;
            this.Src.Click += new System.EventHandler(this.Src_Click);
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(409, 76);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(75, 23);
            this.Del.TabIndex = 7;
            this.Del.Text = "Xóa";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Upd
            // 
            this.Upd.Location = new System.Drawing.Point(409, 47);
            this.Upd.Name = "Upd";
            this.Upd.Size = new System.Drawing.Size(75, 23);
            this.Upd.TabIndex = 6;
            this.Upd.Text = "Sửa";
            this.Upd.UseVisualStyleBackColor = true;
            this.Upd.Click += new System.EventHandler(this.Upd_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(409, 19);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 5;
            this.Add.Text = "Thêm";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Modrank
            // 
            this.Modrank.FormattingEnabled = true;
            this.Modrank.Items.AddRange(new object[] {
            "",
            "Bronze",
            "Silver",
            "Gold"});
            this.Modrank.Location = new System.Drawing.Point(192, 134);
            this.Modrank.Name = "Modrank";
            this.Modrank.Size = new System.Drawing.Size(165, 21);
            this.Modrank.TabIndex = 4;
            // 
            // Moddc
            // 
            this.Moddc.Location = new System.Drawing.Point(192, 108);
            this.Moddc.Name = "Moddc";
            this.Moddc.Size = new System.Drawing.Size(165, 20);
            this.Moddc.TabIndex = 3;
            // 
            // Modsdt
            // 
            this.Modsdt.Location = new System.Drawing.Point(192, 78);
            this.Modsdt.Name = "Modsdt";
            this.Modsdt.Size = new System.Drawing.Size(165, 20);
            this.Modsdt.TabIndex = 2;
            // 
            // Modname
            // 
            this.Modname.Location = new System.Drawing.Point(192, 52);
            this.Modname.Name = "Modname";
            this.Modname.Size = new System.Drawing.Size(165, 20);
            this.Modname.TabIndex = 1;
            // 
            // Modid
            // 
            this.Modid.Location = new System.Drawing.Point(192, 26);
            this.Modid.Name = "Modid";
            this.Modid.Size = new System.Drawing.Size(165, 20);
            this.Modid.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(95, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Cấp bậc";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(95, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tên moderator";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã moderator";
            // 
            // frmMod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.Moddgv);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.Src);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.Upd);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.Modrank);
            this.Controls.Add(this.Moddc);
            this.Controls.Add(this.Modsdt);
            this.Controls.Add(this.Modname);
            this.Controls.Add(this.Modid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMod";
            this.Text = "Moderator";
            ((System.ComponentModel.ISupportInitialize)(this.Moddgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Moddgv;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Src;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button Upd;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ComboBox Modrank;
        private System.Windows.Forms.TextBox Moddc;
        private System.Windows.Forms.TextBox Modsdt;
        private System.Windows.Forms.TextBox Modname;
        private System.Windows.Forms.TextBox Modid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}