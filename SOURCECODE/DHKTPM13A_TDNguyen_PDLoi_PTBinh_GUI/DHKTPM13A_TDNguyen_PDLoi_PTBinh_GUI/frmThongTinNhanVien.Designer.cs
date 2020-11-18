namespace DHKTPM13A_TDNguyen_PDLoi_PTBinh_GUI
{
    partial class frmThongTinNhanVien
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.tbxTen = new DevComponents.DotNetBar.LabelX();
            this.tbxma = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbxCV = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(575, 366);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(109, 36);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "Mã nhân viên:";
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.labelX2.Location = new System.Drawing.Point(885, 252);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(163, 36);
            this.labelX2.TabIndex = 0;
            this.labelX2.Text = "Xin Chào:";
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(575, 455);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(109, 36);
            this.labelX3.TabIndex = 0;
            this.labelX3.Text = "Chức vụ";
            // 
            // tbxTen
            // 
            // 
            // 
            // 
            this.tbxTen.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbxTen.Location = new System.Drawing.Point(1054, 252);
            this.tbxTen.Name = "tbxTen";
            this.tbxTen.Size = new System.Drawing.Size(163, 36);
            this.tbxTen.TabIndex = 0;
            this.tbxTen.Text = "ten";
            // 
            // tbxma
            // 
            // 
            // 
            // 
            this.tbxma.Border.Class = "TextBoxBorder";
            this.tbxma.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxma.Location = new System.Drawing.Point(793, 366);
            this.tbxma.Name = "tbxma";
            this.tbxma.PreventEnterBeep = true;
            this.tbxma.ReadOnly = true;
            this.tbxma.Size = new System.Drawing.Size(347, 26);
            this.tbxma.TabIndex = 1;
            // 
            // tbxCV
            // 
            // 
            // 
            // 
            this.tbxCV.Border.Class = "TextBoxBorder";
            this.tbxCV.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxCV.Location = new System.Drawing.Point(793, 465);
            this.tbxCV.Name = "tbxCV";
            this.tbxCV.PreventEnterBeep = true;
            this.tbxCV.ReadOnly = true;
            this.tbxCV.Size = new System.Drawing.Size(347, 26);
            this.tbxCV.TabIndex = 1;
            // 
            // frmThongTinNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1900, 1000);
            this.Controls.Add(this.tbxCV);
            this.Controls.Add(this.tbxma);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.tbxTen);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmThongTinNhanVien";
            this.Text = "frmThongTinNhanVien";
            this.Load += new System.EventHandler(this.frmThongTinNhanVien_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX tbxTen;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxma;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxCV;
    }
}