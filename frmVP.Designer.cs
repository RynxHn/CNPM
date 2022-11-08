
namespace PMQL
{
    partial class frmVP
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
            this.VPrarity = new System.Windows.Forms.ComboBox();
            this.VPtype = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.VPdgv = new System.Windows.Forms.DataGridView();
            this.VPprice = new System.Windows.Forms.TextBox();
            this.VPname = new System.Windows.Forms.TextBox();
            this.VPid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Src = new System.Windows.Forms.Button();
            this.Del = new System.Windows.Forms.Button();
            this.Upd = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.VPdgv)).BeginInit();
            this.SuspendLayout();
            // 
            // VPrarity
            // 
            this.VPrarity.FormattingEnabled = true;
            this.VPrarity.Items.AddRange(new object[] {
            "",
            "Consumer",
            "Industrial",
            "Mil-spec",
            "Restrcted",
            "Classified",
            "Covert",
            "Contraband"});
            this.VPrarity.Location = new System.Drawing.Point(224, 173);
            this.VPrarity.Name = "VPrarity";
            this.VPrarity.Size = new System.Drawing.Size(159, 21);
            this.VPrarity.TabIndex = 4;
            // 
            // VPtype
            // 
            this.VPtype.FormattingEnabled = true;
            this.VPtype.Items.AddRange(new object[] {
            "",
            "Knives",
            "Gloves",
            "Pistols",
            "SMGs",
            "Assault Rifles",
            "Sniper Rifles",
            "Shotguns",
            "Machine Guns"});
            this.VPtype.Location = new System.Drawing.Point(224, 139);
            this.VPtype.Name = "VPtype";
            this.VPtype.Size = new System.Drawing.Size(159, 21);
            this.VPtype.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(441, 176);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Làm mới";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // VPdgv
            // 
            this.VPdgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VPdgv.Location = new System.Drawing.Point(37, 263);
            this.VPdgv.Name = "VPdgv";
            this.VPdgv.Size = new System.Drawing.Size(569, 215);
            this.VPdgv.TabIndex = 42;
            this.VPdgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VPdgv_CellClick);
            this.VPdgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.VPdgv_CellContentClick);
            // 
            // VPprice
            // 
            this.VPprice.Location = new System.Drawing.Point(224, 104);
            this.VPprice.Name = "VPprice";
            this.VPprice.Size = new System.Drawing.Size(159, 20);
            this.VPprice.TabIndex = 2;
            // 
            // VPname
            // 
            this.VPname.Location = new System.Drawing.Point(224, 71);
            this.VPname.Name = "VPname";
            this.VPname.Size = new System.Drawing.Size(159, 20);
            this.VPname.TabIndex = 1;
            // 
            // VPid
            // 
            this.VPid.Location = new System.Drawing.Point(224, 40);
            this.VPid.Name = "VPid";
            this.VPid.Size = new System.Drawing.Size(159, 20);
            this.VPid.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 176);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Độ hiếm";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Thể loại";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Tên vật phẩm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(106, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Mã vật phẩm";
            // 
            // Src
            // 
            this.Src.Location = new System.Drawing.Point(441, 140);
            this.Src.Name = "Src";
            this.Src.Size = new System.Drawing.Size(75, 23);
            this.Src.TabIndex = 8;
            this.Src.Text = "Tìm kiếm";
            this.Src.UseVisualStyleBackColor = true;
            this.Src.Click += new System.EventHandler(this.Src_Click);
            // 
            // Del
            // 
            this.Del.Location = new System.Drawing.Point(441, 102);
            this.Del.Name = "Del";
            this.Del.Size = new System.Drawing.Size(75, 23);
            this.Del.TabIndex = 7;
            this.Del.Text = "Xóa";
            this.Del.UseVisualStyleBackColor = true;
            this.Del.Click += new System.EventHandler(this.Del_Click);
            // 
            // Upd
            // 
            this.Upd.Location = new System.Drawing.Point(441, 67);
            this.Upd.Name = "Upd";
            this.Upd.Size = new System.Drawing.Size(75, 23);
            this.Upd.TabIndex = 6;
            this.Upd.Text = "Sửa";
            this.Upd.UseVisualStyleBackColor = true;
            this.Upd.Click += new System.EventHandler(this.Upd_Click);
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(441, 33);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 5;
            this.Add.Text = "Thêm";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // frmVP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 514);
            this.Controls.Add(this.VPrarity);
            this.Controls.Add(this.VPtype);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.VPdgv);
            this.Controls.Add(this.VPprice);
            this.Controls.Add(this.VPname);
            this.Controls.Add(this.VPid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Src);
            this.Controls.Add(this.Del);
            this.Controls.Add(this.Upd);
            this.Controls.Add(this.Add);
            this.Name = "frmVP";
            this.Text = "Vật phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.VPdgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox VPrarity;
        private System.Windows.Forms.ComboBox VPtype;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView VPdgv;
        private System.Windows.Forms.TextBox VPprice;
        private System.Windows.Forms.TextBox VPname;
        private System.Windows.Forms.TextBox VPid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Src;
        private System.Windows.Forms.Button Del;
        private System.Windows.Forms.Button Upd;
        private System.Windows.Forms.Button Add;
    }
}