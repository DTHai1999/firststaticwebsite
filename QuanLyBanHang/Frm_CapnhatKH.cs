using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using QuanLyBanHang;

namespace QuanLyBanHang
{
    public partial class Frm_CapnhatKH : Form
    {
        public delegate void DoEvent();
        public event DoEvent ReFreashDataGrid;
        string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;
        public Frm_CapnhatKH()
        {
            InitializeComponent();
           
        }
        
        private void Frm_CapnhatKH_Load(object sender, EventArgs e)
        {
            txt_name.Text = Ten;
            txt_phone.Text = SDT;
            txt_makh.Text = MaKH;
            txt_adress.Text =Adress;
            txt_email.Text =Email;
            lblDateTime.Text = DateTime.Today.ToShortDateString();
        }
        public string MaKH { set; get; }
        public string Ten { set; get; }
        public string SDT { set; get; }
        public string Adress { set; get; }
        public string Email { set; get; }
        
        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            string MaKH = txt_makh.Text.Trim();
            string TenKH = txt_name.Text.Trim();
            string SDT = txt_phone.Text.Trim();
            string Adress = txt_adress.Text.Trim();
            string Email = txt_email.Text.Trim();
            try
            {
                SqlHelper.ExecuteNonQuery(strCon, "KH_Update", MaKH, TenKH, SDT);
                
                MessageBox.Show("Cập nhật thông tin sản phẩm thành công");
                this.ReFreashDataGrid();
                Close();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.ToString(), "Thông Báo");
            }

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void lblDateTime_Click(object sender, EventArgs e)
        {

        }
    }
}
