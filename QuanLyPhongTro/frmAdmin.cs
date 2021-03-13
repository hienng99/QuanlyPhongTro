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
    public partial class frmAdmin : Form
    {
        private string _message;

        public frmAdmin()
        {
            InitializeComponent();
            LoadDanhSachTaiKhoan();
            LoadDanhSachDichVu();
            LoadDanhSachPhong();
        }

        public frmAdmin(string Message)
            : this()
        {
            _message = Message;
            this.Text += " (" + _message + ")";
        }

        void LoadDanhSachTaiKhoan()
        {
            string connectionStr = "Data Source=.\\;Initial Catalog=quanlyphongtro;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);

            string query = "select * from taiKhoan order by quyenHan asc";

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);

            connection.Close();

            dgvQuanLyTaiKhoan.DataSource = data;
        }

        void LoadDanhSachDichVu()
        {
            string connectionStr = "Data Source=.\\;Initial Catalog=quanlyphongtro;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);

            string query = "select * from danhSachDichVu order by tenDichVu asc";

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);

            connection.Close();

            dgvQuanLyDichVu.DataSource = data;
        }

        public void LoadDanhSachPhong()
        {
            string connectionStr = "Data Source=.\\;Initial Catalog=quanlyphongtro;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);

            string query = "select * from phong order by maPhong asc";

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);

            connection.Close();

            dgvQuanLyPhong.DataSource = data;
            dgvLapHoaDon.DataSource = data;
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txtTimKiem.Text;
            string connectionStr = "Data Source=.\\;Initial Catalog=quanlyphongtro;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);

            string query = string.Format("select * from taiKhoan where tenDangNhap like N'%{0}%' order by tenDangNhap asc", tenDangNhap);

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);

            connection.Close();

            dgvQuanLyTaiKhoan.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTaoTaiKhoan f = new frmTaoTaiKhoan();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDanhSachTaiKhoan();
            this.txtTimKiem.Clear();
        }

        private void frmAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            // Lấy thứ tự record hiện hành
            int r = dgvQuanLyTaiKhoan.CurrentCell.RowIndex;
            // Lấy tenDangNhap của record hiện hành
            string strTenDangNhap = dgvQuanLyTaiKhoan.Rows[r].Cells[0].Value.ToString();
            string strMatKhau = dgvQuanLyTaiKhoan.Rows[r].Cells[2].Value.ToString();

            //Lay quyen han cua tai khoan muon xoa
            string quyenHan = "";
            try
            {
                string connectionStr = "Data Source=.\\;Initial Catalog=quanlyphongtro;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionStr);

                string query = string.Format("dangNhap {0} , {1}", strTenDangNhap, strMatKhau);

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                quyenHan = command.ExecuteScalar().ToString();

                connection.Close();  
            }
            catch
            {

            }
           
            string strTenHienThi = dgvQuanLyTaiKhoan.Rows[r].Cells[1].Value.ToString();
            string thongBao = "Bạn có chắc muốn xóa người dùng " + strTenHienThi;
            if (MessageBox.Show( thongBao, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                if (quyenHan == "Admin")
                {
                    MessageBox.Show("Không thể xóa tài khoản Admin!", "Cảnh báo");
                }
                else
                {
                    string connectionStr1 = "Data Source=.\\;Initial Catalog=quanlyphongtro;Integrated Security=True";
                    SqlConnection connection1 = new SqlConnection(connectionStr1);
                    connection1.Open();
                    try
                    {
                        // Thực hiện lệnh
                        SqlCommand cmd = new SqlCommand();
                        cmd.Connection = connection1;
                        cmd.CommandType = CommandType.Text;


                        // Viết câu lệnh SQL
                        cmd.CommandText = System.String.Concat("Delete From taiKhoan Where tenDangNhap = '" + strTenDangNhap + "'");
                        cmd.CommandType = CommandType.Text;
                        // Thực hiện câu lệng sql
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công!");
                        connection1.Close();
                    }
                    catch
                    {
                        MessageBox.Show("Không thể xóa!", "Thông báo");
                    }
                }                
            }
        }

        private void btnSuaThongTin_Click(object sender, EventArgs e)
        {
            // Lấy thứ tự record hiện hành
            int r = dgvQuanLyTaiKhoan.CurrentCell.RowIndex;
            // Lấy tenDangNhap của record hiện hành
            string strTenDangNhap = dgvQuanLyTaiKhoan.Rows[r].Cells[0].Value.ToString();
            frmSuaThongTin f = new frmSuaThongTin(strTenDangNhap);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnTimKiem2_Click(object sender, EventArgs e)
        {
            string tenDichVu = txtTimKiem2.Text;

            string connectionStr = "Data Source=.\\;Initial Catalog=quanlyphongtro;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);

            string query = string.Format("select * from danhSachDichVu where tenDichVu like N'%{0}%' order by tenDichVu asc", tenDichVu);

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);

            connection.Close();

            dgvQuanLyDichVu.DataSource = data;
        }

        private void btnLamMoi2_Click(object sender, EventArgs e)
        {
            LoadDanhSachDichVu();
            this.txtTimKiem2.Clear();
        }

        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            frmThemDichVu f = new frmThemDichVu();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void frmAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void btnSuaThongTin2_Click(object sender, EventArgs e)
        {
            // Lấy thứ tự record hiện hành
            int r = dgvQuanLyDichVu.CurrentCell.RowIndex;
            // Lấy tenDichVu của record hiện hành
            string strTenDichVu = dgvQuanLyDichVu.Rows[r].Cells[0].Value.ToString();
            frmSuaThongTin2 f = new frmSuaThongTin2(strTenDichVu);
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void btnXoaDichVu_Click(object sender, EventArgs e)
        {
            // Lấy thứ tự record hiện hành
            int r = dgvQuanLyDichVu.CurrentCell.RowIndex;
            // Lấy tenDichVu của record hiện hành
            string strTenDichVu = dgvQuanLyDichVu.Rows[r].Cells[0].Value.ToString();  
         
            string thongBao = "Bạn có chắc muốn xóa dịch vụ " + strTenDichVu;
            if (MessageBox.Show(thongBao, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                string connectionStr1 = "Data Source=.\\;Initial Catalog=quanlyphongtro;Integrated Security=True";
                SqlConnection connection1 = new SqlConnection(connectionStr1);
                connection1.Open();
                try
                {
                    // Thực hiện lệnh
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection1;
                    cmd.CommandType = CommandType.Text;


                    // Viết câu lệnh SQL
                    cmd.CommandText = System.String.Concat("Delete From danhSachDichVu Where tenDichVu= '" + strTenDichVu + "'");
                    cmd.CommandType = CommandType.Text;
                    // Thực hiện câu lệng sql
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!");
                    connection1.Close();
                }
                catch
                {
                    MessageBox.Show("Không thể xóa!", "Thông báo");
                }
            }           
        }

        private void btnThemPhong_Click(object sender, EventArgs e)
        {
            frmThemPhong f = new frmThemPhong();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void btnLamMoi3_Click(object sender, EventArgs e)
        {
            LoadDanhSachPhong();
            this.txtTimKiem3.Clear();
        }

        private void btnTimKiem3_Click(object sender, EventArgs e)
        {
            string maPhong = txtTimKiem3.Text;

            string connectionStr = "Data Source=.\\;Initial Catalog=quanlyphongtro;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);

            string query = string.Format("select * from phong where maPhong like N'%{0}%' order by maPhong asc", maPhong);

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);

            connection.Close();

            dgvQuanLyPhong.DataSource = data;
        }

        private void btnXoaPhong_Click(object sender, EventArgs e)
        {
            // Lấy thứ tự record hiện hành
            int r = dgvQuanLyPhong.CurrentCell.RowIndex;
            // Lấy maPhong của record hiện hành
            string strMaPhong = dgvQuanLyPhong.Rows[r].Cells[0].Value.ToString();  
         
            string thongBao = "Bạn có chắc muốn xóa phòng " + strMaPhong;
            if (MessageBox.Show(thongBao, "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
            {
                string connectionStr1 = "Data Source=.\\;Initial Catalog=quanlyphongtro;Integrated Security=True";
                SqlConnection connection1 = new SqlConnection(connectionStr1);
                connection1.Open();
                try
                {
                    // Thực hiện lệnh
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection1;
                    cmd.CommandType = CommandType.Text;


                    // Viết câu lệnh SQL
                    cmd.CommandText = System.String.Concat("Delete From phong Where maPhong = '" + strMaPhong + "'");
                    cmd.CommandType = CommandType.Text;
                    // Thực hiện câu lệng sql
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Xóa thành công!");
                    connection1.Close();
                }
                catch
                {
                    MessageBox.Show("Không thể xóa!", "Thông báo");
                }
            }
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            // Lấy thứ tự record hiện hành
            int r = dgvLapHoaDon.CurrentCell.RowIndex;
            // Lấy maPhong của record hiện hành
            string strMaPhong = dgvQuanLyPhong.Rows[r].Cells[0].Value.ToString();
            string strTrangThai = dgvQuanLyPhong.Rows[r].Cells[1].Value.ToString();
            if (strTrangThai == "Đã được thuê")
            {
                txtHoaDon.Text = "                                HÓA ĐƠN PHÒNG " + strMaPhong + "\r\n";
                txtHoaDon.Text += "                                               ~~~" + "\r\n";

                string connectionStr = "Data Source=.\\;Initial Catalog=quanlyphongtro;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionStr);

                string query = string.Format("select * from hoaDonDichVu where maPhong = N'{0}'", strMaPhong);

                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                DataTable data = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(data);
                long tongTien = 1200000;
                foreach (DataRow row in data.Rows)
                {
                    string query2 = string.Format("select donGia from danhSachDichVu where tenDichVu = N'{0}'", row["tenDichVu"]);
                    SqlCommand cmd = new SqlCommand(query2, connection);
                    long donGia = Convert.ToInt64(cmd.ExecuteScalar().ToString());
                    long tienDichVu = Convert.ToInt64(row["soLuong"].ToString()) * donGia;
                    tongTien += tienDichVu;
                    txtHoaDon.Text += row["tenDichVu"];
                    string space = "";
                    for (int j = 0; j < 40 - row["tenDichVu"].ToString().Length; j++)
                    {
                        space += " ";
                    }

                    txtHoaDon.Text += space + row["soLuong"] + "                        " + tienDichVu.ToString() + "\r\n";
                }
                txtHoaDon.Text += "Tiền phòng                                                    1200000" + "\r\n";
                txtHoaDon.Text += "----------------------------------------------------------------------------\r\n";
                txtHoaDon.Text += "Tổng cộng:                                                       " + tongTien;

                connection.Close();
            }
            else
            {
                MessageBox.Show("Phòng này chưa được thuê!", "Thông báo");
            }
        }
    }
}
