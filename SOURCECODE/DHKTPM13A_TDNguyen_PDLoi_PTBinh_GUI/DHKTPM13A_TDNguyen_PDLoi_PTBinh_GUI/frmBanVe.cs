using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DHKTPM13A_TDNguyen_PDLoi_PTBinh_GUI.ServiceRapChieuPhim;

namespace DHKTPM13A_TDNguyen_PDLoi_PTBinh_GUI
{
    public partial class frmBanVe : Form
    {
        PhongChieuClient qlcp;
        List<ePhim> lstPhim;
        List<eXuatChieu> lstXuatChieu;
        frmVe main;
        public eXuatChieu Suat;

        public frmBanVe()
        {
            InitializeComponent();
        }

        public frmBanVe(frmVe frmVe)
        {
            InitializeComponent();
            qlcp = new PhongChieuClient();
            lstPhim = new List<ePhim>();
            lstXuatChieu = new List<eXuatChieu>();
            main = frmVe;
        }

        private void frmBanVe_Load(object sender, EventArgs e)
        {
            lstPhim = qlcp.LayDanhSachPhim().ToList();
            cboDSPhim.DataSource = lstPhim;
            cboDSPhim.DisplayMember = "TenPhim";
            cboDSPhim.ValueMember = "MaPhim";
            dtpNgayChieu.Value = DateTime.Today;
            lstXuatChieu = qlcp.LayDanhSachXuatChieuCuaPhimTheoNgay(cboDSPhim.SelectedValue.ToString(), dtpNgayChieu.Value.Day, dtpNgayChieu.Value.Month, dtpNgayChieu.Value.Year).ToList();
            LoadDataToListView(lstXuatChieu);
            btnTiepTheo.Enabled = false;
        }

        Image resizeImage(Image img, int width, int height)
        {
            Bitmap b = new Bitmap(width, height);
            Graphics g = Graphics.FromImage((Image)b);

            g.DrawImage(img, 0, 0, width, height);
            g.Dispose();

            return (Image)b;
        }

        public void LoadDataToListView(List<eXuatChieu> l)
        {
            lvwSuatChieu.View = View.LargeIcon;
            lvwSuatChieu.Items.Clear();
            imgListAnhPhim.Images.Clear();
            for (int i = 0; i < l.Count; i++)
            {
                Image img1;
                if (qlcp.TimPhimTheoMa(l[i].MaPhim).Poster != null)
                {
                    img1 = Image.FromStream(new MemoryStream(qlcp.TimPhimTheoMa(l[i].MaPhim).Poster));
                }
                else
                    img1 = global::DHKTPM13A_TDNguyen_PDLoi_PTBinh_GUI.Properties.Resources.cinema;
                resizeImage(img1, 300, 300);
                imgListAnhPhim.Images.Add(img1);
            }
            lvwSuatChieu.LargeImageList = imgListAnhPhim;
            for (int i = 0; i < l.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.ImageIndex = i;
                lvi.Text = qlcp.TimPhimTheoMa(l[i].MaPhim).TenPhim + "\n" +
                    l[i].ThoiDiem.Value.Hour + ":" + l[i].ThoiDiem.Value.Minute;
                lvi.Tag = l[i].MaXuat;
                lvwSuatChieu.Items.Add(lvi);
            }
        }

        private void cboDSPhim_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstXuatChieu = qlcp.LayDanhSachXuatChieuCuaPhimTheoNgay(cboDSPhim.SelectedValue.ToString(), dtpNgayChieu.Value.Day, dtpNgayChieu.Value.Month, dtpNgayChieu.Value.Year).ToList();
            LoadDataToListView(lstXuatChieu);
        }

        private void btnTiepTheo_Click(object sender, EventArgs e)
        {
            if (lvwSuatChieu.SelectedItems.Count == 1)
            {
                Suat = qlcp.LayXuatChieuTheoMa(lvwSuatChieu.SelectedItems[0].Tag.ToString());
                main.GoNext();
            }
        }

        private void lvwSuatChieu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwSuatChieu.SelectedItems.Count == 1)
            {
                btnTiepTheo.Enabled = true;
            }
            else
            {
                btnTiepTheo.Enabled = false;
            }
        }

        private void dtpNgayChieu_ValueChanged(object sender, EventArgs e)
        {
            lstXuatChieu = qlcp.LayDanhSachXuatChieuCuaPhimTheoNgay(cboDSPhim.SelectedValue.ToString(), dtpNgayChieu.Value.Day, dtpNgayChieu.Value.Month, dtpNgayChieu.Value.Year).ToList();
            LoadDataToListView(lstXuatChieu);
        }
    }
}
