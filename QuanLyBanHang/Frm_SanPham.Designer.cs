namespace QuanLyBanHang
{
    partial class Frm_SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_SanPham));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtAnh = new System.Windows.Forms.TextBox();
            this.btnAnh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbbmasp = new System.Windows.Forms.ComboBox();
            this.txtIDSP = new System.Windows.Forms.TextBox();
            this.cbb_loaisp1 = new System.Windows.Forms.ComboBox();
            this.cbbdonvitinh = new System.Windows.Forms.ComboBox();
            this.num_soluong = new System.Windows.Forms.NumericUpDown();
            this.cbb_NCC = new System.Windows.Forms.ComboBox();
            this.txt_mota = new System.Windows.Forms.TextBox();
            this.txt_giatien = new System.Windows.Forms.TextBox();
            this.txt_tenSP = new System.Windows.Forms.TextBox();
            this.lbl_trangthai = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTimkiem = new System.Windows.Forms.TextBox();
            this.dgv_danhsachsp = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LoaiSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NCC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HinhAnh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KichCo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_soluong)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachsp)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtAnh);
            this.groupBox1.Controls.Add(this.btnAnh);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbbmasp);
            this.groupBox1.Controls.Add(this.txtIDSP);
            this.groupBox1.Controls.Add(this.cbb_loaisp1);
            this.groupBox1.Controls.Add(this.cbbdonvitinh);
            this.groupBox1.Controls.Add(this.num_soluong);
            this.groupBox1.Controls.Add(this.cbb_NCC);
            this.groupBox1.Controls.Add(this.txt_mota);
            this.groupBox1.Controls.Add(this.txt_giatien);
            this.groupBox1.Controls.Add(this.txt_tenSP);
            this.groupBox1.Controls.Add(this.lbl_trangthai);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(32, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1015, 350);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "  Thông tin chi tiết sản phẩm:";
            // 
            // txtAnh
            // 
            this.txtAnh.Enabled = false;
            this.txtAnh.Location = new System.Drawing.Point(518, 63);
            this.txtAnh.Margin = new System.Windows.Forms.Padding(4);
            this.txtAnh.Multiline = true;
            this.txtAnh.Name = "txtAnh";
            this.txtAnh.Size = new System.Drawing.Size(181, 80);
            this.txtAnh.TabIndex = 15;
            // 
            // btnAnh
            // 
            this.btnAnh.BackColor = System.Drawing.Color.Red;
            this.btnAnh.BackgroundImage = global::QuanLyBanHang.Properties.Resources.contactimportwizard_104257;
            this.btnAnh.Location = new System.Drawing.Point(706, 85);
            this.btnAnh.Name = "btnAnh";
            this.btnAnh.Size = new System.Drawing.Size(37, 34);
            this.btnAnh.TabIndex = 13;
            this.btnAnh.UseVisualStyleBackColor = false;
            this.btnAnh.Click += new System.EventHandler(this.btnAnh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(763, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 108);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(474, 93);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 18);
            this.label9.TabIndex = 11;
            this.label9.Text = "Ảnh:";
            // 
            // cbbmasp
            // 
            this.cbbmasp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbmasp.FormattingEnabled = true;
            this.cbbmasp.Location = new System.Drawing.Point(136, 41);
            this.cbbmasp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbmasp.Name = "cbbmasp";
            this.cbbmasp.Size = new System.Drawing.Size(216, 26);
            this.cbbmasp.TabIndex = 10;
            this.cbbmasp.SelectedIndexChanged += new System.EventHandler(this.cbbmasp_SelectedIndexChanged);
            // 
            // txtIDSP
            // 
            this.txtIDSP.Enabled = false;
            this.txtIDSP.Location = new System.Drawing.Point(136, 41);
            this.txtIDSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIDSP.Name = "txtIDSP";
            this.txtIDSP.Size = new System.Drawing.Size(216, 24);
            this.txtIDSP.TabIndex = 0;
            // 
            // cbb_loaisp1
            // 
            this.cbb_loaisp1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_loaisp1.Enabled = false;
            this.cbb_loaisp1.FormattingEnabled = true;
            this.cbb_loaisp1.Location = new System.Drawing.Point(137, 181);
            this.cbb_loaisp1.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_loaisp1.Name = "cbb_loaisp1";
            this.cbb_loaisp1.Size = new System.Drawing.Size(215, 26);
            this.cbb_loaisp1.TabIndex = 3;
            // 
            // cbbdonvitinh
            // 
            this.cbbdonvitinh.AllowDrop = true;
            this.cbbdonvitinh.Enabled = false;
            this.cbbdonvitinh.FormattingEnabled = true;
            this.cbbdonvitinh.Location = new System.Drawing.Point(215, 266);
            this.cbbdonvitinh.Margin = new System.Windows.Forms.Padding(4);
            this.cbbdonvitinh.Name = "cbbdonvitinh";
            this.cbbdonvitinh.Size = new System.Drawing.Size(137, 26);
            this.cbbdonvitinh.TabIndex = 6;
            // 
            // num_soluong
            // 
            this.num_soluong.Enabled = false;
            this.num_soluong.Location = new System.Drawing.Point(136, 267);
            this.num_soluong.Margin = new System.Windows.Forms.Padding(4);
            this.num_soluong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.num_soluong.Name = "num_soluong";
            this.num_soluong.Size = new System.Drawing.Size(69, 24);
            this.num_soluong.TabIndex = 5;
            this.num_soluong.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // cbb_NCC
            // 
            this.cbb_NCC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_NCC.Enabled = false;
            this.cbb_NCC.FormattingEnabled = true;
            this.cbb_NCC.Location = new System.Drawing.Point(136, 215);
            this.cbb_NCC.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_NCC.Name = "cbb_NCC";
            this.cbb_NCC.Size = new System.Drawing.Size(217, 26);
            this.cbb_NCC.TabIndex = 4;
            this.cbb_NCC.SelectedIndexChanged += new System.EventHandler(this.cbb_NCC_SelectedIndexChanged);
            // 
            // txt_mota
            // 
            this.txt_mota.Enabled = false;
            this.txt_mota.Location = new System.Drawing.Point(548, 169);
            this.txt_mota.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mota.Multiline = true;
            this.txt_mota.Name = "txt_mota";
            this.txt_mota.Size = new System.Drawing.Size(331, 92);
            this.txt_mota.TabIndex = 7;
            // 
            // txt_giatien
            // 
            this.txt_giatien.Enabled = false;
            this.txt_giatien.Location = new System.Drawing.Point(136, 133);
            this.txt_giatien.Margin = new System.Windows.Forms.Padding(4);
            this.txt_giatien.Name = "txt_giatien";
            this.txt_giatien.Size = new System.Drawing.Size(216, 24);
            this.txt_giatien.TabIndex = 2;
            this.txt_giatien.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_giatien_KeyPress);
            // 
            // txt_tenSP
            // 
            this.txt_tenSP.Enabled = false;
            this.txt_tenSP.Location = new System.Drawing.Point(137, 90);
            this.txt_tenSP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tenSP.Name = "txt_tenSP";
            this.txt_tenSP.Size = new System.Drawing.Size(216, 24);
            this.txt_tenSP.TabIndex = 1;
            // 
            // lbl_trangthai
            // 
            this.lbl_trangthai.AutoSize = true;
            this.lbl_trangthai.Location = new System.Drawing.Point(591, 287);
            this.lbl_trangthai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_trangthai.Name = "lbl_trangthai";
            this.lbl_trangthai.Size = new System.Drawing.Size(12, 18);
            this.lbl_trangthai.TabIndex = 0;
            this.lbl_trangthai.Text = ".";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(474, 287);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 18);
            this.label8.TabIndex = 0;
            this.label8.Text = "Trạng thái:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(474, 196);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 18);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mô tả:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 267);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số lượng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 227);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nhà cung cấp:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 185);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 18);
            this.label4.TabIndex = 0;
            this.label4.Text = "Loại sản phẩm:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 137);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Giá tiền/1 đơn vị:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 47);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã sản phẩm:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtTimkiem);
            this.groupBox2.Controls.Add(this.dgv_danhsachsp);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(32, 371);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1015, 358);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách sản phẩm:";
            // 
            // txtTimkiem
            // 
            this.txtTimkiem.Location = new System.Drawing.Point(215, 27);
            this.txtTimkiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTimkiem.Name = "txtTimkiem";
            this.txtTimkiem.Size = new System.Drawing.Size(193, 24);
            this.txtTimkiem.TabIndex = 11;
            this.txtTimkiem.TextChanged += new System.EventHandler(this.txtTimkiem_TextChanged);
            // 
            // dgv_danhsachsp
            // 
            this.dgv_danhsachsp.AllowUserToAddRows = false;
            this.dgv_danhsachsp.AllowUserToDeleteRows = false;
            this.dgv_danhsachsp.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgv_danhsachsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_danhsachsp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaSP,
            this.TenSP,
            this.LoaiSP,
            this.NCC,
            this.MoTa,
            this.HinhAnh,
            this.Gia,
            this.SoLuong,
            this.KichCo});
            this.dgv_danhsachsp.Location = new System.Drawing.Point(13, 65);
            this.dgv_danhsachsp.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_danhsachsp.Name = "dgv_danhsachsp";
            this.dgv_danhsachsp.ReadOnly = true;
            this.dgv_danhsachsp.RowHeadersVisible = false;
            this.dgv_danhsachsp.RowHeadersWidth = 50;
            this.dgv_danhsachsp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_danhsachsp.ShowRowErrors = false;
            this.dgv_danhsachsp.Size = new System.Drawing.Size(929, 274);
            this.dgv_danhsachsp.TabIndex = 10;
            this.dgv_danhsachsp.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_danhsachsp_RowEnter);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 33);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(166, 18);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tìm kiếm tên sản phẩm:";
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.Red;
            this.lblDateTime.Location = new System.Drawing.Point(577, 32);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(13, 17);
            this.lblDateTime.TabIndex = 4;
            this.lblDateTime.Text = ".";
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancel.Image = global::QuanLyBanHang.Properties.Resources.iconfinder_Cancel_1493282;
            this.btn_Cancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cancel.Location = new System.Drawing.Point(1054, 262);
            this.btn_Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(130, 56);
            this.btn_Cancel.TabIndex = 11;
            this.btn_Cancel.Text = "     Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            this.btn_Cancel.Visible = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Image = ((System.Drawing.Image)(resources.GetObject("btn_Delete.Image")));
            this.btn_Delete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Delete.Location = new System.Drawing.Point(1053, 146);
            this.btn_Delete.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(130, 52);
            this.btn_Delete.TabIndex = 0;
            this.btn_Delete.Text = "       Delete";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Update.Image = global::QuanLyBanHang.Properties.Resources.cloudrefresh_icon_icons_com_54403;
            this.btn_Update.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Update.Location = new System.Drawing.Point(1053, 82);
            this.btn_Update.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(130, 52);
            this.btn_Update.TabIndex = 0;
            this.btn_Update.Text = "        Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Save.Enabled = false;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.Image = global::QuanLyBanHang.Properties.Resources.iconfinder_floppy_285657;
            this.btn_Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Save.Location = new System.Drawing.Point(1053, 204);
            this.btn_Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(130, 54);
            this.btn_Save.TabIndex = 8;
            this.btn_Save.Text = "     Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // STT
            // 
            this.STT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.STT.DataPropertyName = "STT";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.STT.DefaultCellStyle = dataGridViewCellStyle1;
            this.STT.HeaderText = "STT";
            this.STT.MinimumWidth = 6;
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            this.STT.Visible = false;
            this.STT.Width = 50;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            this.MaSP.Width = 70;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.HeaderText = "Tên sảm phẩm";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            this.TenSP.Width = 150;
            // 
            // LoaiSP
            // 
            this.LoaiSP.DataPropertyName = "LoaiSP";
            this.LoaiSP.HeaderText = "Loại sản phẩm";
            this.LoaiSP.MinimumWidth = 6;
            this.LoaiSP.Name = "LoaiSP";
            this.LoaiSP.ReadOnly = true;
            this.LoaiSP.Width = 125;
            // 
            // NCC
            // 
            this.NCC.DataPropertyName = "NCC";
            this.NCC.HeaderText = "Nhà cung cấp";
            this.NCC.MinimumWidth = 6;
            this.NCC.Name = "NCC";
            this.NCC.ReadOnly = true;
            this.NCC.Width = 120;
            // 
            // MoTa
            // 
            this.MoTa.DataPropertyName = "MoTa";
            this.MoTa.HeaderText = "Mô tả";
            this.MoTa.MinimumWidth = 6;
            this.MoTa.Name = "MoTa";
            this.MoTa.ReadOnly = true;
            this.MoTa.Visible = false;
            this.MoTa.Width = 125;
            // 
            // HinhAnh
            // 
            this.HinhAnh.DataPropertyName = "HinhAnh";
            this.HinhAnh.HeaderText = "Hình Ảnh";
            this.HinhAnh.MinimumWidth = 6;
            this.HinhAnh.Name = "HinhAnh";
            this.HinhAnh.ReadOnly = true;
            this.HinhAnh.Width = 125;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "Gia";
            this.Gia.HeaderText = "Giá tiền";
            this.Gia.MinimumWidth = 6;
            this.Gia.Name = "Gia";
            this.Gia.ReadOnly = true;
            this.Gia.Width = 106;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            this.SoLuong.Width = 125;
            // 
            // KichCo
            // 
            this.KichCo.DataPropertyName = "KichCo";
            this.KichCo.HeaderText = "Kích Cở";
            this.KichCo.MinimumWidth = 6;
            this.KichCo.Name = "KichCo";
            this.KichCo.ReadOnly = true;
            this.KichCo.Width = 125;
            // 
            // Frm_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1196, 757);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_SanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Sản Phẩm";
            this.Load += new System.EventHandler(this.Frm_SanPham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_soluong)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_danhsachsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_giatien;
        private System.Windows.Forms.TextBox txt_tenSP;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_NCC;
        private System.Windows.Forms.TextBox txt_mota;
        private System.Windows.Forms.Label lbl_trangthai;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgv_danhsachsp;
        private System.Windows.Forms.NumericUpDown num_soluong;
        private System.Windows.Forms.ComboBox cbbdonvitinh;
        private System.Windows.Forms.ComboBox cbb_loaisp1;
        private System.Windows.Forms.TextBox txtTimkiem;
        private System.Windows.Forms.TextBox txtIDSP;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.ComboBox cbbmasp;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btnAnh;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn LoaiSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NCC;
        private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
        private System.Windows.Forms.DataGridViewTextBoxColumn HinhAnh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn KichCo;
    }
}