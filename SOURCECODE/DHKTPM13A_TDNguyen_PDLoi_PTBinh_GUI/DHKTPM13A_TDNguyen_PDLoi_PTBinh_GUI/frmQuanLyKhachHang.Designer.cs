namespace DHKTPM13A_TDNguyen_PDLoi_PTBinh_GUI
{
    partial class frmQuanLyKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxSoDienThoai = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblSoDienThoai = new System.Windows.Forms.Label();
            this.tbxCMND = new System.Windows.Forms.TextBox();
            this.dgvKH = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.gbDanhSachNhanVien = new System.Windows.Forms.GroupBox();
            this.tbxTenKhachHang = new System.Windows.Forms.TextBox();
            this.tbxMaKhachHang = new System.Windows.Forms.TextBox();
            this.lblCMND = new System.Windows.Forms.Label();
            this.lblMaKhachHang = new System.Windows.Forms.Label();
            this.gbThongTinKhachHang = new System.Windows.Forms.GroupBox();
            this.lblTenKhachHang = new System.Windows.Forms.Label();
            this.btnTK = new DevComponents.DotNetBar.ButtonX();
            this.btnLuu = new DevComponents.DotNetBar.ButtonX();
            this.btnSua = new DevComponents.DotNetBar.ButtonX();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.tbxTimKiemKhachHang = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dPTNgaySinh = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).BeginInit();
            this.gbDanhSachNhanVien.SuspendLayout();
            this.gbThongTinKhachHang.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dPTNgaySinh)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(1253, 44);
            this.lblNgaySinh.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(82, 20);
            this.lblNgaySinh.TabIndex = 8;
            this.lblNgaySinh.Text = "Ngày sinh:";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Enabled = false;
            this.tbxEmail.Location = new System.Drawing.Point(754, 83);
            this.tbxEmail.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(325, 26);
            this.tbxEmail.TabIndex = 7;
            // 
            // tbxSoDienThoai
            // 
            this.tbxSoDienThoai.Enabled = false;
            this.tbxSoDienThoai.Location = new System.Drawing.Point(754, 33);
            this.tbxSoDienThoai.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbxSoDienThoai.Name = "tbxSoDienThoai";
            this.tbxSoDienThoai.Size = new System.Drawing.Size(325, 26);
            this.tbxSoDienThoai.TabIndex = 7;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(630, 91);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 20);
            this.lblEmail.TabIndex = 5;
            this.lblEmail.Text = "Email:";
            // 
            // lblSoDienThoai
            // 
            this.lblSoDienThoai.AutoSize = true;
            this.lblSoDienThoai.Location = new System.Drawing.Point(630, 44);
            this.lblSoDienThoai.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblSoDienThoai.Name = "lblSoDienThoai";
            this.lblSoDienThoai.Size = new System.Drawing.Size(106, 20);
            this.lblSoDienThoai.TabIndex = 4;
            this.lblSoDienThoai.Text = "Số điện thoại:";
            // 
            // tbxCMND
            // 
            this.tbxCMND.Enabled = false;
            this.tbxCMND.Location = new System.Drawing.Point(1351, 91);
            this.tbxCMND.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbxCMND.Name = "tbxCMND";
            this.tbxCMND.Size = new System.Drawing.Size(287, 26);
            this.tbxCMND.TabIndex = 3;
            // 
            // dgvKH
            // 
            this.dgvKH.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKH.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvKH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvKH.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvKH.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvKH.EnableHeadersVisualStyles = false;
            this.dgvKH.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.dgvKH.Location = new System.Drawing.Point(5, 23);
            this.dgvKH.Name = "dgvKH";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvKH.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvKH.RowHeadersWidth = 51;
            this.dgvKH.RowTemplate.Height = 24;
            this.dgvKH.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKH.Size = new System.Drawing.Size(1890, 745);
            this.dgvKH.TabIndex = 0;
            // 
            // gbDanhSachNhanVien
            // 
            this.gbDanhSachNhanVien.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbDanhSachNhanVien.Controls.Add(this.dgvKH);
            this.gbDanhSachNhanVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbDanhSachNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbDanhSachNhanVien.Location = new System.Drawing.Point(0, 228);
            this.gbDanhSachNhanVien.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbDanhSachNhanVien.Name = "gbDanhSachNhanVien";
            this.gbDanhSachNhanVien.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbDanhSachNhanVien.Size = new System.Drawing.Size(1900, 772);
            this.gbDanhSachNhanVien.TabIndex = 35;
            this.gbDanhSachNhanVien.TabStop = false;
            this.gbDanhSachNhanVien.Text = "Danh sách khách hàng";
            // 
            // tbxTenKhachHang
            // 
            this.tbxTenKhachHang.Enabled = false;
            this.tbxTenKhachHang.Location = new System.Drawing.Point(247, 83);
            this.tbxTenKhachHang.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbxTenKhachHang.Name = "tbxTenKhachHang";
            this.tbxTenKhachHang.Size = new System.Drawing.Size(234, 26);
            this.tbxTenKhachHang.TabIndex = 3;
            // 
            // tbxMaKhachHang
            // 
            this.tbxMaKhachHang.Location = new System.Drawing.Point(247, 36);
            this.tbxMaKhachHang.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbxMaKhachHang.Name = "tbxMaKhachHang";
            this.tbxMaKhachHang.Size = new System.Drawing.Size(234, 26);
            this.tbxMaKhachHang.TabIndex = 3;
            // 
            // lblCMND
            // 
            this.lblCMND.AutoSize = true;
            this.lblCMND.Location = new System.Drawing.Point(1253, 94);
            this.lblCMND.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCMND.Name = "lblCMND";
            this.lblCMND.Size = new System.Drawing.Size(60, 20);
            this.lblCMND.TabIndex = 2;
            this.lblCMND.Text = "CMND:";
            // 
            // lblMaKhachHang
            // 
            this.lblMaKhachHang.AutoSize = true;
            this.lblMaKhachHang.Location = new System.Drawing.Point(108, 44);
            this.lblMaKhachHang.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblMaKhachHang.Name = "lblMaKhachHang";
            this.lblMaKhachHang.Size = new System.Drawing.Size(122, 20);
            this.lblMaKhachHang.TabIndex = 0;
            this.lblMaKhachHang.Text = "Mã khách hàng:";
            // 
            // gbThongTinKhachHang
            // 
            this.gbThongTinKhachHang.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbThongTinKhachHang.Controls.Add(this.dPTNgaySinh);
            this.gbThongTinKhachHang.Controls.Add(this.btnTK);
            this.gbThongTinKhachHang.Controls.Add(this.btnLuu);
            this.gbThongTinKhachHang.Controls.Add(this.btnSua);
            this.gbThongTinKhachHang.Controls.Add(this.btnThem);
            this.gbThongTinKhachHang.Controls.Add(this.btnHuy);
            this.gbThongTinKhachHang.Controls.Add(this.tbxTimKiemKhachHang);
            this.gbThongTinKhachHang.Controls.Add(this.label1);
            this.gbThongTinKhachHang.Controls.Add(this.lblNgaySinh);
            this.gbThongTinKhachHang.Controls.Add(this.tbxEmail);
            this.gbThongTinKhachHang.Controls.Add(this.tbxSoDienThoai);
            this.gbThongTinKhachHang.Controls.Add(this.lblEmail);
            this.gbThongTinKhachHang.Controls.Add(this.lblSoDienThoai);
            this.gbThongTinKhachHang.Controls.Add(this.tbxCMND);
            this.gbThongTinKhachHang.Controls.Add(this.tbxTenKhachHang);
            this.gbThongTinKhachHang.Controls.Add(this.tbxMaKhachHang);
            this.gbThongTinKhachHang.Controls.Add(this.lblCMND);
            this.gbThongTinKhachHang.Controls.Add(this.lblTenKhachHang);
            this.gbThongTinKhachHang.Controls.Add(this.lblMaKhachHang);
            this.gbThongTinKhachHang.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbThongTinKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbThongTinKhachHang.Location = new System.Drawing.Point(0, 0);
            this.gbThongTinKhachHang.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbThongTinKhachHang.Name = "gbThongTinKhachHang";
            this.gbThongTinKhachHang.Padding = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.gbThongTinKhachHang.Size = new System.Drawing.Size(1900, 228);
            this.gbThongTinKhachHang.TabIndex = 34;
            this.gbThongTinKhachHang.TabStop = false;
            this.gbThongTinKhachHang.Text = "Thông tin khách hàng";
            // 
            // lblTenKhachHang
            // 
            this.lblTenKhachHang.AutoSize = true;
            this.lblTenKhachHang.Location = new System.Drawing.Point(108, 91);
            this.lblTenKhachHang.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTenKhachHang.Name = "lblTenKhachHang";
            this.lblTenKhachHang.Size = new System.Drawing.Size(127, 20);
            this.lblTenKhachHang.TabIndex = 1;
            this.lblTenKhachHang.Text = "Tên khách hàng:";
            // 
            // btnTK
            // 
            this.btnTK.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTK.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTK.Location = new System.Drawing.Point(684, 177);
            this.btnTK.Name = "btnTK";
            this.btnTK.Size = new System.Drawing.Size(102, 30);
            this.btnTK.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTK.TabIndex = 49;
            this.btnTK.Text = "Tìm kiếm";
            this.btnTK.Click += new System.EventHandler(this.btnTK_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuu.Location = new System.Drawing.Point(1146, 145);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(104, 62);
            this.btnLuu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuu.TabIndex = 45;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSua.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSua.Location = new System.Drawing.Point(1025, 145);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(104, 62);
            this.btnSua.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSua.TabIndex = 46;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Location = new System.Drawing.Point(905, 145);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(104, 62);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.TabIndex = 47;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Location = new System.Drawing.Point(1267, 145);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(104, 62);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 48;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // tbxTimKiemKhachHang
            // 
            this.tbxTimKiemKhachHang.Location = new System.Drawing.Point(401, 181);
            this.tbxTimKiemKhachHang.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.tbxTimKiemKhachHang.Name = "tbxTimKiemKhachHang";
            this.tbxTimKiemKhachHang.Size = new System.Drawing.Size(274, 26);
            this.tbxTimKiemKhachHang.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(260, 187);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 44;
            this.label1.Text = "Tên khách hàng";
            // 
            // dPTNgaySinh
            // 
            // 
            // 
            // 
            this.dPTNgaySinh.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dPTNgaySinh.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dPTNgaySinh.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dPTNgaySinh.ButtonDropDown.Visible = true;
            this.dPTNgaySinh.IsPopupCalendarOpen = false;
            this.dPTNgaySinh.Location = new System.Drawing.Point(1351, 43);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dPTNgaySinh.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dPTNgaySinh.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dPTNgaySinh.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dPTNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dPTNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dPTNgaySinh.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dPTNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dPTNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dPTNgaySinh.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dPTNgaySinh.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dPTNgaySinh.MonthCalendar.DisplayMonth = new System.DateTime(2020, 7, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dPTNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dPTNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dPTNgaySinh.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dPTNgaySinh.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dPTNgaySinh.MonthCalendar.TodayButtonVisible = true;
            this.dPTNgaySinh.Name = "dPTNgaySinh";
            this.dPTNgaySinh.Size = new System.Drawing.Size(287, 26);
            this.dPTNgaySinh.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dPTNgaySinh.TabIndex = 50;
            // 
            // frmQuanLyKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1900, 1000);
            this.Controls.Add(this.gbDanhSachNhanVien);
            this.Controls.Add(this.gbThongTinKhachHang);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmQuanLyKhachHang";
            this.Text = "frmQuanLyKhachHang";
            this.Load += new System.EventHandler(this.frmQuanLyKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKH)).EndInit();
            this.gbDanhSachNhanVien.ResumeLayout(false);
            this.gbThongTinKhachHang.ResumeLayout(false);
            this.gbThongTinKhachHang.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dPTNgaySinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxSoDienThoai;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblSoDienThoai;
        private System.Windows.Forms.TextBox tbxCMND;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvKH;
        private System.Windows.Forms.GroupBox gbDanhSachNhanVien;
        private System.Windows.Forms.TextBox tbxTenKhachHang;
        private System.Windows.Forms.TextBox tbxMaKhachHang;
        private System.Windows.Forms.Label lblCMND;
        private System.Windows.Forms.Label lblMaKhachHang;
        private System.Windows.Forms.GroupBox gbThongTinKhachHang;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dPTNgaySinh;
        private DevComponents.DotNetBar.ButtonX btnTK;
        private DevComponents.DotNetBar.ButtonX btnLuu;
        private DevComponents.DotNetBar.ButtonX btnSua;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.DotNetBar.ButtonX btnHuy;
        private System.Windows.Forms.TextBox tbxTimKiemKhachHang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTenKhachHang;
    }
}