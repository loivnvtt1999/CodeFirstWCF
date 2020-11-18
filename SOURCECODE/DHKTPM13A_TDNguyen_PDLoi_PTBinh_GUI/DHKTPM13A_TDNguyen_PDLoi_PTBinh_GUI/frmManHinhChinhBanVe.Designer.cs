namespace DHKTPM13A_TDNguyen_PDLoi_PTBinh_GUI
{
    partial class frmManHinhChinhBanVe
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
            this.styleManager1 = new DevComponents.DotNetBar.StyleManager(this.components);
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.muaBánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lậpHóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlChucNang = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // styleManager1
            // 
            this.styleManager1.ManagerStyle = DevComponents.DotNetBar.eStyle.Office2010Blue;
            this.styleManager1.MetroColorParameters = new DevComponents.DotNetBar.Metro.ColorTables.MetroColorGeneratorParameters(System.Drawing.Color.White, System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(87)))), ((int)(((byte)(154))))));
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem});
            this.thôngTinToolStripMenuItem.Image = global::DHKTPM13A_TDNguyen_PDLoi_PTBinh_GUI.Properties.Resources.information;
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(91, 24);
            this.thôngTinToolStripMenuItem.Text = "Thông tin";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.Image = global::DHKTPM13A_TDNguyen_PDLoi_PTBinh_GUI.Properties.Resources.taiKhoan;
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            this.tàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Image = global::DHKTPM13A_TDNguyen_PDLoi_PTBinh_GUI.Properties.Resources.log_out;
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // muaBánToolStripMenuItem
            // 
            this.muaBánToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lậpHóaĐơnToolStripMenuItem});
            this.muaBánToolStripMenuItem.Image = global::DHKTPM13A_TDNguyen_PDLoi_PTBinh_GUI.Properties.Resources.mua_ban;
            this.muaBánToolStripMenuItem.Name = "muaBánToolStripMenuItem";
            this.muaBánToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.muaBánToolStripMenuItem.Text = "Mua bán";
            // 
            // lậpHóaĐơnToolStripMenuItem
            // 
            this.lậpHóaĐơnToolStripMenuItem.Image = global::DHKTPM13A_TDNguyen_PDLoi_PTBinh_GUI.Properties.Resources.hoa_don;
            this.lậpHóaĐơnToolStripMenuItem.Name = "lậpHóaĐơnToolStripMenuItem";
            this.lậpHóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(113, 26);
            this.lậpHóaĐơnToolStripMenuItem.Text = "Bán vé";
            this.lậpHóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.lậpHóaĐơnToolStripMenuItem_Click);
            // 
            // pnlChucNang
            // 
            this.pnlChucNang.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChucNang.Location = new System.Drawing.Point(0, 34);
            this.pnlChucNang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlChucNang.Name = "pnlChucNang";
            this.pnlChucNang.Size = new System.Drawing.Size(1900, 966);
            this.pnlChucNang.TabIndex = 7;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinToolStripMenuItem,
            this.muaBánToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(15, 5, 0, 5);
            this.menuStrip1.Size = new System.Drawing.Size(1900, 34);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // frmManHinhChinhBanVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1900, 1000);
            this.Controls.Add(this.pnlChucNang);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmManHinhChinhBanVe";
            this.Text = "Chương trình quản lý rạp chiếu phim";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmManHinhChinhBanVe_FormClosing);
            this.Load += new System.EventHandler(this.frmManHinhChinhBanVe_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.StyleManager styleManager1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem muaBánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lậpHóaĐơnToolStripMenuItem;
        private System.Windows.Forms.Panel pnlChucNang;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}