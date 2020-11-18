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
    public partial class frmThemNhaSanXuat : Form
    {
        PhongChieuClient cli;
        public eNhaSanXuat ensx;
        public frmThemNhaSanXuat()
        {
            InitializeComponent();
            cli = new PhongChieuClient();
            ensx = new eNhaSanXuat();
        }

        private void frmThemNhaSanXuat_Load(object sender, EventArgs e)
        {
            tbxMaNSX.ReadOnly = true;
            tbxMaNSX.Text = cli.PhatSinhMaNSX();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbxTenNSX.Text) || string.IsNullOrEmpty(tbxQuocGia.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ensx.MaNSX = tbxMaNSX.Text;
                ensx.TenNSX = tbxTenNSX.Text;
                ensx.QuocGia = tbxQuocGia.Text;
                cli.ThemNhaSanXuat(ensx);
                MessageBox.Show("Thêm thành công");
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
