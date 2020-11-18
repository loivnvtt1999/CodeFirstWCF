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
    public partial class frmManHinhChinhQuanLy : Form
    {
        eNhanVien nv;
        frmDangNhap main;
        int flag = 1;
        public frmManHinhChinhQuanLy()
        {
            InitializeComponent();
        }

        public frmManHinhChinhQuanLy(eNhanVien nhanVien, frmDangNhap frm)
        {
            InitializeComponent();
            nv = nhanVien;
            main = frm;
        }

        private void frmManHinhChinhQuanLy_Load(object sender, EventArgs e)
        {
            frmThongTinNhanVien frm = new frmThongTinNhanVien(nv);
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

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyNhanVien frm = new frmQuanLyNhanVien();
            hienForm(frm);
        }

        private void quảnLýXeMáyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyPhim frm = new frmQuanLyPhim();
            hienForm(frm);
        }

        private void quảnLýKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyKhachHang frm = new frmQuanLyKhachHang();
            hienForm(frm);
        }

        private void quảnLýSuấtChiếuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTaoSuatChieu frm = new frmTaoSuatChieu();
            hienForm(frm);
        }

        private void quảnLýGhếNgồiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyPhongChieu_Ghe frm = new frmQuanLyPhongChieu_Ghe();
            hienForm(frm);
        }

        private void quảnLýNhàSảnXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyNhaSanXuat frm = new frmQuanLyNhaSanXuat();
            hienForm(frm);
        }

        private void thốngKêDoanhThuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongKe frm = new frmThongKe();
            hienForm(frm);
        }

        private void BanVeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVe frm = new frmVe(nv);
            hienForm(frm);
        }

        private void DichVuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDichVu frm = new frmDichVu(nv);
            hienForm(frm);
        }

        private void quảnLýDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmQuanLyDichVu frm = new frmQuanLyDichVu();
            hienForm(frm);
        }

        private void frmManHinhChinhQuanLy_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
