﻿using System;
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
    public partial class frmBanDichVu : Form
    {
        eHoaDon hd;
        frmDichVu main;
        PhongChieuClient qlpc;
        List<eDichVu> lstDichVu;
        public List<eCT_HoaDon_DichVu> lstGioHang;
        DataTable dts;
        public frmBanDichVu()
        {
            InitializeComponent();
        }
        public frmBanDichVu(frmDichVu frm, eHoaDon hoaDon)
        {
            InitializeComponent();
            dts = new DataTable();
            qlpc = new PhongChieuClient();
            lstGioHang = new List<eCT_HoaDon_DichVu>();
            main = frm;
            hd = hoaDon;
        }

        private void frmBanDichVu_Load(object sender, EventArgs e)
        {
            lstDichVu = qlpc.LayDanhSachDichVu().ToList();
            LoadDataToListView(lstDichVu);
        }

        Image resizeImage(Image img, int width, int height)
        {
            Bitmap b = new Bitmap(width, height);
            Graphics g = Graphics.FromImage((Image)b);

            g.DrawImage(img, 0, 0, width, height);
            g.Dispose();

            return (Image)b;
        }
        public System.Data.DataTable CreatData()
        {
            System.Data.DataTable dt = new System.Data.DataTable();
            dt.Columns.Add("Mã hóa đơn");
            dt.Columns.Add("Mã dịch vụ");
            dt.Columns.Add("Tên dịch vụ");
            dt.Columns.Add("Đơn giá");
            dt.Columns.Add("Số lượng");
            return dt;
        }
        void LoadDataToDataGridView(DataGridView dgr, List<eCT_HoaDon_DichVu> l)
        {
            dts.Clear();
            dts = CreatData();
            foreach (eCT_HoaDon_DichVu ectdv in l)
            {
                dts.Rows.Add(ectdv.MaHoaDon, ectdv.MaDichVu, qlpc.LayDichVuTheoMa(ectdv.MaDichVu).TenDichVu, qlpc.LayDichVuTheoMa(ectdv.MaDichVu).DonGia, ectdv.SoLuong);
                dgvDVChon.DataSource = dts;

            }
            dgvDVChon.Refresh();
        }
        public void LoadDataToListView(List<eDichVu> l)
        {
            // Sua anh dich vu trong CSDL chua co anh
            lvwDV.View = View.LargeIcon;
            lvwDV.Items.Clear();
            for (int i = 0; i < l.Count; i++)
            {
                Image img1;
                img1 = global::DHKTPM13A_TDNguyen_PDLoi_PTBinh_GUI.Properties.Resources.dichvu;
                resizeImage(img1, 300, 300);
                imgListDichVu.Images.Add(img1);
            }
            lvwDV.LargeImageList = imgListDichVu;
            for (int i = 0; i < l.Count; i++)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.ImageIndex = i;
                lvi.Text = l[i].TenDichVu + "\n" + l[i].DonGia;
                lvi.Tag = l[i].MaDichVu;
                lvwDV.Items.Add(lvi);
            }
        }
        private double TinhTien(List<eCT_HoaDon_DichVu> l)
        {
            double thanhtien = 0;
            double dongia = 0;
            foreach (eCT_HoaDon_DichVu eCTDV in l)
            {
                dongia = qlpc.LayDichVuTheoMa(eCTDV.MaDichVu).DonGia;
                thanhtien += eCTDV.SoLuong * dongia;
            }
            return thanhtien;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            main.GoNext();
        }

        private void btnChonDV_Click(object sender, EventArgs e)
        {
            eDichVu dvduocchon = new eDichVu();
            eCT_HoaDon_DichVu chitietdichvu;
            chitietdichvu = new eCT_HoaDon_DichVu();
            if (lvwDV.SelectedItems.Count > 0)
            {
                dvduocchon = qlpc.LayDichVuTheoMa(lvwDV.SelectedItems[0].Tag.ToString());
                chitietdichvu.MaDichVu = dvduocchon.MaDichVu;
                chitietdichvu.MaHoaDon = hd.MaHoaDon;
                if (numericUpDown1.Value == 0)
                {
                    MessageBox.Show("Vui lòng chọn số lượng");
                    numericUpDown1.Focus();
                    return;
                }
                else
                    chitietdichvu.SoLuong = int.Parse(numericUpDown1.Value.ToString());
                foreach (eCT_HoaDon_DichVu ct in lstGioHang)
                {
                    if (ct.MaDichVu.Equals(chitietdichvu.MaDichVu))
                    {
                        ct.SoLuong += chitietdichvu.SoLuong;
                        LoadDataToDataGridView(dgvDVChon, lstGioHang);
                        numericUpDown1.Value = 0;
                        tbxDV.Text = TinhTien(lstGioHang).ToString();
                        return;
                    }
                }
                lstGioHang.Add(chitietdichvu);
                LoadDataToDataGridView(dgvDVChon, lstGioHang);
                numericUpDown1.Value = 0;
                tbxDV.Text = TinhTien(lstGioHang).ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dịch vụ");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDVChon.SelectedRows.Count > 0)
            {
                DialogResult dr = MessageBox.Show("Bạn có chắc hoàn dịch vụ không", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                if (dr == DialogResult.OK)
                {
                    foreach (eCT_HoaDon_DichVu ct in lstGioHang)
                    {
                        if (ct.MaDichVu.Equals(dgvDVChon.CurrentRow.Cells[1].Value.ToString()) && ct.SoLuong > 0)
                        {
                            ct.SoLuong -= 1;
                            tbxDV.Text = TinhTien(lstGioHang).ToString();
                            if (ct.SoLuong == 0)
                            {
                                lstGioHang.Remove(ct);
                                MessageBox.Show("Dịch vụ đã xóa");
                            }
                            LoadDataToDataGridView(dgvDVChon, lstGioHang);
                            break;
                        }
                    }
                }
            }
        }
    }
}
