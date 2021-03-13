namespace QuanLyPhongTro
{
    partial class frmAdmin
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
            this.tpQuanLyPhong = new System.Windows.Forms.TabPage();
            this.btnXoaPhong = new System.Windows.Forms.Button();
            this.btnThemPhong = new System.Windows.Forms.Button();
            this.btnLamMoi3 = new System.Windows.Forms.Button();
            this.btnTimKiem3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimKiem3 = new System.Windows.Forms.TextBox();
            this.dgvQuanLyPhong = new System.Windows.Forms.DataGridView();
            this.maPhong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpQuanLyDichVu = new System.Windows.Forms.TabPage();
            this.btnXoaDichVu = new System.Windows.Forms.Button();
            this.btnSuaThongTin2 = new System.Windows.Forms.Button();
            this.btnThemDichVu = new System.Windows.Forms.Button();
            this.btnLamMoi2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimKiem2 = new System.Windows.Forms.TextBox();
            this.btnTimKiem2 = new System.Windows.Forms.Button();
            this.dgvQuanLyDichVu = new System.Windows.Forms.DataGridView();
            this.tenDichVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donViTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpQuanLyTaiKhoan = new System.Windows.Forms.TabPage();
            this.btnLamMoi = new System.Windows.Forms.Button();
            this.btnSuaThongTin = new System.Windows.Forms.Button();
            this.btnXoaTaiKhoan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.dgvQuanLyTaiKhoan = new System.Windows.Forms.DataGridView();
            this.tenDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenHienThi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.matKhau = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quyenHan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tcAdmin = new System.Windows.Forms.TabControl();
            this.tpLapHoaDon = new System.Windows.Forms.TabPage();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.txtHoaDon = new System.Windows.Forms.TextBox();
            this.dgvLapHoaDon = new System.Windows.Forms.DataGridView();
            this.maPhong2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.trangThai2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpQuanLyPhong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyPhong)).BeginInit();
            this.tpQuanLyDichVu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyDichVu)).BeginInit();
            this.tpQuanLyTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyTaiKhoan)).BeginInit();
            this.tcAdmin.SuspendLayout();
            this.tpLapHoaDon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLapHoaDon)).BeginInit();
            this.SuspendLayout();
            // 
            // tpQuanLyPhong
            // 
            this.tpQuanLyPhong.Controls.Add(this.btnXoaPhong);
            this.tpQuanLyPhong.Controls.Add(this.btnThemPhong);
            this.tpQuanLyPhong.Controls.Add(this.btnLamMoi3);
            this.tpQuanLyPhong.Controls.Add(this.btnTimKiem3);
            this.tpQuanLyPhong.Controls.Add(this.label4);
            this.tpQuanLyPhong.Controls.Add(this.txtTimKiem3);
            this.tpQuanLyPhong.Controls.Add(this.dgvQuanLyPhong);
            this.tpQuanLyPhong.Location = new System.Drawing.Point(4, 22);
            this.tpQuanLyPhong.Name = "tpQuanLyPhong";
            this.tpQuanLyPhong.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuanLyPhong.Size = new System.Drawing.Size(664, 332);
            this.tpQuanLyPhong.TabIndex = 2;
            this.tpQuanLyPhong.Text = "Quản lý phòng";
            this.tpQuanLyPhong.UseVisualStyleBackColor = true;
            // 
            // btnXoaPhong
            // 
            this.btnXoaPhong.Location = new System.Drawing.Point(568, 294);
            this.btnXoaPhong.Name = "btnXoaPhong";
            this.btnXoaPhong.Size = new System.Drawing.Size(90, 23);
            this.btnXoaPhong.TabIndex = 6;
            this.btnXoaPhong.Text = "Xóa phòng";
            this.btnXoaPhong.UseVisualStyleBackColor = true;
            this.btnXoaPhong.Click += new System.EventHandler(this.btnXoaPhong_Click);
            // 
            // btnThemPhong
            // 
            this.btnThemPhong.Location = new System.Drawing.Point(446, 294);
            this.btnThemPhong.Name = "btnThemPhong";
            this.btnThemPhong.Size = new System.Drawing.Size(90, 23);
            this.btnThemPhong.TabIndex = 5;
            this.btnThemPhong.Text = "Thêm phòng";
            this.btnThemPhong.UseVisualStyleBackColor = true;
            this.btnThemPhong.Click += new System.EventHandler(this.btnThemPhong_Click);
            // 
            // btnLamMoi3
            // 
            this.btnLamMoi3.Location = new System.Drawing.Point(322, 294);
            this.btnLamMoi3.Name = "btnLamMoi3";
            this.btnLamMoi3.Size = new System.Drawing.Size(90, 23);
            this.btnLamMoi3.TabIndex = 4;
            this.btnLamMoi3.Text = "Làm mới";
            this.btnLamMoi3.UseVisualStyleBackColor = true;
            this.btnLamMoi3.Click += new System.EventHandler(this.btnLamMoi3_Click);
            // 
            // btnTimKiem3
            // 
            this.btnTimKiem3.Location = new System.Drawing.Point(583, 6);
            this.btnTimKiem3.Name = "btnTimKiem3";
            this.btnTimKiem3.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem3.TabIndex = 3;
            this.btnTimKiem3.Text = "Tìm kiếm";
            this.btnTimKiem3.UseVisualStyleBackColor = true;
            this.btnTimKiem3.Click += new System.EventHandler(this.btnTimKiem3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(319, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã phòng";
            // 
            // txtTimKiem3
            // 
            this.txtTimKiem3.Location = new System.Drawing.Point(401, 6);
            this.txtTimKiem3.Name = "txtTimKiem3";
            this.txtTimKiem3.Size = new System.Drawing.Size(167, 20);
            this.txtTimKiem3.TabIndex = 1;
            // 
            // dgvQuanLyPhong
            // 
            this.dgvQuanLyPhong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanLyPhong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyPhong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhong,
            this.trangThai});
            this.dgvQuanLyPhong.Location = new System.Drawing.Point(3, 32);
            this.dgvQuanLyPhong.Name = "dgvQuanLyPhong";
            this.dgvQuanLyPhong.Size = new System.Drawing.Size(658, 247);
            this.dgvQuanLyPhong.TabIndex = 0;
            // 
            // maPhong
            // 
            this.maPhong.DataPropertyName = "maPhong";
            this.maPhong.HeaderText = "Mã phòng";
            this.maPhong.Name = "maPhong";
            // 
            // trangThai
            // 
            this.trangThai.DataPropertyName = "trangThai";
            this.trangThai.HeaderText = "Trạng thái";
            this.trangThai.Name = "trangThai";
            // 
            // tpQuanLyDichVu
            // 
            this.tpQuanLyDichVu.Controls.Add(this.btnXoaDichVu);
            this.tpQuanLyDichVu.Controls.Add(this.btnSuaThongTin2);
            this.tpQuanLyDichVu.Controls.Add(this.btnThemDichVu);
            this.tpQuanLyDichVu.Controls.Add(this.btnLamMoi2);
            this.tpQuanLyDichVu.Controls.Add(this.label3);
            this.tpQuanLyDichVu.Controls.Add(this.label2);
            this.tpQuanLyDichVu.Controls.Add(this.txtTimKiem2);
            this.tpQuanLyDichVu.Controls.Add(this.btnTimKiem2);
            this.tpQuanLyDichVu.Controls.Add(this.dgvQuanLyDichVu);
            this.tpQuanLyDichVu.Location = new System.Drawing.Point(4, 22);
            this.tpQuanLyDichVu.Name = "tpQuanLyDichVu";
            this.tpQuanLyDichVu.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuanLyDichVu.Size = new System.Drawing.Size(664, 332);
            this.tpQuanLyDichVu.TabIndex = 1;
            this.tpQuanLyDichVu.Text = "Quản lý dịch vụ";
            this.tpQuanLyDichVu.UseVisualStyleBackColor = true;
            // 
            // btnXoaDichVu
            // 
            this.btnXoaDichVu.Location = new System.Drawing.Point(568, 294);
            this.btnXoaDichVu.Name = "btnXoaDichVu";
            this.btnXoaDichVu.Size = new System.Drawing.Size(90, 23);
            this.btnXoaDichVu.TabIndex = 9;
            this.btnXoaDichVu.Text = "Xóa dịch vụ";
            this.btnXoaDichVu.UseVisualStyleBackColor = true;
            this.btnXoaDichVu.Click += new System.EventHandler(this.btnXoaDichVu_Click);
            // 
            // btnSuaThongTin2
            // 
            this.btnSuaThongTin2.Location = new System.Drawing.Point(450, 294);
            this.btnSuaThongTin2.Name = "btnSuaThongTin2";
            this.btnSuaThongTin2.Size = new System.Drawing.Size(90, 23);
            this.btnSuaThongTin2.TabIndex = 8;
            this.btnSuaThongTin2.Text = "Sửa thông tin";
            this.btnSuaThongTin2.UseVisualStyleBackColor = true;
            this.btnSuaThongTin2.Click += new System.EventHandler(this.btnSuaThongTin2_Click);
            // 
            // btnThemDichVu
            // 
            this.btnThemDichVu.Location = new System.Drawing.Point(333, 294);
            this.btnThemDichVu.Name = "btnThemDichVu";
            this.btnThemDichVu.Size = new System.Drawing.Size(90, 23);
            this.btnThemDichVu.TabIndex = 7;
            this.btnThemDichVu.Text = "Thêm dịch vụ";
            this.btnThemDichVu.UseVisualStyleBackColor = true;
            this.btnThemDichVu.Click += new System.EventHandler(this.btnThemDichVu_Click);
            // 
            // btnLamMoi2
            // 
            this.btnLamMoi2.Location = new System.Drawing.Point(215, 294);
            this.btnLamMoi2.Name = "btnLamMoi2";
            this.btnLamMoi2.Size = new System.Drawing.Size(90, 23);
            this.btnLamMoi2.TabIndex = 6;
            this.btnLamMoi2.Text = "Làm mới";
            this.btnLamMoi2.UseVisualStyleBackColor = true;
            this.btnLamMoi2.Click += new System.EventHandler(this.btnLamMoi2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(319, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tên dịch vụ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // txtTimKiem2
            // 
            this.txtTimKiem2.Location = new System.Drawing.Point(401, 5);
            this.txtTimKiem2.Name = "txtTimKiem2";
            this.txtTimKiem2.Size = new System.Drawing.Size(166, 20);
            this.txtTimKiem2.TabIndex = 3;
            // 
            // btnTimKiem2
            // 
            this.btnTimKiem2.Location = new System.Drawing.Point(583, 3);
            this.btnTimKiem2.Name = "btnTimKiem2";
            this.btnTimKiem2.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem2.TabIndex = 2;
            this.btnTimKiem2.Text = "Tìm kiếm";
            this.btnTimKiem2.UseVisualStyleBackColor = true;
            this.btnTimKiem2.Click += new System.EventHandler(this.btnTimKiem2_Click);
            // 
            // dgvQuanLyDichVu
            // 
            this.dgvQuanLyDichVu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanLyDichVu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyDichVu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenDichVu,
            this.donViTinh,
            this.donGia});
            this.dgvQuanLyDichVu.Location = new System.Drawing.Point(3, 31);
            this.dgvQuanLyDichVu.Name = "dgvQuanLyDichVu";
            this.dgvQuanLyDichVu.Size = new System.Drawing.Size(658, 247);
            this.dgvQuanLyDichVu.TabIndex = 1;
            // 
            // tenDichVu
            // 
            this.tenDichVu.DataPropertyName = "tenDichVu";
            this.tenDichVu.HeaderText = "Tên dịch vụ";
            this.tenDichVu.Name = "tenDichVu";
            // 
            // donViTinh
            // 
            this.donViTinh.DataPropertyName = "donViTinh";
            this.donViTinh.HeaderText = "Đơn vị tính";
            this.donViTinh.Name = "donViTinh";
            // 
            // donGia
            // 
            this.donGia.DataPropertyName = "donGia";
            this.donGia.HeaderText = "Đơn giá";
            this.donGia.Name = "donGia";
            // 
            // tpQuanLyTaiKhoan
            // 
            this.tpQuanLyTaiKhoan.Controls.Add(this.btnLamMoi);
            this.tpQuanLyTaiKhoan.Controls.Add(this.btnSuaThongTin);
            this.tpQuanLyTaiKhoan.Controls.Add(this.btnXoaTaiKhoan);
            this.tpQuanLyTaiKhoan.Controls.Add(this.button1);
            this.tpQuanLyTaiKhoan.Controls.Add(this.label1);
            this.tpQuanLyTaiKhoan.Controls.Add(this.txtTimKiem);
            this.tpQuanLyTaiKhoan.Controls.Add(this.btnTimKiem);
            this.tpQuanLyTaiKhoan.Controls.Add(this.dgvQuanLyTaiKhoan);
            this.tpQuanLyTaiKhoan.Location = new System.Drawing.Point(4, 22);
            this.tpQuanLyTaiKhoan.Name = "tpQuanLyTaiKhoan";
            this.tpQuanLyTaiKhoan.Padding = new System.Windows.Forms.Padding(3);
            this.tpQuanLyTaiKhoan.Size = new System.Drawing.Size(664, 332);
            this.tpQuanLyTaiKhoan.TabIndex = 0;
            this.tpQuanLyTaiKhoan.Text = "Quản lý tài khoản";
            this.tpQuanLyTaiKhoan.UseVisualStyleBackColor = true;
            // 
            // btnLamMoi
            // 
            this.btnLamMoi.Location = new System.Drawing.Point(207, 293);
            this.btnLamMoi.Name = "btnLamMoi";
            this.btnLamMoi.Size = new System.Drawing.Size(90, 23);
            this.btnLamMoi.TabIndex = 7;
            this.btnLamMoi.Text = "Làm mới";
            this.btnLamMoi.UseVisualStyleBackColor = true;
            this.btnLamMoi.Click += new System.EventHandler(this.btnLamMoi_Click);
            // 
            // btnSuaThongTin
            // 
            this.btnSuaThongTin.Location = new System.Drawing.Point(449, 293);
            this.btnSuaThongTin.Name = "btnSuaThongTin";
            this.btnSuaThongTin.Size = new System.Drawing.Size(90, 23);
            this.btnSuaThongTin.TabIndex = 6;
            this.btnSuaThongTin.Text = "Sửa thông tin";
            this.btnSuaThongTin.UseVisualStyleBackColor = true;
            this.btnSuaThongTin.Click += new System.EventHandler(this.btnSuaThongTin_Click);
            // 
            // btnXoaTaiKhoan
            // 
            this.btnXoaTaiKhoan.Location = new System.Drawing.Point(568, 293);
            this.btnXoaTaiKhoan.Name = "btnXoaTaiKhoan";
            this.btnXoaTaiKhoan.Size = new System.Drawing.Size(90, 23);
            this.btnXoaTaiKhoan.TabIndex = 5;
            this.btnXoaTaiKhoan.Text = "Xóa tài khoản";
            this.btnXoaTaiKhoan.UseVisualStyleBackColor = true;
            this.btnXoaTaiKhoan.Click += new System.EventHandler(this.btnXoaTaiKhoan_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(327, 293);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Tạo tài khoản";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên đăng nhập";
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(401, 5);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(167, 20);
            this.txtTimKiem.TabIndex = 2;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Location = new System.Drawing.Point(583, 3);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimKiem.TabIndex = 1;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = true;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // dgvQuanLyTaiKhoan
            // 
            this.dgvQuanLyTaiKhoan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvQuanLyTaiKhoan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuanLyTaiKhoan.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tenDangNhap,
            this.tenHienThi,
            this.matKhau,
            this.quyenHan});
            this.dgvQuanLyTaiKhoan.Location = new System.Drawing.Point(3, 30);
            this.dgvQuanLyTaiKhoan.Name = "dgvQuanLyTaiKhoan";
            this.dgvQuanLyTaiKhoan.Size = new System.Drawing.Size(658, 247);
            this.dgvQuanLyTaiKhoan.TabIndex = 0;
            // 
            // tenDangNhap
            // 
            this.tenDangNhap.DataPropertyName = "tenDangNhap";
            this.tenDangNhap.HeaderText = "Tên đăng nhập";
            this.tenDangNhap.Name = "tenDangNhap";
            // 
            // tenHienThi
            // 
            this.tenHienThi.DataPropertyName = "tenHienThi";
            this.tenHienThi.HeaderText = "Tên hiển thị";
            this.tenHienThi.Name = "tenHienThi";
            // 
            // matKhau
            // 
            this.matKhau.DataPropertyName = "matKhau";
            this.matKhau.HeaderText = "Mật khẩu";
            this.matKhau.Name = "matKhau";
            // 
            // quyenHan
            // 
            this.quyenHan.DataPropertyName = "quyenHan";
            this.quyenHan.HeaderText = "Quyền hạn";
            this.quyenHan.Name = "quyenHan";
            // 
            // tcAdmin
            // 
            this.tcAdmin.Controls.Add(this.tpQuanLyTaiKhoan);
            this.tcAdmin.Controls.Add(this.tpQuanLyDichVu);
            this.tcAdmin.Controls.Add(this.tpQuanLyPhong);
            this.tcAdmin.Controls.Add(this.tpLapHoaDon);
            this.tcAdmin.Location = new System.Drawing.Point(3, 4);
            this.tcAdmin.Name = "tcAdmin";
            this.tcAdmin.SelectedIndex = 0;
            this.tcAdmin.Size = new System.Drawing.Size(672, 358);
            this.tcAdmin.TabIndex = 0;
            // 
            // tpLapHoaDon
            // 
            this.tpLapHoaDon.Controls.Add(this.btnXacNhan);
            this.tpLapHoaDon.Controls.Add(this.txtHoaDon);
            this.tpLapHoaDon.Controls.Add(this.dgvLapHoaDon);
            this.tpLapHoaDon.Location = new System.Drawing.Point(4, 22);
            this.tpLapHoaDon.Name = "tpLapHoaDon";
            this.tpLapHoaDon.Padding = new System.Windows.Forms.Padding(3);
            this.tpLapHoaDon.Size = new System.Drawing.Size(664, 332);
            this.tpLapHoaDon.TabIndex = 3;
            this.tpLapHoaDon.Text = "Lập hóa đơn";
            this.tpLapHoaDon.UseVisualStyleBackColor = true;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(306, 294);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(75, 23);
            this.btnXacNhan.TabIndex = 2;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // txtHoaDon
            // 
            this.txtHoaDon.Enabled = false;
            this.txtHoaDon.Location = new System.Drawing.Point(348, 6);
            this.txtHoaDon.Multiline = true;
            this.txtHoaDon.Name = "txtHoaDon";
            this.txtHoaDon.Size = new System.Drawing.Size(310, 273);
            this.txtHoaDon.TabIndex = 1;
            // 
            // dgvLapHoaDon
            // 
            this.dgvLapHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLapHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLapHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maPhong2,
            this.trangThai2});
            this.dgvLapHoaDon.Location = new System.Drawing.Point(6, 6);
            this.dgvLapHoaDon.Name = "dgvLapHoaDon";
            this.dgvLapHoaDon.Size = new System.Drawing.Size(336, 273);
            this.dgvLapHoaDon.TabIndex = 0;
            // 
            // maPhong2
            // 
            this.maPhong2.DataPropertyName = "maPhong";
            this.maPhong2.HeaderText = "Mã Phòng";
            this.maPhong2.Name = "maPhong2";
            // 
            // trangThai2
            // 
            this.trangThai2.DataPropertyName = "trangThai";
            this.trangThai2.HeaderText = "Trạng thái";
            this.trangThai2.Name = "trangThai2";
            // 
            // frmAdmin
            // 
            this.AcceptButton = this.btnTimKiem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 365);
            this.Controls.Add(this.tcAdmin);
            this.Name = "frmAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmAdmin_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmAdmin_FormClosed);
            this.tpQuanLyPhong.ResumeLayout(false);
            this.tpQuanLyPhong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyPhong)).EndInit();
            this.tpQuanLyDichVu.ResumeLayout(false);
            this.tpQuanLyDichVu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyDichVu)).EndInit();
            this.tpQuanLyTaiKhoan.ResumeLayout(false);
            this.tpQuanLyTaiKhoan.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuanLyTaiKhoan)).EndInit();
            this.tcAdmin.ResumeLayout(false);
            this.tpLapHoaDon.ResumeLayout(false);
            this.tpLapHoaDon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLapHoaDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpQuanLyPhong;
        private System.Windows.Forms.Button btnXoaPhong;
        private System.Windows.Forms.Button btnThemPhong;
        private System.Windows.Forms.Button btnLamMoi3;
        private System.Windows.Forms.Button btnTimKiem3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimKiem3;
        private System.Windows.Forms.DataGridView dgvQuanLyPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhong;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai;
        private System.Windows.Forms.TabPage tpQuanLyDichVu;
        private System.Windows.Forms.Button btnXoaDichVu;
        private System.Windows.Forms.Button btnSuaThongTin2;
        private System.Windows.Forms.Button btnThemDichVu;
        private System.Windows.Forms.Button btnLamMoi2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTimKiem2;
        private System.Windows.Forms.Button btnTimKiem2;
        private System.Windows.Forms.DataGridView dgvQuanLyDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDichVu;
        private System.Windows.Forms.DataGridViewTextBoxColumn donViTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn donGia;
        private System.Windows.Forms.TabPage tpQuanLyTaiKhoan;
        private System.Windows.Forms.Button btnLamMoi;
        private System.Windows.Forms.Button btnSuaThongTin;
        private System.Windows.Forms.Button btnXoaTaiKhoan;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.DataGridView dgvQuanLyTaiKhoan;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenDangNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenHienThi;
        private System.Windows.Forms.DataGridViewTextBoxColumn matKhau;
        private System.Windows.Forms.DataGridViewTextBoxColumn quyenHan;
        private System.Windows.Forms.TabControl tcAdmin;
        private System.Windows.Forms.TabPage tpLapHoaDon;
        private System.Windows.Forms.TextBox txtHoaDon;
        private System.Windows.Forms.DataGridView dgvLapHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn maPhong2;
        private System.Windows.Forms.DataGridViewTextBoxColumn trangThai2;
        private System.Windows.Forms.Button btnXacNhan;

    }
}