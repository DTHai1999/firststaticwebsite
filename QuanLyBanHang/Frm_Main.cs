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
    public partial class Frm_Main : Form
    {
        public delegate void DoEvent();
        string strCon = ConfigurationManager.ConnectionStrings["Conn"].ConnectionString;


        public Frm_Main()
        {
            InitializeComponent();
        }
        private Random random = new Random();

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                x += a;
                lbltittle.Location = new Point(x, y);
                if (x >= 925)
                {
                    a = -1;
                    labeltitle.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                }
                if (x <= 280)
                {
                    a = 1;
                    lbltittle.ForeColor = Color.FromArgb(random.Next(0, 255), random.Next(0, 255), random.Next(0, 255));
                }
            }
            catch (Exception ex)
            { }

        }

        private void quảnLýLoạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_LoaiSP"))
            {
                Frm_LoaiSP frm_loaisp = new Frm_LoaiSP();
                frm_loaisp.MdiParent = this;
                frm_loaisp.Show();
            }
            else
            {
                ActiveChildForm("Frm_LoaiSP");
            }

        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_SanPham"))
            {
                Frm_SanPham frm_SP = new Frm_SanPham();
                frm_SP.MdiParent = this;
                frm_SP.Show();
            }
            else
            {
                ActiveChildForm("Frm_SanPham");
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            Dispose();
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_KhachHang"))
            {
                Frm_KhachHang fm_KH = new Frm_KhachHang();
                fm_KH.MdiParent = this;
                fm_KH.Show();
            }
            else
            {
                ActiveChildForm("Frm_KhachHang");
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_Company"))
            {
                Frm_Company fm_NCC = new Frm_Company();
                fm_NCC.MdiParent = this;
                fm_NCC.Show();
            }
            else
            {
                ActiveChildForm("Frm_Company");
            }
        }

        private void bánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_BanHang"))
            {
                Frm_BanHang fm_BH = new Frm_BanHang();
                fm_BH.MdiParent = this;
                fm_BH.Show();
            }
            else
            {
                ActiveChildForm("Frm_BanHang");
            }
        }



        private void Frm_Main_Load(object sender, EventArgs e)
        {
            lbluser.Text = UserPermision;
            lblDateTime.Text = DateTime.Today.ToShortDateString();
        }
        public string UserPermision { set; get; }
        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    check = true;
                    break;
                }
            }
            return check;
        }
        private void ActiveChildForm(string name)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == name)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void nhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_NhapHang"))
            {
                Frm_NhapHang fm_nhaphang = new Frm_NhapHang();
                fm_nhaphang.MdiParent = this;
                fm_nhaphang.Show();
            }
            else
            {
                ActiveChildForm("Frm_NhapHang");
            }
        }

        private void giớiThiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_Contact"))
            {
                Frm_Contact fm_contact = new Frm_Contact();
                fm_contact.MdiParent = this;
                fm_contact.Show();
            }
            else
            {
                ActiveChildForm("Frm_Contact");
            }
        }

        private void báoCáoBánHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_BanHangReport"))
            {
                Frm_BanHangReport fm_BHreport = new Frm_BanHangReport();
                fm_BHreport.MdiParent = this;
                fm_BHreport.Show();
            }
            else
            {
                ActiveChildForm("Frm_BanHangReport");
            }
        }

        private void báoCáoNhậpHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_NhapHangReport"))
            {
                Frm_NhapHangReport fm_NHreport = new Frm_NhapHangReport();
                fm_NHreport.MdiParent = this;
                fm_NHreport.Show();
            }
            else
            {
                ActiveChildForm("Frm_NhapHangReport");
            }
        }


        private void mnuDX_Click(object sender, EventArgs e)
        {

            Frm_DangNhap frm = new Frm_DangNhap();
            frm.Show();
            this.Hide();


        }

        private void mnuDoiMK_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_DoiMatKhau"))
            {
                Frm_DoiMatKhau fm_pass = new Frm_DoiMatKhau();
                fm_pass.MdiParent = this;
                fm_pass.Show();
            }
            else
            {
                ActiveChildForm("Frm_DoiMatKhau");
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void chitiettoolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quayThưởngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_QuayThuong"))
            {
                Frm_QuayThuong fm_gift = new Frm_QuayThuong();
                fm_gift.MdiParent = this;
                fm_gift.Show();
            }
            else
            {
                ActiveChildForm("Frm_QuayThuong");
            }
        }
        int x = 12, y = 127, a = 1;

        private void usertoolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("Frm_QuanliUser"))
            {
                Frm_QuanliUser fm_user = new Frm_QuanliUser();
                fm_user.MdiParent = this;
                fm_user.Show();
            }
            else
            {
                ActiveChildForm("Frm_QuanliUser");
            }

        }

        private void btnSp_Click(object sender, EventArgs e)
        {
            Frm_SanPham fmSp = new Frm_SanPham();
            fmSp.Show();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            Frm_KhachHang fmCus = new Frm_KhachHang();
            fmCus.Show();


        }

        private void btnlSP_Click(object sender, EventArgs e)
        {
            Frm_LoaiSP fm_pro = new Frm_LoaiSP();
            fm_pro.Show();
        }

        private void btnCompany_Click(object sender, EventArgs e)
        {
            Frm_Company fmCom = new Frm_Company();
            fmCom.Show();
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            Frm_QuanliUser fm_user = new Frm_QuanliUser();
            fm_user.Show();
        }

        private void btnnhapH_Click(object sender, EventArgs e)
        {
            Frm_NhapHang fm_Import = new Frm_NhapHang();
            fm_Import.Show();
        }

        private void btnReportBH_Click(object sender, EventArgs e)
        {
            Frm_BanHangReport frmBH = new Frm_BanHangReport();
            frmBH.Show();
        }

        private void btnNH_Click(object sender, EventArgs e)
        {
            Frm_NhapHangReport frmNH = new Frm_NhapHangReport();
            frmNH.Show();
        }

        private void lbltittle_Click(object sender, EventArgs e)
        {

        }

        private void btnbanH_Click(object sender, EventArgs e)
        {
            Frm_BanHang fm_bh = new Frm_BanHang();
            fm_bh.Show();
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            Frm_Details fm_details = new Frm_Details();
            fm_details.Show();
        }


    }

}

      



