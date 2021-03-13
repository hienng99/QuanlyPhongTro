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
    public partial class frmThemPhong : Form
    {
        public frmThemPhong()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maPhong = txtMaPhong.Text;

            //Kiem tra ten dich vu da ton tai chua
            string connectionStr = "Data Source=.\\;Initial Catalog=quanlyphongtro;Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionStr);

            string query = string.Format("select * from phong where maPhong = '{0}'", maPhong);

            connection.Open();

            SqlCommand command = new SqlCommand(query, connection);

            DataTable data = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);

            adapter.Fill(data);

            connection.Close();

            int soDongData = data.Rows.Count;

            bool maPhongChuaTonTai;

            if (soDongData == 0)
            {
                maPhongChuaTonTai = true;
            }
            else
            {
                maPhongChuaTonTai = false;
            }

            if (maPhong == "")
            {
                MessageBox.Show("Vui lòng nhập số phòng!", "Thông báo");
            }
            else if (maPhongChuaTonTai == false)
            {
                MessageBox.Show("Số phòng đã tồn tại!", "Thông báo");
            }
            else
            {
                string connectionStr1 = "Data Source=.\\;Initial Catalog=quanlyphongtro;Integrated Security=True";
                SqlConnection connection1 = new SqlConnection(connectionStr1);

                string query1 = string.Format("insert into phong values ('{0}', N'Trống')", maPhong);

                connection1.Open();

                SqlCommand command1 = new SqlCommand(query1, connection1);

                command1.ExecuteNonQuery();

                connection1.Close();
                MessageBox.Show("Thêm thành công!", "Thông báo");
                this.txtMaPhong.Clear();                
            }
        }
    }
}
