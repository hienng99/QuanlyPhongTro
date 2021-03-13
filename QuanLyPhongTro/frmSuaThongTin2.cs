using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyPhongTro
{
    public partial class frmSuaThongTin2 : Form
    {
        public frmSuaThongTin2()
        {
            InitializeComponent();
        }

        private string tenDichVu;
        public frmSuaThongTin2(string ptenDichVu)
            :this()
        {
            tenDichVu = ptenDichVu;
            txtTenDichVu.Text = ptenDichVu;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            
            string donViTinh = txtDonViTinh.Text;
            long donGia = Convert.ToInt64(txtDonGia.Text);

            if (donViTinh == "" || donGia.ToString() == "")
            {
                MessageBox.Show("Các trường không được để trống!", "Thông báo");
            }
            else
            {
                string connectionStr = "Data Source=.\\;Initial Catalog=quanlyphongtro;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionStr);
                connection.Open();
                string sql = string.Format("update danhSachDichVu set donViTinh = N'{0}', donGia = {1} where tenDichVu = N'{2}'", donViTinh, donGia, tenDichVu);
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Cập nhật thành công!", "Thông báo");
                //this.txtTenDichVu.Clear();
                this.txtDonGia.Clear();
                this.txtDonViTinh.Clear();
                this.txtDonGia.Focus();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtDonViTinh.Clear();
            this.txtDonGia.Clear();
            this.txtDonViTinh.Focus();
        }
    }
}
