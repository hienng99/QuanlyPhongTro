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
    public partial class frmThemDichVu : Form
    {
        public frmThemDichVu()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            this.txtTenDichVu.Clear();
            this.txtDonViTinh.Clear();
            this.txtDonGia.Clear();
            this.txtTenDichVu.Focus();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenDichVu = txtTenDichVu.Text;
            string donViTinh = txtDonViTinh.Text;
            string donGia = txtDonGia.Text;
            
            //Kiem tra ten dich vu da ton tai chua
            string connectionStr = "Data Source=.\\;Initial Catalog=quanlyphongtro;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);

            string query = string.Format("select * from danhSachDichVu where tenDichVu = N'{0}'", tenDichVu);

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);

            connection.Close();

            int soDongData = data.Rows.Count;

            bool tenDichVuChuaTonTai;

            if (soDongData == 0)
            {
                tenDichVuChuaTonTai = true;
            }
            else
            {
                tenDichVuChuaTonTai = false;
            }

            if (tenDichVu == "" || donViTinh == "" || donGia == "")
            {
                MessageBox.Show("Các trường không được để trống!", "Thông báo");
            }
            else if (tenDichVuChuaTonTai == false)
            {
                MessageBox.Show("Dịch vụ đã tồn tại!", "Thông báo");
            }
            else
            {
                string connectionStr1 = "Data Source=.\\;Initial Catalog=quanlyphongtro;Integrated Security=True";
                SqlConnection connection1 = new SqlConnection(connectionStr1);

                string query1 = string.Format("insert into danhSachDichVu values (N'{0}', N'{1}', {2})", tenDichVu,donViTinh, donGia);

                connection1.Open();

                SqlCommand command1 = new SqlCommand(query1, connection1);

                command1.ExecuteNonQuery();

                connection1.Close();
                MessageBox.Show("Thêm dịch vụ thành công!", "Thông báo");
                this.txtTenDichVu.Clear();
                this.txtDonViTinh.Clear();
                this.txtDonGia.Clear();           
                this.txtTenDichVu.Focus();
            }
        }
    }
}
