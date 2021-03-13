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
    public partial class frmSuaThongTin : Form
    {
        public frmSuaThongTin()
        {
            InitializeComponent();
        }

        private string tenDangNhap;
        public frmSuaThongTin(string ptenDangNhap)
            :this()
        {
            tenDangNhap = ptenDangNhap;
            txtTenDangNhap.Text = ptenDangNhap;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {            
            string tenHienThi = txtTenHienThi.Text;
            string matKhau = txtMatKhau.Text;
            string nhapLaiMatKhau = txtNhapLaiMatKhau.Text;

            if (tenHienThi == "" || matKhau == "" || nhapLaiMatKhau == "")
            {
                MessageBox.Show("Các trường không được để trống!", "Thông báo");
            }
            else if (matKhau != nhapLaiMatKhau)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!", "Thông báo");
            }
            else
            {
                string connectionStr = "Data Source=.\\;Initial Catalog=quanlyphongtro;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionStr);
                connection.Open();
                string sql = string.Format("update taiKhoan set tenHienThi = N'{0}', matkhau = '{1}' where tenDangNhap = '{2}'", tenHienThi, matKhau, tenDangNhap);
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Cập nhật thành công!", "Thông báo");
                this.txtTenHienThi.Clear();
                this.txtMatKhau.Clear();
                this.txtNhapLaiMatKhau.Clear();
                this.txtTenHienThi.Focus();
            }
        }
    }
}
