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
    public partial class frmNhanVien : Form
    {
        private string _message;

        public frmNhanVien()
        {
            InitializeComponent();
            LoadDanhSachPhong();
        }

        public frmNhanVien(string Message)
            : this()
        {
            _message = Message;
            this.Text += " (" + _message + ")";
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

            dgvPhong.DataSource = data;
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string maPhong = txtTimKiem.Text;

            string connectionStr = "Data Source=.\\;Initial Catalog=quanlyphongtro;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);

            string query = string.Format("select * from phong where maPhong like N'%{0}%' order by maPhong asc", maPhong);

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);

            connection.Close();

            dgvPhong.DataSource = data;
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadDanhSachPhong();
        }

        private void btnThuePhong_Click(object sender, EventArgs e)
        {
            //Lay chi so dong cua DataGridView
            int r = dgvPhong.CurrentRow.Index;
            //Lay ma phong
            string strMaPhong = dgvPhong.Rows[r].Cells[0].Value.ToString();
            string strTrangThai = dgvPhong.Rows[r].Cells[1].Value.ToString();
            if (strTrangThai == "Trống")
            {
                string connectionStr = "Data Source=.\\;Initial Catalog=quanlyphongtro;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionStr);
                connection.Open();
                string sql = string.Format("update phong set trangThai = N'Đã được thuê' where maPhong = '{0}'", strMaPhong);
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Thuê phòng thành công!", "Thông báo");
                LoadDanhSachPhong();
            }
            else
            {
                MessageBox.Show("Phòng này đã được thuê!", "Thông báo");
            }
        }

        private void btnTraPhong_Click(object sender, EventArgs e)
        {
            //Lay chi so dong cua DataGridView
            int r = dgvPhong.CurrentRow.Index;
            //Lay ma phong
            string strMaPhong = dgvPhong.Rows[r].Cells[0].Value.ToString();
            string strTrangThai = dgvPhong.Rows[r].Cells[1].Value.ToString();
            if (strTrangThai == "Đã được thuê")
            {
                string connectionStr = "Data Source=.\\;Initial Catalog=quanlyphongtro;Integrated Security=True";
                SqlConnection connection = new SqlConnection(connectionStr);
                connection.Open();
                string sql = string.Format("update phong set trangThai = N'Trống' where maPhong = '{0}'", strMaPhong);
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Trả phòng thành công!", "Thông báo");
                LoadDanhSachPhong();
            }
            else
            {
                MessageBox.Show("Phòng này chưa được thuê!", "Thông báo");
            }
        }

        private void btnSuDungDichVu_Click(object sender, EventArgs e)
        {
            //Lay chi so dong cua DataGridView
            int r = dgvPhong.CurrentRow.Index;
            //Lay ma phong
            string strMaPhong = dgvPhong.Rows[r].Cells[0].Value.ToString();
            string strTrangThai = dgvPhong.Rows[r].Cells[1].Value.ToString();
            if (strTrangThai == "Đã được thuê")
            {
                frmSuDungDichVu f = new frmSuDungDichVu(strMaPhong);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Phòng này chưa được thuê!", "Thông báo");
            }
        }

        private void mntsSuaThongTin_Click(object sender, EventArgs e)
        {
            frmSuaThongTin f = new frmSuaThongTin(_message);
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private void frmNhanVien_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        
    }
}
