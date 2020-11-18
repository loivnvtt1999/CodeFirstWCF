namespace DHKTPM13A_TDNguyen_PDLoi_PTBinh_GUI
{
    partial class frmBanVe
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
            this.groupPhim = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dtpNgayChieu = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cboDSPhim = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupDSSuatChieu = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnTiepTheo = new DevComponents.DotNetBar.ButtonX();
            this.lvwSuatChieu = new System.Windows.Forms.ListView();
            this.imgListAnhPhim = new System.Windows.Forms.ImageList(this.components);
            this.groupPhim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayChieu)).BeginInit();
            this.groupDSSuatChieu.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPhim
            // 
            this.groupPhim.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPhim.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPhim.Controls.Add(this.dtpNgayChieu);
            this.groupPhim.Controls.Add(this.labelX2);
            this.groupPhim.Controls.Add(this.cboDSPhim);
            this.groupPhim.Controls.Add(this.labelX1);
            this.groupPhim.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPhim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupPhim.Location = new System.Drawing.Point(0, 0);
            this.groupPhim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupPhim.Name = "groupPhim";
            this.groupPhim.Size = new System.Drawing.Size(1875, 112);
            // 
            // 
            // 
            this.groupPhim.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPhim.Style.BackColorGradientAngle = 90;
            this.groupPhim.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPhim.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPhim.Style.BorderBottomWidth = 1;
            this.groupPhim.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPhim.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPhim.Style.BorderLeftWidth = 1;
            this.groupPhim.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPhim.Style.BorderRightWidth = 1;
            this.groupPhim.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPhim.Style.BorderTopWidth = 1;
            this.groupPhim.Style.CornerDiameter = 4;
            this.groupPhim.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPhim.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPhim.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPhim.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPhim.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPhim.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPhim.TabIndex = 4;
            this.groupPhim.Text = "Danh sách phim chiếu";
            // 
            // dtpNgayChieu
            // 
            // 
            // 
            // 
            this.dtpNgayChieu.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtpNgayChieu.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgayChieu.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtpNgayChieu.ButtonDropDown.Visible = true;
            this.dtpNgayChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.dtpNgayChieu.IsPopupCalendarOpen = false;
            this.dtpNgayChieu.Location = new System.Drawing.Point(1334, 26);
            this.dtpNgayChieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtpNgayChieu.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgayChieu.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtpNgayChieu.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtpNgayChieu.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtpNgayChieu.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpNgayChieu.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtpNgayChieu.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtpNgayChieu.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtpNgayChieu.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtpNgayChieu.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgayChieu.MonthCalendar.DisplayMonth = new System.DateTime(2020, 7, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtpNgayChieu.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtpNgayChieu.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtpNgayChieu.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtpNgayChieu.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtpNgayChieu.MonthCalendar.TodayButtonVisible = true;
            this.dtpNgayChieu.Name = "dtpNgayChieu";
            this.dtpNgayChieu.Size = new System.Drawing.Size(399, 26);
            this.dtpNgayChieu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtpNgayChieu.TabIndex = 4;
            this.dtpNgayChieu.ValueChanged += new System.EventHandler(this.dtpNgayChieu_ValueChanged);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX2.Location = new System.Drawing.Point(1122, 9);
            this.labelX2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(147, 71);
            this.labelX2.TabIndex = 2;
            this.labelX2.Text = "Ngày chiếu:";
            // 
            // cboDSPhim
            // 
            this.cboDSPhim.DisplayMember = "Text";
            this.cboDSPhim.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboDSPhim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.cboDSPhim.FormattingEnabled = true;
            this.cboDSPhim.ItemHeight = 21;
            this.cboDSPhim.Location = new System.Drawing.Point(420, 25);
            this.cboDSPhim.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboDSPhim.Name = "cboDSPhim";
            this.cboDSPhim.Size = new System.Drawing.Size(416, 27);
            this.cboDSPhim.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboDSPhim.TabIndex = 1;
            this.cboDSPhim.SelectedIndexChanged += new System.EventHandler(this.cboDSPhim_SelectedIndexChanged);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX1.Location = new System.Drawing.Point(135, 8);
            this.labelX1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(208, 72);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Phim đang chiếu:";
            // 
            // groupDSSuatChieu
            // 
            this.groupDSSuatChieu.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupDSSuatChieu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupDSSuatChieu.Controls.Add(this.btnTiepTheo);
            this.groupDSSuatChieu.Controls.Add(this.lvwSuatChieu);
            this.groupDSSuatChieu.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupDSSuatChieu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupDSSuatChieu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupDSSuatChieu.Location = new System.Drawing.Point(0, 112);
            this.groupDSSuatChieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupDSSuatChieu.Name = "groupDSSuatChieu";
            this.groupDSSuatChieu.Size = new System.Drawing.Size(1875, 805);
            // 
            // 
            // 
            this.groupDSSuatChieu.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupDSSuatChieu.Style.BackColorGradientAngle = 90;
            this.groupDSSuatChieu.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupDSSuatChieu.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupDSSuatChieu.Style.BorderBottomWidth = 1;
            this.groupDSSuatChieu.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupDSSuatChieu.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupDSSuatChieu.Style.BorderLeftWidth = 1;
            this.groupDSSuatChieu.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupDSSuatChieu.Style.BorderRightWidth = 1;
            this.groupDSSuatChieu.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupDSSuatChieu.Style.BorderTopWidth = 1;
            this.groupDSSuatChieu.Style.CornerDiameter = 4;
            this.groupDSSuatChieu.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupDSSuatChieu.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupDSSuatChieu.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupDSSuatChieu.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupDSSuatChieu.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupDSSuatChieu.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupDSSuatChieu.TabIndex = 3;
            this.groupDSSuatChieu.Text = "Danh sách các suất chiếu";
            // 
            // btnTiepTheo
            // 
            this.btnTiepTheo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnTiepTheo.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnTiepTheo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnTiepTheo.ImageFixedSize = new System.Drawing.Size(80, 60);
            this.btnTiepTheo.Location = new System.Drawing.Point(1563, 658);
            this.btnTiepTheo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTiepTheo.Name = "btnTiepTheo";
            this.btnTiepTheo.Size = new System.Drawing.Size(262, 100);
            this.btnTiepTheo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnTiepTheo.TabIndex = 1;
            this.btnTiepTheo.Text = "Tiếp theo";
            this.btnTiepTheo.Click += new System.EventHandler(this.btnTiepTheo_Click);
            // 
            // lvwSuatChieu
            // 
            this.lvwSuatChieu.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvwSuatChieu.HideSelection = false;
            this.lvwSuatChieu.Location = new System.Drawing.Point(0, 0);
            this.lvwSuatChieu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.lvwSuatChieu.Name = "lvwSuatChieu";
            this.lvwSuatChieu.Size = new System.Drawing.Size(1864, 647);
            this.lvwSuatChieu.TabIndex = 0;
            this.lvwSuatChieu.UseCompatibleStateImageBehavior = false;
            this.lvwSuatChieu.SelectedIndexChanged += new System.EventHandler(this.lvwSuatChieu_SelectedIndexChanged);
            // 
            // imgListAnhPhim
            // 
            this.imgListAnhPhim.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imgListAnhPhim.ImageSize = new System.Drawing.Size(150, 150);
            this.imgListAnhPhim.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // frmBanVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1875, 917);
            this.Controls.Add(this.groupPhim);
            this.Controls.Add(this.groupDSSuatChieu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmBanVe";
            this.Text = "frmBanVe";
            this.Load += new System.EventHandler(this.frmBanVe_Load);
            this.groupPhim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtpNgayChieu)).EndInit();
            this.groupDSSuatChieu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPhim;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboDSPhim;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupDSSuatChieu;
        private DevComponents.DotNetBar.ButtonX btnTiepTheo;
        private System.Windows.Forms.ListView lvwSuatChieu;
        private System.Windows.Forms.ImageList imgListAnhPhim;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtpNgayChieu;
    }
}