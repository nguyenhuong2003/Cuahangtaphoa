namespace GUI
{
    partial class GUI_HoaDonNhap
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
            this.grbHDN = new System.Windows.Forms.GroupBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.btnMoi = new System.Windows.Forms.Button();
            this.cbbNV = new System.Windows.Forms.ComboBox();
            this.cbbNCC = new System.Windows.Forms.ComboBox();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.btnSuaHD = new System.Windows.Forms.Button();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.dgvHoaDonNhap = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.txtMaHDN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cbbMaMatHang = new System.Windows.Forms.ComboBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dgvcthdn = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.grbHDN.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcthdn)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbHDN
            // 
            this.grbHDN.Controls.Add(this.lblTongTien);
            this.grbHDN.Controls.Add(this.label9);
            this.grbHDN.Controls.Add(this.btnMoi);
            this.grbHDN.Controls.Add(this.cbbNV);
            this.grbHDN.Controls.Add(this.cbbNCC);
            this.grbHDN.Controls.Add(this.btnXoaHD);
            this.grbHDN.Controls.Add(this.btnSuaHD);
            this.grbHDN.Controls.Add(this.btnThemHD);
            this.grbHDN.Controls.Add(this.dgvHoaDonNhap);
            this.grbHDN.Controls.Add(this.label8);
            this.grbHDN.Controls.Add(this.dtNgayNhap);
            this.grbHDN.Controls.Add(this.txtMaHDN);
            this.grbHDN.Controls.Add(this.label3);
            this.grbHDN.Controls.Add(this.label2);
            this.grbHDN.Controls.Add(this.label1);
            this.grbHDN.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbHDN.Location = new System.Drawing.Point(31, 85);
            this.grbHDN.Name = "grbHDN";
            this.grbHDN.Size = new System.Drawing.Size(697, 642);
            this.grbHDN.TabIndex = 0;
            this.grbHDN.TabStop = false;
            this.grbHDN.Text = "Hóa Đơn Nhập";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(114, 168);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(20, 22);
            this.lblTongTien.TabIndex = 17;
            this.lblTongTien.Text = "0";
            this.lblTongTien.UseMnemonic = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(17, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 22);
            this.label9.TabIndex = 16;
            this.label9.Text = "Tổng Tiền";
            // 
            // btnMoi
            // 
            this.btnMoi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoi.ForeColor = System.Drawing.Color.White;
            this.btnMoi.Image = global::GUI.Properties.Resources.refresh;
            this.btnMoi.Location = new System.Drawing.Point(550, 223);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(117, 51);
            this.btnMoi.TabIndex = 9;
            this.btnMoi.Text = "Mới";
            this.btnMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMoi.UseVisualStyleBackColor = false;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // cbbNV
            // 
            this.cbbNV.FormattingEnabled = true;
            this.cbbNV.Location = new System.Drawing.Point(496, 107);
            this.cbbNV.Name = "cbbNV";
            this.cbbNV.Size = new System.Drawing.Size(156, 30);
            this.cbbNV.TabIndex = 4;
            // 
            // cbbNCC
            // 
            this.cbbNCC.FormattingEnabled = true;
            this.cbbNCC.Location = new System.Drawing.Point(496, 51);
            this.cbbNCC.Name = "cbbNCC";
            this.cbbNCC.Size = new System.Drawing.Size(156, 30);
            this.cbbNCC.TabIndex = 2;
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnXoaHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaHD.ForeColor = System.Drawing.Color.White;
            this.btnXoaHD.Image = global::GUI.Properties.Resources.trash__1_;
            this.btnXoaHD.Location = new System.Drawing.Point(379, 223);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(118, 51);
            this.btnXoaHD.TabIndex = 8;
            this.btnXoaHD.Text = "Xóa";
            this.btnXoaHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaHD.UseVisualStyleBackColor = false;
            this.btnXoaHD.Click += new System.EventHandler(this.btnXoaHD_Click);
            // 
            // btnSuaHD
            // 
            this.btnSuaHD.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSuaHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaHD.ForeColor = System.Drawing.Color.White;
            this.btnSuaHD.Image = global::GUI.Properties.Resources.user_pen;
            this.btnSuaHD.Location = new System.Drawing.Point(208, 223);
            this.btnSuaHD.Name = "btnSuaHD";
            this.btnSuaHD.Size = new System.Drawing.Size(113, 51);
            this.btnSuaHD.TabIndex = 7;
            this.btnSuaHD.Text = "Sửa";
            this.btnSuaHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaHD.UseVisualStyleBackColor = false;
            this.btnSuaHD.Click += new System.EventHandler(this.btnSuaHD_Click);
            // 
            // btnThemHD
            // 
            this.btnThemHD.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThemHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemHD.ForeColor = System.Drawing.Color.White;
            this.btnThemHD.Image = global::GUI.Properties.Resources.add__1_;
            this.btnThemHD.Location = new System.Drawing.Point(35, 223);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(137, 51);
            this.btnThemHD.TabIndex = 6;
            this.btnThemHD.Text = "Thêm";
            this.btnThemHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemHD.UseVisualStyleBackColor = false;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // dgvHoaDonNhap
            // 
            this.dgvHoaDonNhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonNhap.Location = new System.Drawing.Point(21, 282);
            this.dgvHoaDonNhap.Name = "dgvHoaDonNhap";
            this.dgvHoaDonNhap.RowHeadersWidth = 51;
            this.dgvHoaDonNhap.RowTemplate.Height = 24;
            this.dgvHoaDonNhap.Size = new System.Drawing.Size(646, 340);
            this.dgvHoaDonNhap.TabIndex = 8;
            this.dgvHoaDonNhap.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDonNhap_CellClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 22);
            this.label8.TabIndex = 7;
            this.label8.Text = "Ngày nhập";
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.Location = new System.Drawing.Point(158, 104);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(163, 30);
            this.dtNgayNhap.TabIndex = 3;
            // 
            // txtMaHDN
            // 
            this.txtMaHDN.Location = new System.Drawing.Point(158, 46);
            this.txtMaHDN.Name = "txtMaHDN";
            this.txtMaHDN.Size = new System.Drawing.Size(163, 30);
            this.txtMaHDN.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhà cung cấp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(361, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nhân viên ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã hóa đơn nhập";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbl1);
            this.groupBox2.Controls.Add(this.btnThoat);
            this.groupBox2.Controls.Add(this.cbbMaMatHang);
            this.groupBox2.Controls.Add(this.textBox5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.dgvcthdn);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtthanhtien);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(767, 85);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(658, 642);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chi tiết hóa đơn nhập";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Red;
            this.lbl1.Location = new System.Drawing.Point(383, 79);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(85, 22);
            this.lbl1.TabIndex = 18;
            this.lbl1.Text = "CanhBao";
            this.lbl1.UseMnemonic = false;
            this.lbl1.Visible = false;
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThoat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Image = global::GUI.Properties.Resources.cross__1_;
            this.btnThoat.Location = new System.Drawing.Point(511, 212);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 51);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cbbMaMatHang
            // 
            this.cbbMaMatHang.FormattingEnabled = true;
            this.cbbMaMatHang.Location = new System.Drawing.Point(144, 38);
            this.cbbMaMatHang.Name = "cbbMaMatHang";
            this.cbbMaMatHang.Size = new System.Drawing.Size(171, 30);
            this.cbbMaMatHang.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(144, 104);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(177, 30);
            this.textBox5.TabIndex = 12;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            this.textBox5.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox5_KeyPress);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Image = global::GUI.Properties.Resources.trash__1_;
            this.button6.Location = new System.Drawing.Point(359, 212);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(115, 51);
            this.button6.TabIndex = 16;
            this.button6.Text = "Xóa";
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Image = global::GUI.Properties.Resources.user_pen;
            this.button5.Location = new System.Drawing.Point(194, 212);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(115, 51);
            this.button5.TabIndex = 15;
            this.button5.Text = "Sửa";
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = global::GUI.Properties.Resources.add__1_;
            this.button4.Location = new System.Drawing.Point(32, 212);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 51);
            this.button4.TabIndex = 14;
            this.button4.Text = "Thêm";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dgvcthdn
            // 
            this.dgvcthdn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcthdn.Location = new System.Drawing.Point(32, 282);
            this.dgvcthdn.Name = "dgvcthdn";
            this.dgvcthdn.RowHeadersWidth = 51;
            this.dgvcthdn.RowTemplate.Height = 24;
            this.dgvcthdn.Size = new System.Drawing.Size(607, 340);
            this.dgvcthdn.TabIndex = 4;
            this.dgvcthdn.CellBorderStyleChanged += new System.EventHandler(this.dgvcthdn_CellBorderStyleChanged);
            this.dgvcthdn.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcthdn_CellClick);
            this.dgvcthdn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcthdn_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(344, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 22);
            this.label7.TabIndex = 3;
            this.label7.Text = "Thành tiền";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(341, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 22);
            this.label6.TabIndex = 2;
            this.label6.Text = "Đơn giá nhập";
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.Location = new System.Drawing.Point(462, 104);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.Size = new System.Drawing.Size(190, 30);
            this.txtthanhtien.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 22);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số lượng nhập";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(462, 41);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(190, 30);
            this.textBox2.TabIndex = 11;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.textBox2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 22);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã mặt hàng";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(12, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1413, 72);
            this.panel1.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(612, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(241, 35);
            this.label11.TabIndex = 0;
            this.label11.Text = "Cửa hàng tạp hóa";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // GUI_HoaDonNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 739);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbHDN);
            this.Name = "GUI_HoaDonNhap";
            this.Text = "GUI_HoaDonNhap";
            this.Load += new System.EventHandler(this.GUI_HoaDonNhap_Load);
            this.grbHDN.ResumeLayout(false);
            this.grbHDN.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonNhap)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcthdn)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbHDN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtthanhtien;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtMaHDN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbNV;
        private System.Windows.Forms.ComboBox cbbNCC;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.Button btnSuaHD;
        private System.Windows.Forms.DataGridView dgvHoaDonNhap;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dgvcthdn;
        private System.Windows.Forms.ComboBox cbbMaMatHang;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblTongTien;
    }
}