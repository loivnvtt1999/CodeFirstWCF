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
    public partial class frmTaoSuatChieu : Form
    {
        PhongChieuClient cli;
        List<ePhim> listPhim;
        List<ePhongChieu> listPhong;
        List<eXuatChieu> listSuat;
        public frmTaoSuatChieu()
        {
            InitializeComponent();
        }

        private void frmTaoSuatChieu_Load(object sender, EventArgs e)
        {
            cli = new PhongChieuClient();
            tbxMaSuat.ReadOnly = true;
            KhoaText();
            dgvSuat.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            loaddatacboPhong();
            loaddatacboPhim();
            dtiNgay.Value = DateTime.Today;
            loaddatadgvSuat();
        }

        void loaddatadgvSuat()
        {
            if (cboPhong.SelectedIndex >= 0)
            {
                listSuat = cli.LayDanhSachXuatChieuTheoNgayTheoPhong(cboPhong.SelectedValue.ToString(), dtiNgay.Value).ToList();
                dgvSuat.DataSource = listSuat;
                if (listSuat.Count > 0)
                {
                    btnXoa.Enabled = true;
                }
                else
                {
                    btnXoa.Enabled = false;
                }
                dgvSuat.Columns["MaXuat"].HeaderText = "Mã suất";
                dgvSuat.Columns["MaXuat"].DisplayIndex = 0;
                dgvSuat.Columns["GiaVe"].HeaderText = "Giá vé";
                dgvSuat.Columns["ThoiDiem"].HeaderText = "Thời điểm bắt đầu";
                dgvSuat.Columns["MaPhim"].Visible = false;
                dgvSuat.Columns["MaPhong"].Visible = false;
                dgvSuat.Refresh();
            }
        }

        void loaddatacboPhong()
        {
            listPhong = cli.LayDanhSachPhongChieu().ToList();
            cboPhong.DataSource = listPhong;
            cboPhong.DisplayMember = "TenPhong";
            cboPhong.ValueMember = "MaPhong";
        }

        void loaddatacboPhim()
        {
            listPhim = cli.LayDanhSachPhim().ToList();
            cboPhim.DataSource = listPhim;
            cboPhim.DisplayMember = "TenPhim";
            cboPhim.ValueMember = "MaPhim";
        }

        void KhoaText()
        {
            tbxGiaVe.ReadOnly = true;
            dtiGio.Enabled = false;
            cboPhim.Enabled = false;
            btnLuu.Enabled = false;
            btnCapNhat.Enabled = false;
        }

        void MoText()
        {
            tbxGiaVe.ReadOnly = false;
            cboPhim.Enabled = true;
            btnLuu.Enabled = true;
            btnCapNhat.Enabled = false;
        }

        int ThoiLuongPhim(string maphim)
        {
            return listPhim.Where(c => c.MaPhim.Equals(maphim)).First().ThoiLuong;
        }

        int ChuanHoaPhut(int phut)
        {
            if (phut % 5 == 0)
                return phut;
            if (phut % 5 == 1)
                return phut + 4;
            if (phut % 5 == 2)
                return phut + 3;
            if (phut % 5 == 3)
                return phut + 2;
            return phut + 1;
        }

        private void cboPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPhong.SelectedIndex >= 0)
                loaddatadgvSuat();
        }

        private void dtiNgay_ValueChanged(object sender, EventArgs e)
        {
            loaddatadgvSuat();
            if (dtiNgay.Value < DateTime.Today)
            {
                btnCapNhat.Enabled = false;
                btnThem.Enabled = false;
                btnXoa.Enabled = false;
                btnLuu.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text.Equals("Thêm"))
            {
                MoText();
                tbxMaSuat.Text = cli.PhatSinhMaSuat(listSuat.ToArray(), cboPhong.SelectedValue.ToString(), dtiNgay.Value).ToString();
                btnThem.Text = "Hủy";
                if (listSuat.Count > 0)
                {
                    eXuatChieu xuat = listSuat.Last();
                    int gio = xuat.ThoiDiem.Value.Hour;
                    int phut = xuat.ThoiDiem.Value.Minute;
                    phut += ThoiLuongPhim(xuat.MaPhim) + 15;
                    int phut2 = ChuanHoaPhut(phut);
                    if (phut2 > 180)
                    {
                        gio += 3;
                        phut2 -= 180;
                    }
                    else if (phut2 > 120)
                    {
                        gio += 2;
                        phut2 -= 120;
                    }
                    else if (phut2 > 60)
                    {
                        gio += 1;
                        phut2 -= 60;
                    }
                    else
                    {

                    }
                    TimeSpan tp = new TimeSpan(gio, phut2, 00);
                    TimeSpan tpcuoi = new TimeSpan(21, 00, 00);
                    if (tp <= tpcuoi)
                    {
                        dtiGio.SelectedTime = tp;
                    }
                    else
                    {
                        MessageBox.Show("Phòng chiếu đã hết thời gian chiếu trong ngày này!");
                        KhoaText();
                        if (dgvSuat.SelectedRows.Count > 0)
                        {
                            tbxMaSuat.Text = dgvSuat.SelectedRows[0].Cells["MaXuat"].Value.ToString();
                            foreach (eXuatChieu suat in listSuat)
                            {
                                if (suat.MaXuat.Equals(tbxMaSuat.Text))
                                {
                                    tbxGiaVe.Text = suat.GiaVe.ToString();
                                    cboPhim.SelectedValue = suat.MaPhim;
                                    dtiGio.SelectedTime = new TimeSpan(suat.ThoiDiem.Value.Hour, suat.ThoiDiem.Value.Minute, 00);
                                }
                                break;
                            }
                        }
                        btnThem.Text = "Thêm";
                    }
                }
                else
                {
                    dtiGio.SelectedTime = new TimeSpan(10, 00, 00);
                }
            }
            else
            {
                KhoaText();
                if (dgvSuat.SelectedRows.Count > 0)
                {
                    tbxMaSuat.Text = dgvSuat.SelectedRows[0].Cells["MaXuat"].Value.ToString();
                    foreach (eXuatChieu suat in listSuat)
                    {
                        if (suat.MaXuat.Equals(tbxMaSuat.Text))
                        {
                            tbxGiaVe.Text = suat.GiaVe.ToString();
                            cboPhim.SelectedValue = suat.MaPhim;
                            dtiGio.SelectedTime = new TimeSpan(suat.ThoiDiem.Value.Hour, suat.ThoiDiem.Value.Minute, 00);
                        }
                        break;
                    }
                }
                btnThem.Text = "Thêm";
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            eXuatChieu suat = new eXuatChieu();
            suat.MaPhim = cboPhim.SelectedValue.ToString();
            suat.MaPhong = cboPhong.SelectedValue.ToString();
            suat.MaXuat = tbxMaSuat.Text;
            int a = -1;
            if (int.TryParse(tbxGiaVe.Text, out a))
            {
                if (a < 0)
                {
                    MessageBox.Show("Giá vé là số nguyên lớn hơn 0!");
                    return;
                }
                else
                {
                    suat.GiaVe = a;
                }
            }
            else
            {
                MessageBox.Show("Giá vé là số nguyên lớn hơn 0!");
                return;
            }
            suat.ThoiDiem = new DateTime(dtiNgay.Value.Year, dtiNgay.Value.Month, dtiNgay.Value.Day, dtiGio.SelectedTime.Hours, dtiGio.SelectedTime.Minutes, dtiGio.SelectedTime.Seconds);
            if (btnLuu.Text.Equals("Lưu"))
            {
                if (cli.ThemXuatChieu(suat) == 1)
                {
                    MessageBox.Show("Thêm thành công!");
                    loaddatadgvSuat();
                }
                else
                {
                    MessageBox.Show("Trùng mã!");
                }
                KhoaText();
                btnThem.Text = "Thêm";
            }
            else
            {
                if (cli.SuaXuatChieu(suat) == 1)
                {
                    MessageBox.Show("Cập nhật thành công!");
                    btnCapNhat.Text = "Cập nhật giá";
                    tbxGiaVe.ReadOnly = true;
                    btnLuu.Enabled = false;
                    btnThem.Enabled = true;
                    btnLuu.Text = "Lưu";
                }
                btnCapNhat.Text = "Cập nhật giá";
                tbxGiaVe.ReadOnly = true;
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
                btnLuu.Text = "Lưu";
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (btnCapNhat.Text.Equals("Cập nhật giá"))
            {
                btnCapNhat.Text = "Hủy";
                tbxGiaVe.ReadOnly = false;
                btnLuu.Enabled = true;
                btnThem.Enabled = false;
                btnLuu.Text = "Lưu sửa";
            }
            else
            {
                btnCapNhat.Text = "Cập nhật giá";
                tbxGiaVe.ReadOnly = true;
                btnLuu.Enabled = false;
                btnThem.Enabled = true;
                btnLuu.Text = "Lưu";
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (listSuat.Count > 0)
            {
                if (cli.XoaXuatChieu(listSuat.Last()) == 1)
                {
                    MessageBox.Show("Xóa thành công!");
                    loaddatadgvSuat();
                }
            }
            else
            {
                MessageBox.Show("Không còn suất chiếu để xóa!");
            }
        }

        private void dgvSuat_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvSuat.SelectedRows.Count > 0)
            {
                btnCapNhat.Enabled = true;
                tbxMaSuat.Text = dgvSuat.SelectedRows[0].Cells["MaXuat"].Value.ToString();
                foreach (eXuatChieu suat in listSuat)
                {
                    if (suat.MaXuat.Equals(tbxMaSuat.Text))
                    {
                        tbxGiaVe.Text = suat.GiaVe.ToString();
                        cboPhim.SelectedValue = suat.MaPhim;
                        dtiGio.SelectedTime = new TimeSpan(suat.ThoiDiem.Value.Hour, suat.ThoiDiem.Value.Minute, 00);
                        break;
                    }
                }
            }
            else
            {
                btnCapNhat.Enabled = false;
            }
        }
    }
}
