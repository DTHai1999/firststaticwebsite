using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;



namespace QuanLyBanHang
{
    public partial class Frm_DoiMatKhau : Form
    {
        string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;

        public Frm_DoiMatKhau()
        {
            string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
            SqlConnection sqlcon = new SqlConnection(strCon);
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string strSQL = "Select * From DangKyDangNhap where UserName='" + txtTaikhoan.Text + "' and MatKhau='" + txtMKcu.Text + "'";
            SqlConnection sqlCon = new SqlConnection(strCon);

            errorProvider1.Clear();
            if (txtTaikhoan.Text == "")
                errorProvider1.SetError(txtTaikhoan, "Chưa nhập tên tài khoản !");
            else if (txtMKcu.Text == "")
            {
                errorProvider1.SetError(txtMKcu, "!");
                txtMKcu.Focus();
            }
            else if (txtMKmoi.Text == "")
            {
                errorProvider1.SetError(txtMKmoi, "!");
                txtMKmoi.Focus();
            }
            else if (txtConfimMk.Text == "")
            {
                errorProvider1.SetError(txtConfimMk, "!");
                txtConfimMk.Focus();
            }
            else if (txtConfimMk.Text != txtMKmoi.Text)
            { MessageBox.Show("Bạn nhập lại password không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                sqlCon.Dispose();
                // Thực hiện truy vấn
                string strSQ = " DangKyDangNhap Set Password='" + txtMKmoi.Text + "' where UserName='" + txtTaikhoan.Text + "'";
                SqlConnection sqlconn = new SqlConnection(strCon);
                sqlCon.Open();
                MessageBox.Show("Cập nhật dữ liệu thành công", "Thông báo!");

                // Trả tài nguyên
                sqlCon.Dispose();
            }

            else
            {
                MessageBox.Show("Tên tài khoản không tồn tại hoặc mật khẩu sai! ", "Thông báo !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTaikhoan.Focus();

            }
            sqlCon.Dispose();
        }

        private void Frm_DoiMatKhau_Load(object sender, EventArgs e)
        {
            lblDatetime.Text = DateTime.Today.ToShortDateString();
        }
    }
}
