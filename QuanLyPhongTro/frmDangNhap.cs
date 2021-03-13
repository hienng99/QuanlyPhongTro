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
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }*/
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTenDangNhap.Text;
            string matKhau = txtMatKhau.Text;
            
            //Kiem tra tai khoan co ton tai khong va lay quyen han cua tai khoan
            string quyenHan = "";
            try
            {
                string connectionStr = "Data Source=.\\;Initial Catalog=quanlyphongtro;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionStr);

                string query = string.Format("dangNhap {0} , {1}", tenDangNhap, matKhau);

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                quyenHan = command.ExecuteScalar().ToString();
                                
                connection.Close();                
            }
            catch
            {
                MessageBox.Show("Lỗi đăng nhập!", "Thông báo");
            }          
          
            if (quyenHan == "Admin")
            {
                string connectionStr1 = "Data Source=.\\;Initial Catalog=quanlyphongtro;Integrated Security=True";
                SqlConnection connection1 = new SqlConnection(connectionStr1);

                string query1 = string.Format("select tenHienThi from taiKhoan where tenDangNhap = '{0}' and matKhau = '{1}'", tenDangNhap, matKhau);

                connection1.Open();

                SqlCommand command1 = new SqlCommand(query1, connection1);

                
                string data1= command1.ExecuteScalar().ToString();

                connection1.Close();

                frmAdmin f = new frmAdmin(data1);
                this.Hide();
                f.ShowDialog();
                this.Show();
               
            }
            else if (quyenHan == "Nhân viên")
            {
                string connectionStr1 = "Data Source=.\\;Initial Catalog=quanlyphongtro;Integrated Security=True";
                SqlConnection connection1 = new SqlConnection(connectionStr1);

                string query1 = string.Format("select tenHienThi from taiKhoan where tenDangNhap = '{0}' and matKhau = '{1}'", tenDangNhap, matKhau);

                connection1.Open();

                SqlCommand command1 = new SqlCommand(query1, connection1);


                string data1 = command1.ExecuteScalar().ToString();

                connection1.Close();

                frmNhanVien f = new frmNhanVien(data1);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo");
                this.txtTenDangNhap.Clear();
                this.txtMatKhau.Clear();
                this.txtTenDangNhap.Focus();
            }
        }
    }
}
