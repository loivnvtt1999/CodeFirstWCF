using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DHKTPM13A_TDNguyen_PDLoi_PTBinh_GUI.ServiceRapChieuPhim;

namespace DHKTPM13A_TDNguyen_PDLoi_PTBinh_GUI
{
    public partial class frmDangNhap : Form
    {
        PhongChieuClient cli;
        eNhanVien env;
        public frmDangNhap()
        {
            InitializeComponent();
            this.SuspendLayout();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDangNhap";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmDangNhap_Load);
            this.Text = "Test Splash Screen";
            this.ResumeLayout(false);
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!cli.KiemTraNhanVien(tbxTenDN.Text))
            {
                MessageBox.Show("Không tìm thấy tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (string.IsNullOrEmpty(tbxMK.Text))
                {
                    MessageBox.Show("Vui lòng nhập mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    env = cli.KiemTraDangNhap(tbxTenDN.Text, tbxMK.Text);
                    if (env == null)
                    {
                        MessageBox.Show("Sai mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {

                        this.Hide();
                        if (env.ChucVu.Equals("Quản Lý"))
                        {
                            frmManHinhChinhQuanLy frmMHC = new frmManHinhChinhQuanLy(env, this);
                            frmMHC.ShowDialog();
                            if (frmMHC.DialogResult == DialogResult.OK)
                                this.Show();
                        }
                        else if (env.ChucVu.Equals("Bán vé"))
                        {
                            frmManHinhChinhBanVe frmMHC = new frmManHinhChinhBanVe(env, this);
                            frmMHC.ShowDialog();
                            if (frmMHC.DialogResult == DialogResult.OK)
                                this.Show();
                        }
                        else
                        {
                            frmManHinhChinhBanDoAn frmMHC = new frmManHinhChinhBanDoAn(env, this);
                            frmMHC.ShowDialog();
                            if (frmMHC.DialogResult == DialogResult.OK)
                                this.Show();
                        }
                    }
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn thoát khỏi hệ thống?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (rs == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            cli = new PhongChieuClient();
            env = new eNhanVien();
            this.ActiveControl = tbxTenDN;
            tbxMK.PasswordChar = '*';
        }
    }
}
