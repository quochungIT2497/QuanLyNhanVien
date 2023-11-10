namespace BaiTapWinForm
{
    partial class Form1
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
            this.dgv_QLNV = new System.Windows.Forms.DataGridView();
            this.lbl_QL = new System.Windows.Forms.Label();
            this.grp_TK = new System.Windows.Forms.GroupBox();
            this.lbl_TK = new System.Windows.Forms.Label();
            this.txt_TK = new System.Windows.Forms.TextBox();
            this.comboBox_SapXep = new System.Windows.Forms.ComboBox();
            this.lbl_SapXep = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lưuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dữLiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grp_data = new System.Windows.Forms.GroupBox();
            this.grp_ChucNang = new System.Windows.Forms.GroupBox();
            this.lbl_HoTen = new System.Windows.Forms.Label();
            this.comboBox_MNV = new System.Windows.Forms.ComboBox();
            this.txt_HT = new System.Windows.Forms.TextBox();
            this.lbl_Phai = new System.Windows.Forms.Label();
            this.lbl_Dchi = new System.Windows.Forms.Label();
            this.txt_DC = new System.Windows.Forms.TextBox();
            this.lbl_Luong = new System.Windows.Forms.Label();
            this.txt_LUONG = new System.Windows.Forms.TextBox();
            this.lbl_MaNQL = new System.Windows.Forms.Label();
            this.txt_MNQL = new System.Windows.Forms.TextBox();
            this.lbl_Phg = new System.Windows.Forms.Label();
            this.txt_PHG = new System.Windows.Forms.TextBox();
            this.btn_Them = new System.Windows.Forms.Button();
            this.btn_Sua = new System.Windows.Forms.Button();
            this.lbl_MaNV = new System.Windows.Forms.Label();
            this.btn_Xoa = new System.Windows.Forms.Button();
            this.grp_TT = new System.Windows.Forms.GroupBox();
            this.comboBox_PHAI = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLNV)).BeginInit();
            this.grp_TK.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.grp_data.SuspendLayout();
            this.grp_TT.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgv_QLNV
            // 
            this.dgv_QLNV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_QLNV.Location = new System.Drawing.Point(0, 19);
            this.dgv_QLNV.Name = "dgv_QLNV";
            this.dgv_QLNV.Size = new System.Drawing.Size(490, 259);
            this.dgv_QLNV.TabIndex = 0;
            this.dgv_QLNV.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_QLNV_CellDoubleClick);
            // 
            // lbl_QL
            // 
            this.lbl_QL.AutoSize = true;
            this.lbl_QL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_QL.Location = new System.Drawing.Point(254, 9);
            this.lbl_QL.Name = "lbl_QL";
            this.lbl_QL.Size = new System.Drawing.Size(248, 31);
            this.lbl_QL.TabIndex = 9;
            this.lbl_QL.Text = "Quản lý nhân viên";
            // 
            // grp_TK
            // 
            this.grp_TK.Controls.Add(this.lbl_TK);
            this.grp_TK.Controls.Add(this.txt_TK);
            this.grp_TK.Controls.Add(this.comboBox_SapXep);
            this.grp_TK.Controls.Add(this.lbl_SapXep);
            this.grp_TK.Location = new System.Drawing.Point(12, 32);
            this.grp_TK.Name = "grp_TK";
            this.grp_TK.Size = new System.Drawing.Size(490, 82);
            this.grp_TK.TabIndex = 11;
            this.grp_TK.TabStop = false;
            this.grp_TK.Text = "Công cụ";
            // 
            // lbl_TK
            // 
            this.lbl_TK.AutoSize = true;
            this.lbl_TK.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_TK.Location = new System.Drawing.Point(10, 56);
            this.lbl_TK.Name = "lbl_TK";
            this.lbl_TK.Size = new System.Drawing.Size(50, 13);
            this.lbl_TK.TabIndex = 17;
            this.lbl_TK.Text = "Tìm Kiếm";
            // 
            // txt_TK
            // 
            this.txt_TK.Location = new System.Drawing.Point(66, 53);
            this.txt_TK.Name = "txt_TK";
            this.txt_TK.Size = new System.Drawing.Size(159, 20);
            this.txt_TK.TabIndex = 16;
            this.txt_TK.TextChanged += new System.EventHandler(this.txt_TK_TextChanged);
            // 
            // comboBox_SapXep
            // 
            this.comboBox_SapXep.FormattingEnabled = true;
            this.comboBox_SapXep.Items.AddRange(new object[] {
            "Họ Tên",
            "Phòng"});
            this.comboBox_SapXep.Location = new System.Drawing.Point(314, 52);
            this.comboBox_SapXep.Name = "comboBox_SapXep";
            this.comboBox_SapXep.Size = new System.Drawing.Size(159, 21);
            this.comboBox_SapXep.TabIndex = 15;
            this.comboBox_SapXep.SelectedIndexChanged += new System.EventHandler(this.comboBox_SapXep_SelectedIndexChanged);
            // 
            // lbl_SapXep
            // 
            this.lbl_SapXep.AutoSize = true;
            this.lbl_SapXep.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_SapXep.Location = new System.Drawing.Point(260, 55);
            this.lbl_SapXep.Name = "lbl_SapXep";
            this.lbl_SapXep.Size = new System.Drawing.Size(48, 13);
            this.lbl_SapXep.TabIndex = 10;
            this.lbl_SapXep.Text = "Sắp Xếp";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem,
            this.dữLiệuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lưuToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức Năng";
            // 
            // lưuToolStripMenuItem
            // 
            this.lưuToolStripMenuItem.Name = "lưuToolStripMenuItem";
            this.lưuToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.lưuToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.lưuToolStripMenuItem.Text = "Lưu";
            this.lưuToolStripMenuItem.Click += new System.EventHandler(this.lưuToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // dữLiệuToolStripMenuItem
            // 
            this.dữLiệuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thốngKêToolStripMenuItem});
            this.dữLiệuToolStripMenuItem.Name = "dữLiệuToolStripMenuItem";
            this.dữLiệuToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.dữLiệuToolStripMenuItem.Text = "Dữ liệu";
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.X)));
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.thốngKêToolStripMenuItem.Text = "Thống kê";
            this.thốngKêToolStripMenuItem.Click += new System.EventHandler(this.thốngKêToolStripMenuItem_Click);
            // 
            // grp_data
            // 
            this.grp_data.Controls.Add(this.dgv_QLNV);
            this.grp_data.Location = new System.Drawing.Point(12, 120);
            this.grp_data.Name = "grp_data";
            this.grp_data.Size = new System.Drawing.Size(490, 278);
            this.grp_data.TabIndex = 12;
            this.grp_data.TabStop = false;
            this.grp_data.Text = "Dữ liệu";
            // 
            // grp_ChucNang
            // 
            this.grp_ChucNang.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_ChucNang.Location = new System.Drawing.Point(0, 285);
            this.grp_ChucNang.Name = "grp_ChucNang";
            this.grp_ChucNang.Size = new System.Drawing.Size(280, 81);
            this.grp_ChucNang.TabIndex = 13;
            this.grp_ChucNang.TabStop = false;
            this.grp_ChucNang.Text = "Thanh xử lý";
            // 
            // lbl_HoTen
            // 
            this.lbl_HoTen.AutoSize = true;
            this.lbl_HoTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_HoTen.Location = new System.Drawing.Point(7, 65);
            this.lbl_HoTen.Name = "lbl_HoTen";
            this.lbl_HoTen.Size = new System.Drawing.Size(43, 13);
            this.lbl_HoTen.TabIndex = 2;
            this.lbl_HoTen.Text = "Họ Tên";
            // 
            // comboBox_MNV
            // 
            this.comboBox_MNV.FormattingEnabled = true;
            this.comboBox_MNV.Items.AddRange(new object[] {
            "111",
            "222",
            "333",
            "444",
            "555",
            "666",
            "777",
            "888",
            "987"});
            this.comboBox_MNV.Location = new System.Drawing.Point(82, 28);
            this.comboBox_MNV.Name = "comboBox_MNV";
            this.comboBox_MNV.Size = new System.Drawing.Size(159, 21);
            this.comboBox_MNV.TabIndex = 3;
            this.comboBox_MNV.SelectedIndexChanged += new System.EventHandler(this.comboBox_MNV_SelectedIndexChanged);
            // 
            // txt_HT
            // 
            this.txt_HT.Location = new System.Drawing.Point(82, 62);
            this.txt_HT.Name = "txt_HT";
            this.txt_HT.Size = new System.Drawing.Size(159, 20);
            this.txt_HT.TabIndex = 4;
            // 
            // lbl_Phai
            // 
            this.lbl_Phai.AutoSize = true;
            this.lbl_Phai.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Phai.Location = new System.Drawing.Point(7, 98);
            this.lbl_Phai.Name = "lbl_Phai";
            this.lbl_Phai.Size = new System.Drawing.Size(28, 13);
            this.lbl_Phai.TabIndex = 3;
            this.lbl_Phai.Text = "Phái";
            // 
            // lbl_Dchi
            // 
            this.lbl_Dchi.AutoSize = true;
            this.lbl_Dchi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Dchi.Location = new System.Drawing.Point(7, 131);
            this.lbl_Dchi.Name = "lbl_Dchi";
            this.lbl_Dchi.Size = new System.Drawing.Size(41, 13);
            this.lbl_Dchi.TabIndex = 4;
            this.lbl_Dchi.Text = "Địa Chỉ";
            // 
            // txt_DC
            // 
            this.txt_DC.Location = new System.Drawing.Point(82, 128);
            this.txt_DC.Name = "txt_DC";
            this.txt_DC.Size = new System.Drawing.Size(159, 20);
            this.txt_DC.TabIndex = 6;
            // 
            // lbl_Luong
            // 
            this.lbl_Luong.AutoSize = true;
            this.lbl_Luong.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Luong.Location = new System.Drawing.Point(7, 164);
            this.lbl_Luong.Name = "lbl_Luong";
            this.lbl_Luong.Size = new System.Drawing.Size(37, 13);
            this.lbl_Luong.TabIndex = 5;
            this.lbl_Luong.Text = "Lương";
            // 
            // txt_LUONG
            // 
            this.txt_LUONG.Location = new System.Drawing.Point(82, 161);
            this.txt_LUONG.Name = "txt_LUONG";
            this.txt_LUONG.Size = new System.Drawing.Size(159, 20);
            this.txt_LUONG.TabIndex = 7;
            this.txt_LUONG.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_LUONG_KeyPress);
            // 
            // lbl_MaNQL
            // 
            this.lbl_MaNQL.AutoSize = true;
            this.lbl_MaNQL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_MaNQL.Location = new System.Drawing.Point(7, 197);
            this.lbl_MaNQL.Name = "lbl_MaNQL";
            this.lbl_MaNQL.Size = new System.Drawing.Size(47, 13);
            this.lbl_MaNQL.TabIndex = 6;
            this.lbl_MaNQL.Text = "Mã NQL";
            // 
            // txt_MNQL
            // 
            this.txt_MNQL.Location = new System.Drawing.Point(82, 194);
            this.txt_MNQL.Name = "txt_MNQL";
            this.txt_MNQL.Size = new System.Drawing.Size(159, 20);
            this.txt_MNQL.TabIndex = 8;
            // 
            // lbl_Phg
            // 
            this.lbl_Phg.AutoSize = true;
            this.lbl_Phg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Phg.Location = new System.Drawing.Point(7, 230);
            this.lbl_Phg.Name = "lbl_Phg";
            this.lbl_Phg.Size = new System.Drawing.Size(38, 13);
            this.lbl_Phg.TabIndex = 7;
            this.lbl_Phg.Text = "Phòng";
            // 
            // txt_PHG
            // 
            this.txt_PHG.Location = new System.Drawing.Point(82, 227);
            this.txt_PHG.Name = "txt_PHG";
            this.txt_PHG.Size = new System.Drawing.Size(159, 20);
            this.txt_PHG.TabIndex = 9;
            // 
            // btn_Them
            // 
            this.btn_Them.AutoSize = true;
            this.btn_Them.BackColor = System.Drawing.Color.Teal;
            this.btn_Them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Them.ForeColor = System.Drawing.Color.White;
            this.btn_Them.Location = new System.Drawing.Point(7, 327);
            this.btn_Them.Name = "btn_Them";
            this.btn_Them.Size = new System.Drawing.Size(75, 30);
            this.btn_Them.TabIndex = 10;
            this.btn_Them.Text = "Thêm";
            this.btn_Them.UseVisualStyleBackColor = false;
            this.btn_Them.Click += new System.EventHandler(this.btn_Them_Click);
            // 
            // btn_Sua
            // 
            this.btn_Sua.AutoSize = true;
            this.btn_Sua.BackColor = System.Drawing.Color.Navy;
            this.btn_Sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sua.ForeColor = System.Drawing.Color.White;
            this.btn_Sua.Location = new System.Drawing.Point(103, 327);
            this.btn_Sua.Name = "btn_Sua";
            this.btn_Sua.Size = new System.Drawing.Size(75, 30);
            this.btn_Sua.TabIndex = 11;
            this.btn_Sua.Text = "Sửa";
            this.btn_Sua.UseVisualStyleBackColor = false;
            this.btn_Sua.Click += new System.EventHandler(this.btn_Sua_Click);
            // 
            // lbl_MaNV
            // 
            this.lbl_MaNV.AutoSize = true;
            this.lbl_MaNV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_MaNV.Location = new System.Drawing.Point(7, 31);
            this.lbl_MaNV.Name = "lbl_MaNV";
            this.lbl_MaNV.Size = new System.Drawing.Size(75, 13);
            this.lbl_MaNV.TabIndex = 1;
            this.lbl_MaNV.Text = "Mã Nhân Viên";
            // 
            // btn_Xoa
            // 
            this.btn_Xoa.AutoSize = true;
            this.btn_Xoa.BackColor = System.Drawing.Color.Green;
            this.btn_Xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa.Location = new System.Drawing.Point(199, 327);
            this.btn_Xoa.Name = "btn_Xoa";
            this.btn_Xoa.Size = new System.Drawing.Size(75, 30);
            this.btn_Xoa.TabIndex = 12;
            this.btn_Xoa.Text = "Xóa";
            this.btn_Xoa.UseVisualStyleBackColor = false;
            this.btn_Xoa.Click += new System.EventHandler(this.btn_Xoa_Click);
            // 
            // grp_TT
            // 
            this.grp_TT.Controls.Add(this.comboBox_PHAI);
            this.grp_TT.Controls.Add(this.btn_Xoa);
            this.grp_TT.Controls.Add(this.lbl_MaNV);
            this.grp_TT.Controls.Add(this.btn_Sua);
            this.grp_TT.Controls.Add(this.btn_Them);
            this.grp_TT.Controls.Add(this.txt_PHG);
            this.grp_TT.Controls.Add(this.lbl_Phg);
            this.grp_TT.Controls.Add(this.txt_MNQL);
            this.grp_TT.Controls.Add(this.lbl_MaNQL);
            this.grp_TT.Controls.Add(this.txt_LUONG);
            this.grp_TT.Controls.Add(this.lbl_Luong);
            this.grp_TT.Controls.Add(this.txt_DC);
            this.grp_TT.Controls.Add(this.lbl_Dchi);
            this.grp_TT.Controls.Add(this.lbl_Phai);
            this.grp_TT.Controls.Add(this.txt_HT);
            this.grp_TT.Controls.Add(this.comboBox_MNV);
            this.grp_TT.Controls.Add(this.lbl_HoTen);
            this.grp_TT.Controls.Add(this.grp_ChucNang);
            this.grp_TT.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grp_TT.Location = new System.Drawing.Point(508, 32);
            this.grp_TT.Name = "grp_TT";
            this.grp_TT.Size = new System.Drawing.Size(280, 365);
            this.grp_TT.TabIndex = 10;
            this.grp_TT.TabStop = false;
            this.grp_TT.Text = "Thông Tin";
            // 
            // comboBox_PHAI
            // 
            this.comboBox_PHAI.FormattingEnabled = true;
            this.comboBox_PHAI.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBox_PHAI.Location = new System.Drawing.Point(82, 95);
            this.comboBox_PHAI.Name = "comboBox_PHAI";
            this.comboBox_PHAI.Size = new System.Drawing.Size(159, 21);
            this.comboBox_PHAI.TabIndex = 14;
            // 
            // timer1
            // 
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 409);
            this.Controls.Add(this.lbl_QL);
            this.Controls.Add(this.grp_TT);
            this.Controls.Add(this.grp_TK);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.grp_data);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Trình Quản Lý Nhân Viên";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_QLNV)).EndInit();
            this.grp_TK.ResumeLayout(false);
            this.grp_TK.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grp_data.ResumeLayout(false);
            this.grp_TT.ResumeLayout(false);
            this.grp_TT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_QLNV;
        private System.Windows.Forms.Label lbl_QL;
        private System.Windows.Forms.GroupBox grp_TK;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.GroupBox grp_data;
        private System.Windows.Forms.GroupBox grp_ChucNang;
        private System.Windows.Forms.Label lbl_HoTen;
        private System.Windows.Forms.ComboBox comboBox_MNV;
        private System.Windows.Forms.TextBox txt_HT;
        private System.Windows.Forms.Label lbl_Phai;
        private System.Windows.Forms.Label lbl_Dchi;
        private System.Windows.Forms.TextBox txt_DC;
        private System.Windows.Forms.Label lbl_Luong;
        private System.Windows.Forms.TextBox txt_LUONG;
        private System.Windows.Forms.Label lbl_MaNQL;
        private System.Windows.Forms.TextBox txt_MNQL;
        private System.Windows.Forms.Label lbl_Phg;
        private System.Windows.Forms.TextBox txt_PHG;
        private System.Windows.Forms.Button btn_Them;
        private System.Windows.Forms.Button btn_Sua;
        private System.Windows.Forms.Label lbl_MaNV;
        private System.Windows.Forms.Button btn_Xoa;
        private System.Windows.Forms.GroupBox grp_TT;
        private System.Windows.Forms.ComboBox comboBox_PHAI;
        private System.Windows.Forms.TextBox txt_TK;
        private System.Windows.Forms.ComboBox comboBox_SapXep;
        private System.Windows.Forms.Label lbl_SapXep;
        private System.Windows.Forms.ToolStripMenuItem lưuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dữLiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label lbl_TK;
        private System.Windows.Forms.Timer timer1;
    }
}

