namespace GUI
{
    partial class GUI_HoaDonBan
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
            this.grpNhapHDB = new System.Windows.Forms.GroupBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.btnMoi = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvHoaDonBan = new System.Windows.Forms.DataGridView();
            this.btnXoaHD = new System.Windows.Forms.Button();
            this.btnSuaHD = new System.Windows.Forms.Button();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.cbbKH = new System.Windows.Forms.ComboBox();
            this.cbbNV = new System.Windows.Forms.ComboBox();
            this.dtNgayBan = new System.Windows.Forms.DateTimePicker();
            this.txtMaHDB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpNhapCTHDB = new System.Windows.Forms.GroupBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cbbMaMatHang = new System.Windows.Forms.ComboBox();
            this.txtSLB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvcthdb = new System.Windows.Forms.DataGridView();
            this.btnXoaCT = new System.Windows.Forms.Button();
            this.btnSuaCT = new System.Windows.Forms.Button();
            this.btnThemCT = new System.Windows.Forms.Button();
            this.txtthanhtien = new System.Windows.Forms.TextBox();
            this.txtdongia = new System.Windows.Forms.TextBox();
            this.txtgiamgia = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.grpNhapHDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBan)).BeginInit();
            this.grpNhapCTHDB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcthdb)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpNhapHDB
            // 
            this.grpNhapHDB.Controls.Add(this.lblTongTien);
            this.grpNhapHDB.Controls.Add(this.btnMoi);
            this.grpNhapHDB.Controls.Add(this.label10);
            this.grpNhapHDB.Controls.Add(this.dgvHoaDonBan);
            this.grpNhapHDB.Controls.Add(this.btnXoaHD);
            this.grpNhapHDB.Controls.Add(this.btnSuaHD);
            this.grpNhapHDB.Controls.Add(this.btnThemHD);
            this.grpNhapHDB.Controls.Add(this.cbbKH);
            this.grpNhapHDB.Controls.Add(this.cbbNV);
            this.grpNhapHDB.Controls.Add(this.dtNgayBan);
            this.grpNhapHDB.Controls.Add(this.txtMaHDB);
            this.grpNhapHDB.Controls.Add(this.label4);
            this.grpNhapHDB.Controls.Add(this.label3);
            this.grpNhapHDB.Controls.Add(this.label2);
            this.grpNhapHDB.Controls.Add(this.label1);
            this.grpNhapHDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNhapHDB.Location = new System.Drawing.Point(21, 87);
            this.grpNhapHDB.Name = "grpNhapHDB";
            this.grpNhapHDB.Size = new System.Drawing.Size(600, 627);
            this.grpNhapHDB.TabIndex = 0;
            this.grpNhapHDB.TabStop = false;
            this.grpNhapHDB.Text = "Hóa Đơn Bán";
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.ForeColor = System.Drawing.Color.Red;
            this.lblTongTien.Location = new System.Drawing.Point(105, 124);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(23, 25);
            this.lblTongTien.TabIndex = 18;
            this.lblTongTien.Text = "0";
            this.lblTongTien.UseMnemonic = false;
            this.lblTongTien.Click += new System.EventHandler(this.lblTongTien_Click);
            // 
            // btnMoi
            // 
            this.btnMoi.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoi.ForeColor = System.Drawing.Color.White;
            this.btnMoi.Image = global::GUI.Properties.Resources.refresh;
            this.btnMoi.Location = new System.Drawing.Point(445, 205);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(114, 62);
            this.btnMoi.TabIndex = 9;
            this.btnMoi.Text = "Mới";
            this.btnMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMoi.UseVisualStyleBackColor = false;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 25);
            this.label10.TabIndex = 13;
            this.label10.Text = "Tổng tiền";
            // 
            // dgvHoaDonBan
            // 
            this.dgvHoaDonBan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHoaDonBan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonBan.Location = new System.Drawing.Point(6, 297);
            this.dgvHoaDonBan.Name = "dgvHoaDonBan";
            this.dgvHoaDonBan.RowHeadersWidth = 51;
            this.dgvHoaDonBan.RowTemplate.Height = 24;
            this.dgvHoaDonBan.Size = new System.Drawing.Size(576, 315);
            this.dgvHoaDonBan.TabIndex = 11;
            this.dgvHoaDonBan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDonBan_CellClick);
            this.dgvHoaDonBan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDonBan_CellContentClick);
            // 
            // btnXoaHD
            // 
            this.btnXoaHD.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnXoaHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaHD.ForeColor = System.Drawing.Color.White;
            this.btnXoaHD.Image = global::GUI.Properties.Resources.trash__1_;
            this.btnXoaHD.Location = new System.Drawing.Point(309, 205);
            this.btnXoaHD.Name = "btnXoaHD";
            this.btnXoaHD.Size = new System.Drawing.Size(99, 62);
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
            this.btnSuaHD.Location = new System.Drawing.Point(162, 206);
            this.btnSuaHD.Name = "btnSuaHD";
            this.btnSuaHD.Size = new System.Drawing.Size(101, 61);
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
            this.btnThemHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemHD.ForeColor = System.Drawing.Color.White;
            this.btnThemHD.Image = global::GUI.Properties.Resources.add__1_;
            this.btnThemHD.Location = new System.Drawing.Point(30, 205);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(109, 62);
            this.btnThemHD.TabIndex = 6;
            this.btnThemHD.Text = "Thêm";
            this.btnThemHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemHD.UseVisualStyleBackColor = false;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // cbbKH
            // 
            this.cbbKH.FormattingEnabled = true;
            this.cbbKH.Location = new System.Drawing.Point(414, 86);
            this.cbbKH.Name = "cbbKH";
            this.cbbKH.Size = new System.Drawing.Size(180, 33);
            this.cbbKH.TabIndex = 4;
            // 
            // cbbNV
            // 
            this.cbbNV.FormattingEnabled = true;
            this.cbbNV.Location = new System.Drawing.Point(414, 33);
            this.cbbNV.Name = "cbbNV";
            this.cbbNV.Size = new System.Drawing.Size(180, 33);
            this.cbbNV.TabIndex = 2;
            // 
            // dtNgayBan
            // 
            this.dtNgayBan.Location = new System.Drawing.Point(105, 74);
            this.dtNgayBan.Name = "dtNgayBan";
            this.dtNgayBan.Size = new System.Drawing.Size(176, 30);
            this.dtNgayBan.TabIndex = 3;
            // 
            // txtMaHDB
            // 
            this.txtMaHDB.Location = new System.Drawing.Point(105, 33);
            this.txtMaHDB.Name = "txtMaHDB";
            this.txtMaHDB.Size = new System.Drawing.Size(158, 30);
            this.txtMaHDB.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Khách hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(290, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhân viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày bán";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã HDB";
            // 
            // grpNhapCTHDB
            // 
            this.grpNhapCTHDB.Controls.Add(this.lbl2);
            this.grpNhapCTHDB.Controls.Add(this.lbl1);
            this.grpNhapCTHDB.Controls.Add(this.btnThoat);
            this.grpNhapCTHDB.Controls.Add(this.cbbMaMatHang);
            this.grpNhapCTHDB.Controls.Add(this.txtSLB);
            this.grpNhapCTHDB.Controls.Add(this.label9);
            this.grpNhapCTHDB.Controls.Add(this.dgvcthdb);
            this.grpNhapCTHDB.Controls.Add(this.btnXoaCT);
            this.grpNhapCTHDB.Controls.Add(this.btnSuaCT);
            this.grpNhapCTHDB.Controls.Add(this.btnThemCT);
            this.grpNhapCTHDB.Controls.Add(this.txtthanhtien);
            this.grpNhapCTHDB.Controls.Add(this.txtdongia);
            this.grpNhapCTHDB.Controls.Add(this.txtgiamgia);
            this.grpNhapCTHDB.Controls.Add(this.label8);
            this.grpNhapCTHDB.Controls.Add(this.label5);
            this.grpNhapCTHDB.Controls.Add(this.label7);
            this.grpNhapCTHDB.Controls.Add(this.label6);
            this.grpNhapCTHDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpNhapCTHDB.Location = new System.Drawing.Point(643, 87);
            this.grpNhapCTHDB.Name = "grpNhapCTHDB";
            this.grpNhapCTHDB.Size = new System.Drawing.Size(589, 627);
            this.grpNhapCTHDB.TabIndex = 1;
            this.grpNhapCTHDB.TabStop = false;
            this.grpNhapCTHDB.Text = "Chi tiết hóa đơn bán";
            this.grpNhapCTHDB.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.ForeColor = System.Drawing.Color.Red;
            this.lbl2.Location = new System.Drawing.Point(29, 108);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(85, 22);
            this.lbl2.TabIndex = 21;
            this.lbl2.Text = "CanhBao";
            this.lbl2.UseMnemonic = false;
            this.lbl2.Visible = false;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.ForeColor = System.Drawing.Color.Red;
            this.lbl1.Location = new System.Drawing.Point(293, 61);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(85, 22);
            this.lbl1.TabIndex = 19;
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
            this.btnThoat.Location = new System.Drawing.Point(440, 205);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(118, 54);
            this.btnThoat.TabIndex = 18;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click_1);
            // 
            // cbbMaMatHang
            // 
            this.cbbMaMatHang.FormattingEnabled = true;
            this.cbbMaMatHang.Location = new System.Drawing.Point(143, 33);
            this.cbbMaMatHang.Name = "cbbMaMatHang";
            this.cbbMaMatHang.Size = new System.Drawing.Size(124, 33);
            this.cbbMaMatHang.TabIndex = 10;
            this.cbbMaMatHang.SelectedIndexChanged += new System.EventHandler(this.cbbMaMatHang_SelectedIndexChanged);
            this.cbbMaMatHang.TextChanged += new System.EventHandler(this.cbbMaMatHang_TextChanged);
            // 
            // txtSLB
            // 
            this.txtSLB.Location = new System.Drawing.Point(143, 83);
            this.txtSLB.Name = "txtSLB";
            this.txtSLB.Size = new System.Drawing.Size(124, 30);
            this.txtSLB.TabIndex = 12;
            this.txtSLB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSLB_KeyPress_1);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 83);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 25);
            this.label9.TabIndex = 14;
            this.label9.Text = "SLBan";
            // 
            // dgvcthdb
            // 
            this.dgvcthdb.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcthdb.Location = new System.Drawing.Point(33, 283);
            this.dgvcthdb.Name = "dgvcthdb";
            this.dgvcthdb.RowHeadersWidth = 51;
            this.dgvcthdb.RowTemplate.Height = 24;
            this.dgvcthdb.Size = new System.Drawing.Size(531, 315);
            this.dgvcthdb.TabIndex = 13;
            this.dgvcthdb.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcthdb_CellClick);
            this.dgvcthdb.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcthdb_CellContentClick);
            // 
            // btnXoaCT
            // 
            this.btnXoaCT.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnXoaCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaCT.ForeColor = System.Drawing.Color.White;
            this.btnXoaCT.Image = global::GUI.Properties.Resources.trash__1_;
            this.btnXoaCT.Location = new System.Drawing.Point(304, 205);
            this.btnXoaCT.Name = "btnXoaCT";
            this.btnXoaCT.Size = new System.Drawing.Size(118, 59);
            this.btnXoaCT.TabIndex = 17;
            this.btnXoaCT.Text = "XoáCT";
            this.btnXoaCT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoaCT.UseVisualStyleBackColor = false;
            this.btnXoaCT.Click += new System.EventHandler(this.btnXoaCT_Click_1);
            // 
            // btnSuaCT
            // 
            this.btnSuaCT.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnSuaCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaCT.ForeColor = System.Drawing.Color.White;
            this.btnSuaCT.Image = global::GUI.Properties.Resources.user_pen;
            this.btnSuaCT.Location = new System.Drawing.Point(164, 205);
            this.btnSuaCT.Name = "btnSuaCT";
            this.btnSuaCT.Size = new System.Drawing.Size(123, 59);
            this.btnSuaCT.TabIndex = 16;
            this.btnSuaCT.Text = "SửaCT";
            this.btnSuaCT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSuaCT.UseVisualStyleBackColor = false;
            this.btnSuaCT.Click += new System.EventHandler(this.btnSuaCT_Click);
            // 
            // btnThemCT
            // 
            this.btnThemCT.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnThemCT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemCT.ForeColor = System.Drawing.Color.White;
            this.btnThemCT.Image = global::GUI.Properties.Resources.add__1_;
            this.btnThemCT.Location = new System.Drawing.Point(19, 205);
            this.btnThemCT.Name = "btnThemCT";
            this.btnThemCT.Size = new System.Drawing.Size(129, 62);
            this.btnThemCT.TabIndex = 15;
            this.btnThemCT.Text = "ThêmCT";
            this.btnThemCT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThemCT.UseVisualStyleBackColor = false;
            this.btnThemCT.Click += new System.EventHandler(this.btnThemCT_Click);
            // 
            // txtthanhtien
            // 
            this.txtthanhtien.Location = new System.Drawing.Point(384, 121);
            this.txtthanhtien.Name = "txtthanhtien";
            this.txtthanhtien.Size = new System.Drawing.Size(144, 30);
            this.txtthanhtien.TabIndex = 13;
            this.txtthanhtien.TextChanged += new System.EventHandler(this.txtthanhtien_TextChanged);
            // 
            // txtdongia
            // 
            this.txtdongia.Location = new System.Drawing.Point(374, 28);
            this.txtdongia.Name = "txtdongia";
            this.txtdongia.Size = new System.Drawing.Size(144, 30);
            this.txtdongia.TabIndex = 11;
            this.txtdongia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtdongia_KeyPress_1);
            // 
            // txtgiamgia
            // 
            this.txtgiamgia.Location = new System.Drawing.Point(143, 136);
            this.txtgiamgia.Name = "txtgiamgia";
            this.txtgiamgia.Size = new System.Drawing.Size(124, 30);
            this.txtgiamgia.TabIndex = 14;
            this.txtgiamgia.TextChanged += new System.EventHandler(this.txtgiamgia_TextChanged);
            this.txtgiamgia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtgiamgia_KeyPress_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(273, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 25);
            this.label8.TabIndex = 7;
            this.label8.Text = "Thành tiền";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(5, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã mặt hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(273, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 6;
            this.label7.Text = "Đơn giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Giảm giá";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Location = new System.Drawing.Point(21, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1209, 72);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(495, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(241, 35);
            this.label11.TabIndex = 0;
            this.label11.Text = "Cửa hàng tạp hóa";
            // 
            // GUI_HoaDonBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 726);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpNhapCTHDB);
            this.Controls.Add(this.grpNhapHDB);
            this.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GUI_HoaDonBan";
            this.Text = "GUI_HoaDonBan";
            this.Load += new System.EventHandler(this.GUI_HoaDonBan_Load);
            this.grpNhapHDB.ResumeLayout(false);
            this.grpNhapHDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBan)).EndInit();
            this.grpNhapCTHDB.ResumeLayout(false);
            this.grpNhapCTHDB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcthdb)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpNhapHDB;
        private System.Windows.Forms.DataGridView dgvHoaDonBan;
        private System.Windows.Forms.Button btnXoaHD;
        private System.Windows.Forms.Button btnSuaHD;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.ComboBox cbbKH;
        private System.Windows.Forms.ComboBox cbbNV;
        private System.Windows.Forms.DateTimePicker dtNgayBan;
        private System.Windows.Forms.TextBox txtMaHDB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpNhapCTHDB;
        private System.Windows.Forms.DataGridView dgvcthdb;
        private System.Windows.Forms.Button btnXoaCT;
        private System.Windows.Forms.Button btnSuaCT;
        private System.Windows.Forms.Button btnThemCT;
        private System.Windows.Forms.TextBox txtthanhtien;
        private System.Windows.Forms.TextBox txtdongia;
        private System.Windows.Forms.TextBox txtgiamgia;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSLB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbMaMatHang;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblTongTien;
    }
}