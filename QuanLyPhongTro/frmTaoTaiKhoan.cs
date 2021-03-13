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
    public partial class frmTaoTaiKhoan : Form
    {
        public frmTaoTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtTenDangNhap.Clear();
            this.txtTenHienThi.Clear();
            this.txtMatKhau.Clear();
            this.txtNhapLaiMatKhau.Clear();
            this.txtTenDangNhap.Focus();
        }

        private void btnTao_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string tenHienThi = txtTenHienThi.Text;
            string matKhau = txtMatKhau.Text;
            string nhapLaiMatKhau = txtNhapLaiMatKhau.Text;

            //Kiem tra ten dang nhap da ton tai chua
            string connectionStr = "Data Source=.\\;Initial Catalog=quanlyphongtro;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);

            string query = string.Format("select * from taiKhoan where tenDangNhap = N'{0}'", tenDangNhap);

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);

            connection.Close();

            int soDongData = data.Rows.Count;

            bool tenDangNhapChuaTonTai;

            if (soDongData == 0)
            {
                tenDangNhapChuaTonTai = true;
            }
            else
            {
                tenDangNhapChuaTonTai = false;
            }



            if (tenDangNhap == "" || tenHienThi == "" || matKhau == "" || nhapLaiMatKhau == "")
            {
               MessageBox.Show("Các trường không được để trống!", "Thông báo");                
            }
            else if (matKhau != nhapLaiMatKhau)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!", "Thông báo");                
            }
            else if (tenDangNhapChuaTonTai == false)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại!", "Thông báo");   
            }
            else
            {
                string connectionStr1 = "Data Source=.\\;Initial Catalog=quanlyphongtro;Integrated Security=True";
                SqlConnection connection1 = new SqlConnection(connectionStr1);

                string query1 = string.Format("insert into taiKhoan values ('{0}', N'{1}', '{2}', N'Nhân viên')", tenDangNhap, tenHienThi, matKhau);

                connection1.Open();

                SqlCommand command1 = new SqlCommand(query1, connection1);

                command1.ExecuteNonQuery();

                connection1.Close();
                MessageBox.Show("Tạo tài khoản thành công!", "Thông báo");
                this.txtTenDangNhap.Clear();
                this.txtTenHienThi.Clear();
                this.txtMatKhau.Clear();
                this.txtNhapLaiMatKhau.Clear();
                this.txtTenDangNhap.Focus();
            }

        }
    }
}
