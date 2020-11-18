namespace DHKTPM13A_TDNguyen_PDLoi_PTBinh_GUI
{
    partial class frmVe
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
            this.pnlBuoc = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlBuoc
            // 
            this.pnlBuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBuoc.Location = new System.Drawing.Point(0, 0);
            this.pnlBuoc.Name = "pnlBuoc";
            this.pnlBuoc.Size = new System.Drawing.Size(1900, 966);
            this.pnlBuoc.TabIndex = 0;
            // 
            // frmVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1900, 966);
            this.Controls.Add(this.pnlBuoc);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmVe";
            this.Text = "frmVe";
            this.Load += new System.EventHandler(this.frmVe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBuoc;
    }
}