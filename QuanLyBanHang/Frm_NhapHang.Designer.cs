namespace QuanLyBanHang
{
    partial class Frm_NhapHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NhapHang));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numSL = new System.Windows.Forms.NumericUpDown();
            this.cbbdonvitinh = new System.Windows.Forms.ComboBox();
            this.cbbNCC = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbbMaSP = new System.Windows.Forms.ComboBox();
            this.txtGianhap = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblsoluongton = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvnhaphang = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoHDNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donvidoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtsoHDN = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Import = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Edit = new System.Windows.Forms.Button();
            this.btnNhapHang = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.btnAnh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhaphang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // txtTenSP
            // 
            this.txtTenSP.Enabled = false;
            this.txtTenSP.Location = new System.Drawing.Point(160, 86);
            this.txtTenSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(193, 24);
            this.txtTenSP.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 18);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nhà cung cấp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Số lượng nhập:";
            // 
            // numSL
            // 
            this.numSL.Enabled = false;
            this.numSL.Location = new System.Drawing.Point(574, 165);
            this.numSL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numSL.Name = "numSL";
            this.numSL.Size = new System.Drawing.Size(83, 24);
            this.numSL.TabIndex = 3;
            // 
            // cbbdonvitinh
            // 
            this.cbbdonvitinh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbdonvitinh.FormattingEnabled = true;
            this.cbbdonvitinh.Items.AddRange(new object[] {
            "  Mini size ",
            "Mediumsize ",
            "Small size",
            " Large size"});
            this.cbbdonvitinh.Location = new System.Drawing.Point(673, 165);
            this.cbbdonvitinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbdonvitinh.Name = "cbbdonvitinh";
            this.cbbdonvitinh.Size = new System.Drawing.Size(112, 26);
            this.cbbdonvitinh.TabIndex = 4;
            // 
            // cbbNCC
            // 
            this.cbbNCC.FormattingEnabled = true;
            this.cbbNCC.Location = new System.Drawing.Point(160, 183);
            this.cbbNCC.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbNCC.Name = "cbbNCC";
            this.cbbNCC.Size = new System.Drawing.Size(193, 26);
            this.cbbNCC.TabIndex = 5;
            this.cbbNCC.SelectedIndexChanged += new System.EventHandler(this.cbbNCC_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.btnAnh);
            this.groupBox1.Controls.Add(this.txtAnh);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbbMaSP);
            this.groupBox1.Controls.Add(this.cbbNCC);
            this.groupBox1.Controls.Add(this.cbbdonvitinh);
            this.groupBox1.Controls.Add(this.numSL);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtGianhap);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblsoluongton);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(8, 87);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(1118, 287);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin sản phẩm";
            // 
            // cbbMaSP
            // 
            this.cbbMaSP.FormattingEnabled = true;
            this.cbbMaSP.Location = new System.Drawing.Point(160, 30);
            this.cbbMaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMaSP.Name = "cbbMaSP";
            this.cbbMaSP.Size = new System.Drawing.Size(193, 26);
            this.cbbMaSP.TabIndex = 14;
            this.cbbMaSP.SelectedIndexChanged += new System.EventHandler(this.cbbMaSP_SelectedIndexChanged);
            this.cbbMaSP.TextChanged += new System.EventHandler(this.cbbMaSP_TextChanged);
            // 
            // txtGianhap
            // 
            this.txtGianhap.Enabled = false;
            this.txtGianhap.Location = new System.Drawing.Point(160, 139);
            this.txtGianhap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGianhap.Name = "txtGianhap";
            this.txtGianhap.Size = new System.Drawing.Size(193, 24);
            this.txtGianhap.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Giá nhập/1 đơn vị:";
            // 
            // lblsoluongton
            // 
            this.lblsoluongton.AutoSize = true;
            this.lblsoluongton.Location = new System.Drawing.Point(571, 191);
            this.lblsoluongton.Name = "lblsoluongton";
            this.lblsoluongton.Size = new System.Drawing.Size(12, 18);
            this.lblsoluongton.TabIndex = 1;
            this.lblsoluongton.Text = ".";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 191);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 18);
            this.label5.TabIndex = 1;
            this.label5.Text = "Số lượng tồn:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvnhaphang);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 427);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(1114, 341);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách hàng nhập";
            // 
            // dgvnhaphang
            // 
            this.dgvnhaphang.AllowUserToAddRows = false;
            this.dgvnhaphang.AllowUserToDeleteRows = false;
            this.dgvnhaphang.AllowUserToResizeColumns = false;
            this.dgvnhaphang.AllowUserToResizeRows = false;
            this.dgvnhaphang.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvnhaphang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnhaphang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.SoHDNhap,
            this.MaSP,
            this.TenSP,
            this.NgayNhap,
            this.NCC,
            this.SoLuongNhap,
            this.GiaNhap,
            this.Donvidoluong,
            this.SoLuong});
            this.dgvnhaphang.Location = new System.Drawing.Point(5, 21);
            this.dgvnhaphang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvnhaphang.Name = "dgvnhaphang";
            this.dgvnhaphang.ReadOnly = true;
            this.dgvnhaphang.RowHeadersVisible = false;
            this.dgvnhaphang.RowHeadersWidth = 51;
            this.dgvnhaphang.RowTemplate.Height = 24;
            this.dgvnhaphang.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvnhaphang.ShowRowErrors = false;
            this.dgvnhaphang.Size = new System.Drawing.Size(1097, 309);
            this.dgvnhaphang.TabIndex = 0;
            this.dgvnhaphang.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnhaphang_RowEnter);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Width = 50;
            // 
            // SoHDNhap
            // 
            this.SoHDNhap.DataPropertyName = "SoHDNhap";
            this.SoHDNhap.HeaderText = "SHĐN";
            this.SoHDNhap.MinimumWidth = 6;
            this.SoHDNhap.Name = "SoHDNhap";
            this.SoHDNhap.ReadOnly = true;
            this.SoHDNhap.Width = 60;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            this.MaSP.Width = 125;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên SP";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            this.TenSP.Width = 120;
            // 
            // NgayNhap
            // 
            this.NgayNhap.DataPropertyName = "NgayNhap";
            this.NgayNhap.HeaderText = "Ngày nhập";
            this.NgayNhap.MinimumWidth = 6;
            this.NgayNhap.Name = "NgayNhap";
            this.NgayNhap.ReadOnly = true;
            this.NgayNhap.Width = 110;
            // 
            // NCC
            // 
            this.NCC.DataPropertyName = "NCC";
            this.NCC.HeaderText = "Nhà cung cấp";
            this.NCC.MinimumWidth = 6;
            this.NCC.Name = "NCC";
            this.NCC.ReadOnly = true;
            this.NCC.Width = 140;
            // 
            // SoLuongNhap
            // 
            this.SoLuongNhap.DataPropertyName = "SoLuongNhap";
            this.SoLuongNhap.HeaderText = "Số lượng nhập";
            this.SoLuongNhap.MinimumWidth = 6;
            this.SoLuongNhap.Name = "SoLuongNhap";
            this.SoLuongNhap.ReadOnly = true;
            this.SoLuongNhap.Width = 140;
            // 
            // GiaNhap
            // 
            this.GiaNhap.DataPropertyName = "GiaNhap";
            this.GiaNhap.HeaderText = "Giá nhập/1 đơn vị";
            this.GiaNhap.MinimumWidth = 6;
            this.GiaNhap.Name = "GiaNhap";
            this.GiaNhap.ReadOnly = true;
            this.GiaNhap.Width = 110;
            // 
            // Donvidoluong
            // 
            this.Donvidoluong.DataPropertyName = "Donvidoluong";
            this.Donvidoluong.HeaderText = "Kích thước";
            this.Donvidoluong.MinimumWidth = 6;
            this.Donvidoluong.Name = "Donvidoluong";
            this.Donvidoluong.ReadOnly = true;
            this.Donvidoluong.Width = 120;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng tồn";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 140;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.Red;
            this.lblDateTime.Location = new System.Drawing.Point(541, 31);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(13, 17);
            this.lblDateTime.TabIndex = 9;
            this.lblDateTime.Text = ".";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(213, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Số hóa đơn nhập:";
            // 
            // txtsoHDN
            // 
            this.txtsoHDN.Enabled = false;
            this.txtsoHDN.Location = new System.Drawing.Point(364, 30);
            this.txtsoHDN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtsoHDN.Name = "txtsoHDN";
            this.txtsoHDN.Size = new System.Drawing.Size(123, 22);
            this.txtsoHDN.TabIndex = 11;
            // 
            // btn_Exit
            // 
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.Image = global::QuanLyBanHang.Properties.Resources.SignOut_icon_icons2;
            this.btn_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Exit.Location = new System.Drawing.Point(984, 378);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(108, 45);
            this.btn_Exit.TabIndex = 13;
            this.btn_Exit.Text = "        Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Visible = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Image = global::QuanLyBanHang.Properties.Resources.iconfinder_floppy_285657;
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(854, 378);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(102, 45);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "         Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Import
            // 
            this.btn_Import.Enabled = false;
            this.btn_Import.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Import.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Import.Image = global::QuanLyBanHang.Properties.Resources._1486485526_add_browser_new_window_81148__1_1;
            this.btn_Import.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Import.Location = new System.Drawing.Point(412, 378);
            this.btn_Import.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Import.Name = "btn_Import";
            this.btn_Import.Size = new System.Drawing.Size(122, 45);
            this.btn_Import.TabIndex = 0;
            this.btn_Import.Text = "     Import";
            this.btn_Import.UseVisualStyleBackColor = true;
            this.btn_Import.Click += new System.EventHandler(this.btn_Import_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Enabled = false;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Image = global::QuanLyBanHang.Properties.Resources._1486504830_delete_dustbin_empty_recycle_recycling_remove_trash_813615;
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(708, 378);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(130, 45);
            this.btn_Delete.TabIndex = 0;
            this.btn_Delete.Text = "        Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Edit
            // 
            this.btn_Edit.Enabled = false;
            this.btn_Edit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Edit.Image = global::QuanLyBanHang.Properties.Resources.if_compose_10550851;
            this.btn_Edit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Edit.Location = new System.Drawing.Point(565, 378);
            this.btn_Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Edit.Name = "btn_Edit";
            this.btn_Edit.Size = new System.Drawing.Size(123, 45);
            this.btn_Edit.TabIndex = 0;
            this.btn_Edit.Text = "    Edit";
            this.btn_Edit.UseVisualStyleBackColor = true;
            this.btn_Edit.Click += new System.EventHandler(this.btn_Edit_Click);
            // 
            // btnNhapHang
            // 
            this.btnNhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNhapHang.Image = global::QuanLyBanHang.Properties.Resources.if_document_add_48755;
            this.btnNhapHang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhapHang.Location = new System.Drawing.Point(20, 11);
            this.btnNhapHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhapHang.Name = "btnNhapHang";
            this.btnNhapHang.Size = new System.Drawing.Size(137, 57);
            this.btnNhapHang.TabIndex = 0;
            this.btnNhapHang.Text = "Nhập hàng";
            this.btnNhapHang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhapHang.UseVisualStyleBackColor = true;
            this.btnNhapHang.Click += new System.EventHandler(this.btnNhapHang_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(470, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ảnh:";
            // 
            // txtAnh
            // 
            this.txtAnh.Enabled = false;
            this.txtAnh.Location = new System.Drawing.Point(514, 39);
            this.txtAnh.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnh.Multiline = true;
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(181, 80);
            this.txtAnh.TabIndex = 16;
            // 
            // btnAnh
            // 
            this.btnAnh.BackColor = System.Drawing.Color.Red;
            this.btnAnh.BackgroundImage = global::QuanLyBanHang.Properties.Resources.contactimportwizard_104257;
            this.btnAnh.Location = new System.Drawing.Point(714, 65);
            this.btnAnh.Name = "btnAnh";
            this.btnAnh.Size = new System.Drawing.Size(37, 34);
            this.btnAnh.TabIndex = 17;
            this.btnAnh.UseVisualStyleBackColor = false;
            this.btnAnh.Click += new System.EventHandler(this.btnAnh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(771, 22);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(293, 138);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // Frm_NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1170, 789);
            this.Controls.Add(this.txtsoHDN);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_Import);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.btn_Edit);
            this.Controls.Add(this.btnNhapHang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_NhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý nhập hàng";
            this.Load += new System.EventHandler(this.Frm_NhapHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numSL)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnhaphang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNhapHang;
        private System.Windows.Forms.Button btn_Edit;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numSL;
        private System.Windows.Forms.ComboBox cbbdonvitinh;
        private System.Windows.Forms.ComboBox cbbNCC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvnhaphang;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lblsoluongton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbbMaSP;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.TextBox txtGianhap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_Import;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtsoHDN;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoHDNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donvidoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.Button btnAnh;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}