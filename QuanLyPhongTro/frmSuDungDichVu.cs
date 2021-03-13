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
    public partial class frmSuDungDichVu : Form
    {
        private string _maPhong;
        public frmSuDungDichVu()
        {
            InitializeComponent();
            LoadDanhSachDichVu();
        }

        public frmSuDungDichVu(string MaPhong)
            : this()
        {
            _maPhong = MaPhong;
        }

        public void LoadDanhSachDichVu()
        {
            string strConnectionString = "Data Source=.\\;Initial Catalog=quanlyphongtro;Integrated Security=True";
            SqlConnection conn = null;
            // Đối tượng đưa dữ liệu vào DataTable dtDichVu
            SqlDataAdapter daDichVu = null;
            // Đối tượng hiển thị dữ liệu lên Form
            DataTable dtDichVu = null;
            try
            {
                // Khởi động connection
                conn = new SqlConnection(strConnectionString);
                // Vận chuyển dữ liệu lên DataTable
                daDichVu = new SqlDataAdapter("SELECT * FROM danhSachDichVu", conn);
                dtDichVu = new DataTable();
                dtDichVu.Clear();
                daDichVu.Fill(dtDichVu);
                // Đưa dữ liệu lên ListBox
                this.lstTenDichVu.DataSource = dtDichVu;
                this.lstTenDichVu.DisplayMember = "tenDichVu";
                this.lstTenDichVu.ValueMember = "tenDichVu";
            }
            catch (SqlException) {
                MessageBox.Show("Không lấy được nội dung trong table THANHPHO. Lỗi rồi!!!");
            }
        }

        private void frmSuDungDichVu_Load(object sender, EventArgs e)
        {

        }

        private void frmSuDungDichVu_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            string tenDichVu = lstTenDichVu.SelectedValue.ToString();
            string soLuong = nmrudSoLuong.Value.ToString();
            string maPhong = _maPhong;
            string connectionStr = "Data Source=.\\;Initial Catalog=quanlyphongtro;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);
            connection.Open();
            string sql = string.Format("insert into hoaDonDichVu (maPhong, tenDichVu, soLuong) values (N'{0}', N'{1}', {2})", maPhong, tenDichVu, soLuong);
            SqlCommand command = new SqlCommand(sql, connection);
            command.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Thêm thành công!", "Thông báo");
        }

        private void lstTenDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
