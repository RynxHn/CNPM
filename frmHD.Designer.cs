
namespace PMQL
{
    partial class frmHD
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
            this.label1 = new System.Windows.Forms.Label();
            this.idHD = new System.Windows.Forms.TextBox();
            this.ptttHD = new System.Windows.Forms.ComboBox();
            this.ngdHD = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nameVP_HD = new System.Windows.Forms.TextBox();
            this.nameNM_HD = new System.Windows.Forms.TextBox();
            this.nameNB_HD = new System.Windows.Forms.TextBox();
            this.giaHD = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Print = new System.Windows.Forms.Button();
            this.dgvHD = new System.Windows.Forms.DataGridView();
            this.dgvNM = new System.Windows.Forms.DataGridView();
            this.dgvNB = new System.Windows.Forms.DataGridView();
            this.dgvVP = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn";
            // 
            // idHD
            // 
            this.idHD.Location = new System.Drawing.Point(191, 47);
            this.idHD.Name = "idHD";
            this.idHD.Size = new System.Drawing.Size(183, 20);
            this.idHD.TabIndex = 0;
            // 
            // ptttHD
            // 
            this.ptttHD.FormattingEnabled = true;
            this.ptttHD.Items.AddRange(new object[] {
            "",
            "The",
            "Sec truc tuyen",
            "Vi dien tu"});
            this.ptttHD.Location = new System.Drawing.Point(218, 176);
            this.ptttHD.Name = "ptttHD";
            this.ptttHD.Size = new System.Drawing.Size(156, 21);
            this.ptttHD.TabIndex = 5;
            // 
            // ngdHD
            // 
            this.ngdHD.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ngdHD.Location = new System.Drawing.Point(218, 203);
            this.ngdHD.Name = "ngdHD";
            this.ngdHD.Size = new System.Drawing.Size(156, 20);
            this.ngdHD.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên vật phẩm";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(90, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tên người mua";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tên người bán";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(90, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 179);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Phương thức thanh toán";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ngày giao dịch";
            // 
            // nameVP_HD
            // 
            this.nameVP_HD.Location = new System.Drawing.Point(191, 72);
            this.nameVP_HD.Name = "nameVP_HD";
            this.nameVP_HD.Size = new System.Drawing.Size(183, 20);
            this.nameVP_HD.TabIndex = 1;
            // 
            // nameNM_HD
            // 
            this.nameNM_HD.Location = new System.Drawing.Point(191, 100);
            this.nameNM_HD.Name = "nameNM_HD";
            this.nameNM_HD.Size = new System.Drawing.Size(183, 20);
            this.nameNM_HD.TabIndex = 2;
            // 
            // nameNB_HD
            // 
            this.nameNB_HD.Location = new System.Drawing.Point(191, 128);
            this.nameNB_HD.Name = "nameNB_HD";
            this.nameNB_HD.Size = new System.Drawing.Size(183, 20);
            this.nameNB_HD.TabIndex = 3;
            // 
            // giaHD
            // 
            this.giaHD.Location = new System.Drawing.Point(191, 152);
            this.giaHD.Name = "giaHD";
            this.giaHD.Size = new System.Drawing.Size(183, 20);
            this.giaHD.TabIndex = 4;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(439, 88);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 8;
            this.Add.Text = "Thanh toán";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Print
            // 
            this.Print.Location = new System.Drawing.Point(439, 131);
            this.Print.Name = "Print";
            this.Print.Size = new System.Drawing.Size(75, 23);
            this.Print.TabIndex = 9;
            this.Print.Text = "In hóa đơn";
            this.Print.UseVisualStyleBackColor = true;
            this.Print.Click += new System.EventHandler(this.Print_Click);
            // 
            // dgvHD
            // 
            this.dgvHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHD.Location = new System.Drawing.Point(12, 249);
            this.dgvHD.Name = "dgvHD";
            this.dgvHD.Size = new System.Drawing.Size(662, 331);
            this.dgvHD.TabIndex = 10;
            this.dgvHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHD_CellClick);
            // 
            // dgvNM
            // 
            this.dgvNM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNM.Location = new System.Drawing.Point(680, 12);
            this.dgvNM.Name = "dgvNM";
            this.dgvNM.Size = new System.Drawing.Size(132, 568);
            this.dgvNM.TabIndex = 11;
            this.dgvNM.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNM_CellClick);
            // 
            // dgvNB
            // 
            this.dgvNB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNB.Location = new System.Drawing.Point(818, 12);
            this.dgvNB.Name = "dgvNB";
            this.dgvNB.Size = new System.Drawing.Size(135, 568);
            this.dgvNB.TabIndex = 11;
            // 
            // dgvVP
            // 
            this.dgvVP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVP.Location = new System.Drawing.Point(959, 13);
            this.dgvVP.Name = "dgvVP";
            this.dgvVP.Size = new System.Drawing.Size(198, 568);
            this.dgvVP.TabIndex = 11;
            // 
            // frmHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 592);
            this.Controls.Add(this.dgvVP);
            this.Controls.Add(this.dgvNB);
            this.Controls.Add(this.dgvNM);
            this.Controls.Add(this.dgvHD);
            this.Controls.Add(this.Print);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.ngdHD);
            this.Controls.Add(this.ptttHD);
            this.Controls.Add(this.giaHD);
            this.Controls.Add(this.nameNB_HD);
            this.Controls.Add(this.nameNM_HD);
            this.Controls.Add(this.nameVP_HD);
            this.Controls.Add(this.idHD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHD";
            this.Text = "Thanh toán";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idHD;
        private System.Windows.Forms.ComboBox ptttHD;
        private System.Windows.Forms.DateTimePicker ngdHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameVP_HD;
        private System.Windows.Forms.TextBox nameNM_HD;
        private System.Windows.Forms.TextBox nameNB_HD;
        private System.Windows.Forms.TextBox giaHD;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Print;
        private System.Windows.Forms.DataGridView dgvHD;
        private System.Windows.Forms.DataGridView dgvNM;
        private System.Windows.Forms.DataGridView dgvNB;
        private System.Windows.Forms.DataGridView dgvVP;
    }
}