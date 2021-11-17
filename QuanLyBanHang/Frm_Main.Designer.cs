using System;

namespace QuanLyBanHang
{
    partial class Frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLSPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLKHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLLSPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.QLNCCtoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chitiettoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoThốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoBánHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoNhậpHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giớiThiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuItemHethong = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.usertoolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDX = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ExitToolsStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quayThưởngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labeltitle = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbxuser = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lbluser = new System.Windows.Forms.Label();
            this.gbxdanhMuc = new System.Windows.Forms.GroupBox();
            this.btnUser = new System.Windows.Forms.Button();
            this.btnCompany = new System.Windows.Forms.Button();
            this.btnlSP = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnSp = new System.Windows.Forms.Button();
            this.gbxchucNang = new System.Windows.Forms.GroupBox();
            this.btnDetails = new System.Windows.Forms.Button();
            this.btnbanH = new System.Windows.Forms.Button();
            this.btnnhapH = new System.Windows.Forms.Button();
            this.gbxbctk = new System.Windows.Forms.GroupBox();
            this.btnNH = new System.Windows.Forms.Button();
            this.btnReportBH = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.gbxinfor = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbltittle = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.gbxuser.SuspendLayout();
            this.gbxdanhMuc.SuspendLayout();
            this.gbxchucNang.SuspendLayout();
            this.gbxbctk.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.gbxinfor.SuspendLayout();
            this.SuspendLayout();
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.QLSPToolStripMenuItem,
            this.QLKHToolStripMenuItem,
            this.QLLSPToolStripMenuItem,
            this.QLNCCtoolStripMenuItem});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(88, 24);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // QLSPToolStripMenuItem
            // 
            this.QLSPToolStripMenuItem.Name = "QLSPToolStripMenuItem";
            this.QLSPToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.QLSPToolStripMenuItem.Text = "Quản lý sản phẩm";
            this.QLSPToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSảnPhẩmToolStripMenuItem_Click);
            // 
            // QLKHToolStripMenuItem
            // 
            this.QLKHToolStripMenuItem.Name = "QLKHToolStripMenuItem";
            this.QLKHToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.QLKHToolStripMenuItem.Text = "Quản lý khách hàng";
            this.QLKHToolStripMenuItem.Click += new System.EventHandler(this.quảnLýKháchHàngToolStripMenuItem_Click);
            // 
            // QLLSPToolStripMenuItem
            // 
            this.QLLSPToolStripMenuItem.Name = "QLLSPToolStripMenuItem";
            this.QLLSPToolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.QLLSPToolStripMenuItem.Text = "Quản lý loại sản phẩm";
            this.QLLSPToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLoạiSảnPhẩmToolStripMenuItem_Click);
            // 
            // QLNCCtoolStripMenuItem
            // 
            this.QLNCCtoolStripMenuItem.Name = "QLNCCtoolStripMenuItem";
            this.QLNCCtoolStripMenuItem.Size = new System.Drawing.Size(231, 26);
            this.QLNCCtoolStripMenuItem.Text = "Quản lý nhà cung cấp";
            this.QLNCCtoolStripMenuItem.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bánHàngToolStripMenuItem,
            this.nhậpHàngToolStripMenuItem,
            this.chitiettoolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.chứcNăngToolStripMenuItem.Text = "Chức năng";
            // 
            // bánHàngToolStripMenuItem
            // 
            this.bánHàngToolStripMenuItem.Name = "bánHàngToolStripMenuItem";
            this.bánHàngToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.bánHàngToolStripMenuItem.Text = "Bán hàng";
            this.bánHàngToolStripMenuItem.Click += new System.EventHandler(this.bánHàngToolStripMenuItem_Click);
            // 
            // nhậpHàngToolStripMenuItem
            // 
            this.nhậpHàngToolStripMenuItem.Name = "nhậpHàngToolStripMenuItem";
            this.nhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.nhậpHàngToolStripMenuItem.Text = "Nhập hàng";
            this.nhậpHàngToolStripMenuItem.Click += new System.EventHandler(this.nhậpHàngToolStripMenuItem_Click);
            // 
            // chitiettoolStripMenuItem
            // 
            this.chitiettoolStripMenuItem.Name = "chitiettoolStripMenuItem";
            this.chitiettoolStripMenuItem.Size = new System.Drawing.Size(190, 26);
            this.chitiettoolStripMenuItem.Text = "Chi tiết hóa đơn";
            this.chitiettoolStripMenuItem.Click += new System.EventHandler(this.chitiettoolStripMenuItem_Click);
            // 
            // báoCáoThốngKêToolStripMenuItem
            // 
            this.báoCáoThốngKêToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.báoCáoBánHàngToolStripMenuItem,
            this.báoCáoNhậpHàngToolStripMenuItem});
            this.báoCáoThốngKêToolStripMenuItem.Name = "báoCáoThốngKêToolStripMenuItem";
            this.báoCáoThốngKêToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.báoCáoThốngKêToolStripMenuItem.Text = "Báo cáo thống kê";
            // 
            // báoCáoBánHàngToolStripMenuItem
            // 
            this.báoCáoBánHàngToolStripMenuItem.Name = "báoCáoBánHàngToolStripMenuItem";
            this.báoCáoBánHàngToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.báoCáoBánHàngToolStripMenuItem.Text = "Báo cáo bán hàng";
            this.báoCáoBánHàngToolStripMenuItem.Click += new System.EventHandler(this.báoCáoBánHàngToolStripMenuItem_Click);
            // 
            // báoCáoNhậpHàngToolStripMenuItem
            // 
            this.báoCáoNhậpHàngToolStripMenuItem.Name = "báoCáoNhậpHàngToolStripMenuItem";
            this.báoCáoNhậpHàngToolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.báoCáoNhậpHàngToolStripMenuItem.Text = "Báo cáo nhập hàng";
            this.báoCáoNhậpHàngToolStripMenuItem.Click += new System.EventHandler(this.báoCáoNhậpHàngToolStripMenuItem_Click);
            // 
            // giớiThiệuToolStripMenuItem
            // 
            this.giớiThiệuToolStripMenuItem.Name = "giớiThiệuToolStripMenuItem";
            this.giớiThiệuToolStripMenuItem.Size = new System.Drawing.Size(85, 24);
            this.giớiThiệuToolStripMenuItem.Text = "Giới thiệu";
            this.giớiThiệuToolStripMenuItem.Click += new System.EventHandler(this.giớiThiệuToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuItemHethong,
            this.danhMụcToolStripMenuItem,
            this.chứcNăngToolStripMenuItem,
            this.báoCáoThốngKêToolStripMenuItem,
            this.giớiThiệuToolStripMenuItem,
            this.quayThưởngToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1367, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuItemHethong
            // 
            this.mnuItemHethong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.usertoolStripMenuItem,
            this.mnuDX,
            this.mnuDoiMK,
            this.toolStripSeparator2,
            this.ExitToolsStripMenuItem});
            this.mnuItemHethong.Name = "mnuItemHethong";
            this.mnuItemHethong.Size = new System.Drawing.Size(86, 24);
            this.mnuItemHethong.Text = "&Hệ Thống";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(209, 6);
            // 
            // usertoolStripMenuItem
            // 
            this.usertoolStripMenuItem.Name = "usertoolStripMenuItem";
            this.usertoolStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.usertoolStripMenuItem.Text = "Quản lí người dùng";
            this.usertoolStripMenuItem.Click += new System.EventHandler(this.usertoolStripMenuItem_Click);
            // 
            // mnuDX
            // 
            this.mnuDX.Name = "mnuDX";
            this.mnuDX.Size = new System.Drawing.Size(212, 26);
            this.mnuDX.Text = "Đăng xuất";
            this.mnuDX.Click += new System.EventHandler(this.mnuDX_Click);
            // 
            // mnuDoiMK
            // 
            this.mnuDoiMK.Name = "mnuDoiMK";
            this.mnuDoiMK.Size = new System.Drawing.Size(212, 26);
            this.mnuDoiMK.Text = "Đổi mật khẩu";
            this.mnuDoiMK.Click += new System.EventHandler(this.mnuDoiMK_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(209, 6);
            // 
            // ExitToolsStripMenuItem
            // 
            this.ExitToolsStripMenuItem.Name = "ExitToolsStripMenuItem";
            this.ExitToolsStripMenuItem.Size = new System.Drawing.Size(212, 26);
            this.ExitToolsStripMenuItem.Text = "&Exit";
            this.ExitToolsStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // quayThưởngToolStripMenuItem
            // 
            this.quayThưởngToolStripMenuItem.Name = "quayThưởngToolStripMenuItem";
            this.quayThưởngToolStripMenuItem.Size = new System.Drawing.Size(110, 24);
            this.quayThưởngToolStripMenuItem.Text = "Quay Thưởng";
            this.quayThưởngToolStripMenuItem.Click += new System.EventHandler(this.quayThưởngToolStripMenuItem_Click);
            // 
            // labeltitle
            // 
            this.labeltitle.AutoSize = true;
            this.labeltitle.BackColor = System.Drawing.SystemColors.HotTrack;
            this.labeltitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitle.Location = new System.Drawing.Point(672, 111);
            this.labeltitle.Name = "labeltitle";
            this.labeltitle.Size = new System.Drawing.Size(0, 29);
            this.labeltitle.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gbxuser
            // 
            this.gbxuser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbxuser.Controls.Add(this.label3);
            this.gbxuser.Controls.Add(this.label2);
            this.gbxuser.Controls.Add(this.lblDateTime);
            this.gbxuser.Controls.Add(this.lbluser);
            this.gbxuser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbxuser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxuser.Location = new System.Drawing.Point(3, 17);
            this.gbxuser.Name = "gbxuser";
            this.gbxuser.Size = new System.Drawing.Size(251, 93);
            this.gbxuser.TabIndex = 0;
            this.gbxuser.TabStop = false;
            this.gbxuser.Text = "User System:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.Location = new System.Drawing.Point(0, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "DateTime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Xin chào:";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.Red;
            this.lblDateTime.Location = new System.Drawing.Point(96, 64);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(13, 18);
            this.lblDateTime.TabIndex = 7;
            this.lblDateTime.Text = ".";
            // 
            // lbluser
            // 
            this.lbluser.AutoSize = true;
            this.lbluser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbluser.ForeColor = System.Drawing.Color.Red;
            this.lbluser.Location = new System.Drawing.Point(96, 33);
            this.lbluser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbluser.Name = "lbluser";
            this.lbluser.Size = new System.Drawing.Size(13, 18);
            this.lbluser.TabIndex = 3;
            this.lbluser.Text = ".";
            // 
            // gbxdanhMuc
            // 
            this.gbxdanhMuc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbxdanhMuc.Controls.Add(this.btnUser);
            this.gbxdanhMuc.Controls.Add(this.btnCompany);
            this.gbxdanhMuc.Controls.Add(this.btnlSP);
            this.gbxdanhMuc.Controls.Add(this.btnCustomer);
            this.gbxdanhMuc.Controls.Add(this.btnSp);
            this.gbxdanhMuc.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbxdanhMuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxdanhMuc.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gbxdanhMuc.Location = new System.Drawing.Point(2, 126);
            this.gbxdanhMuc.Name = "gbxdanhMuc";
            this.gbxdanhMuc.Size = new System.Drawing.Size(253, 217);
            this.gbxdanhMuc.TabIndex = 1;
            this.gbxdanhMuc.TabStop = false;
            this.gbxdanhMuc.Text = "Danh mục:";
            // 
            // btnUser
            // 
            this.btnUser.Location = new System.Drawing.Point(0, 170);
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(247, 28);
            this.btnUser.TabIndex = 1;
            this.btnUser.Text = "Quản lý người dùng";
            this.btnUser.UseVisualStyleBackColor = true;
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // btnCompany
            // 
            this.btnCompany.Location = new System.Drawing.Point(-3, 132);
            this.btnCompany.Name = "btnCompany";
            this.btnCompany.Size = new System.Drawing.Size(250, 31);
            this.btnCompany.TabIndex = 0;
            this.btnCompany.Text = "Quản lý nhà cung cấp";
            this.btnCompany.UseVisualStyleBackColor = true;
            this.btnCompany.Click += new System.EventHandler(this.btnCompany_Click);
            // 
            // btnlSP
            // 
            this.btnlSP.Location = new System.Drawing.Point(0, 98);
            this.btnlSP.Name = "btnlSP";
            this.btnlSP.Size = new System.Drawing.Size(247, 31);
            this.btnlSP.TabIndex = 0;
            this.btnlSP.Text = "Quản lý loại sản phẩm";
            this.btnlSP.UseVisualStyleBackColor = true;
            this.btnlSP.Click += new System.EventHandler(this.btnlSP_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(0, 61);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(247, 31);
            this.btnCustomer.TabIndex = 0;
            this.btnCustomer.Text = "Quản lý khách hàng";
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // btnSp
            // 
            this.btnSp.Location = new System.Drawing.Point(1, 24);
            this.btnSp.Name = "btnSp";
            this.btnSp.Size = new System.Drawing.Size(246, 31);
            this.btnSp.TabIndex = 0;
            this.btnSp.Text = "Quản lý sản phẩm";
            this.btnSp.UseVisualStyleBackColor = true;
            this.btnSp.Click += new System.EventHandler(this.btnSp_Click);
            // 
            // gbxchucNang
            // 
            this.gbxchucNang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbxchucNang.Controls.Add(this.btnDetails);
            this.gbxchucNang.Controls.Add(this.btnbanH);
            this.gbxchucNang.Controls.Add(this.btnnhapH);
            this.gbxchucNang.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbxchucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxchucNang.Location = new System.Drawing.Point(1, 365);
            this.gbxchucNang.Name = "gbxchucNang";
            this.gbxchucNang.Size = new System.Drawing.Size(254, 147);
            this.gbxchucNang.TabIndex = 2;
            this.gbxchucNang.TabStop = false;
            this.gbxchucNang.Text = "Chức năng:";
            // 
            // btnDetails
            // 
            this.btnDetails.Location = new System.Drawing.Point(-2, 106);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(250, 30);
            this.btnDetails.TabIndex = 0;
            this.btnDetails.Text = "Chi tiết đơn hàng";
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnbanH
            // 
            this.btnbanH.Location = new System.Drawing.Point(-2, 70);
            this.btnbanH.Name = "btnbanH";
            this.btnbanH.Size = new System.Drawing.Size(250, 30);
            this.btnbanH.TabIndex = 0;
            this.btnbanH.Text = "Bán hàng";
            this.btnbanH.UseVisualStyleBackColor = true;
            this.btnbanH.Click += new System.EventHandler(this.btnbanH_Click);
            // 
            // btnnhapH
            // 
            this.btnnhapH.Location = new System.Drawing.Point(-2, 34);
            this.btnnhapH.Name = "btnnhapH";
            this.btnnhapH.Size = new System.Drawing.Size(250, 30);
            this.btnnhapH.TabIndex = 0;
            this.btnnhapH.Text = "Nhập hàng";
            this.btnnhapH.UseVisualStyleBackColor = true;
            this.btnnhapH.Click += new System.EventHandler(this.btnnhapH_Click);
            // 
            // gbxbctk
            // 
            this.gbxbctk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbxbctk.Controls.Add(this.btnNH);
            this.gbxbctk.Controls.Add(this.btnReportBH);
            this.gbxbctk.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbxbctk.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxbctk.Location = new System.Drawing.Point(3, 530);
            this.gbxbctk.Name = "gbxbctk";
            this.gbxbctk.Size = new System.Drawing.Size(252, 129);
            this.gbxbctk.TabIndex = 3;
            this.gbxbctk.TabStop = false;
            this.gbxbctk.Text = "Báo cáo-Thống kê:";
            // 
            // btnNH
            // 
            this.btnNH.Location = new System.Drawing.Point(4, 73);
            this.btnNH.Name = "btnNH";
            this.btnNH.Size = new System.Drawing.Size(242, 33);
            this.btnNH.TabIndex = 0;
            this.btnNH.Text = "Báo cáo nhập hàng";
            this.btnNH.UseVisualStyleBackColor = true;
            this.btnNH.Click += new System.EventHandler(this.btnNH_Click);
            // 
            // btnReportBH
            // 
            this.btnReportBH.Location = new System.Drawing.Point(6, 34);
            this.btnReportBH.Name = "btnReportBH";
            this.btnReportBH.Size = new System.Drawing.Size(240, 33);
            this.btnReportBH.TabIndex = 0;
            this.btnReportBH.Text = "Báo cáo bán hàng";
            this.btnReportBH.UseVisualStyleBackColor = true;
            this.btnReportBH.Click += new System.EventHandler(this.btnReportBH_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(7, 691);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 4;
            // 
            // panelMenu
            // 
            this.panelMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelMenu.Controls.Add(this.gbxinfor);
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.gbxbctk);
            this.panelMenu.Controls.Add(this.gbxchucNang);
            this.panelMenu.Controls.Add(this.gbxdanhMuc);
            this.panelMenu.Controls.Add(this.gbxuser);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 28);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(261, 722);
            this.panelMenu.TabIndex = 9;
            // 
            // gbxinfor
            // 
            this.gbxinfor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.gbxinfor.Controls.Add(this.button1);
            this.gbxinfor.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbxinfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxinfor.Location = new System.Drawing.Point(3, 681);
            this.gbxinfor.Name = "gbxinfor";
            this.gbxinfor.Size = new System.Drawing.Size(253, 148);
            this.gbxinfor.TabIndex = 5;
            this.gbxinfor.TabStop = false;
            this.gbxinfor.Text = "Sinh viên thực hiện:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(7, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 196);
            this.button1.TabIndex = 0;
            this.button1.Text = "Name:Dương Thành Hải\r\n<---->:Đào Thị Thủy\r\nMssv:1711546085\r\n<-->:1711546207\r\nClas" +
    "s:17DTH1B\r\n";
            this.button1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lbltittle
            // 
            this.lbltittle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbltittle.AutoSize = true;
            this.lbltittle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltittle.Location = new System.Drawing.Point(373, 156);
            this.lbltittle.Name = "lbltittle";
            this.lbltittle.Size = new System.Drawing.Size(629, 20);
            this.lbltittle.TabIndex = 11;
            this.lbltittle.Text = "ssssssssssssssssssssssssssdddddddddddddddddcccccccdddddddddddd\r\n";
            this.lbltittle.Click += new System.EventHandler(this.lbltittle_Click);
            // 
            // Frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::QuanLyBanHang.Properties.Resources.Untitled5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1367, 750);
            this.Controls.Add(this.lbltittle);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.labeltitle);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Quản Lý Bán Hàng";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbxuser.ResumeLayout(false);
            this.gbxuser.PerformLayout();
            this.gbxdanhMuc.ResumeLayout(false);
            this.gbxchucNang.ResumeLayout(false);
            this.gbxbctk.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.gbxinfor.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLSPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLKHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem QLLSPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoThốngKêToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giớiThiệuToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem QLNCCtoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoBánHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoNhậpHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuItemHethong;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuDX;
        private System.Windows.Forms.ToolStripMenuItem mnuDoiMK;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ExitToolsStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chitiettoolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quayThưởngToolStripMenuItem;
        private System.Windows.Forms.Label labeltitle;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gbxuser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.Label lbluser;
        private System.Windows.Forms.GroupBox gbxdanhMuc;
        private System.Windows.Forms.Button btnCompany;
        private System.Windows.Forms.Button btnlSP;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnSp;
        private System.Windows.Forms.GroupBox gbxchucNang;
        private System.Windows.Forms.Button btnDetails;
        private System.Windows.Forms.Button btnbanH;
        private System.Windows.Forms.Button btnnhapH;
        private System.Windows.Forms.GroupBox gbxbctk;
        private System.Windows.Forms.Button btnNH;
        private System.Windows.Forms.Button btnReportBH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.GroupBox gbxinfor;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem usertoolStripMenuItem;
        private System.Windows.Forms.Button btnUser;
        private System.Windows.Forms.Label lbltittle;
    }
}