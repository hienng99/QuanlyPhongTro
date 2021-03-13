namespace QuanLyPhongTro
{
    partial class frmSuDungDichVu
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lstTenDichVu = new System.Windows.Forms.ListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.nmrudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 159);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin dịch vụ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lstTenDichVu);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(6, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(312, 92);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên dịch vụ";
            // 
            // lstTenDichVu
            // 
            this.lstTenDichVu.FormattingEnabled = true;
            this.lstTenDichVu.HorizontalScrollbar = true;
            this.lstTenDichVu.Location = new System.Drawing.Point(105, 3);
            this.lstTenDichVu.Name = "lstTenDichVu";
            this.lstTenDichVu.Size = new System.Drawing.Size(204, 82);
            this.lstTenDichVu.TabIndex = 2;
            this.lstTenDichVu.SelectedIndexChanged += new System.EventHandler(this.lstTenDichVu_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nmrudSoLuong);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(6, 117);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(154, 36);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Số lượng";
            // 
            // nmrudSoLuong
            // 
            this.nmrudSoLuong.Location = new System.Drawing.Point(105, 8);
            this.nmrudSoLuong.Name = "nmrudSoLuong";
            this.nmrudSoLuong.Size = new System.Drawing.Size(41, 20);
            this.nmrudSoLuong.TabIndex = 2;
            this.nmrudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(135, 177);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(75, 23);
            this.btnXacNhan.TabIndex = 1;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // frmSuDungDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 212);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmSuDungDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sử dụng dịch vụ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSuDungDichVu_FormClosing);
            this.Load += new System.EventHandler(this.frmSuDungDichVu_Load);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrudSoLuong)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstTenDichVu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.NumericUpDown nmrudSoLuong;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXacNhan;
    }
}