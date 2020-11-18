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
    public partial class frmManHinhChinhBanDoAn : Form
    {
        eNhanVien nv;
        frmDangNhap main;
        int flag = 1;
        public frmManHinhChinhBanDoAn()
        {
            InitializeComponent();
        }
        public frmManHinhChinhBanDoAn(eNhanVien nhanVien, frmDangNhap frm)
        {
            InitializeComponent();
            nv = nhanVien;
            main = frm;
        }

        private void quảnLýHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDichVu frm = new frmDichVu(nv);
            hienForm(frm);
        }

        #region
        /// <summary>
        /// Hiển thị form
        /// </summary>
        void hienForm(Form frm)
        {
            this.pnlChucNang.Controls.Clear();
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.ShowInTaskbar = false;
            frm.Show();
            frm.Dock = DockStyle.Fill;
            this.pnlChucNang.Controls.Add(frm);
        }
        #endregion

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flag = 0;
            DialogResult rs = MessageBox.Show("Bạn có chắc muốn đăng xuất khỏi hệ thống?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            if (rs == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                flag = 1;
            }
        }

        private void frmManHinhChinhBanDoAn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (flag == 0)
                return;
            else
            {
                DialogResult rs = MessageBox.Show("Bạn có chắc muốn thoát khỏi hệ thống?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (rs == DialogResult.OK)
                {
                    main.Close();
                }
                else
                {
                    e.Cancel = true;
                }
            }
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongTinNhanVien frm = new frmThongTinNhanVien(nv);
            hienForm(frm);
        }

        private void frmManHinhChinhBanDoAn_Load(object sender, EventArgs e)
        {
            frmThongTinNhanVien frm = new frmThongTinNhanVien(nv);
            hienForm(frm);
        }
    }
}
