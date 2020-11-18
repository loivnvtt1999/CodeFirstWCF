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
    public partial class frmVe : Form
    {
        eNhanVien nv;
        int ViTriBuoc;
        frmBanVe frmBanVe;
        frmSoDoPhongChieu frmSoDoPhongChieu;
        frmBanDichVu_BanVe frmBanDichVu;
        frmHoaDon frmHoaDon;
        eHoaDon hd;
        eXuatChieu xc;
        List<eVe> vemua;
        List<eCT_HoaDon_DichVu> dvmua;
        PhongChieuClient cli;
        public frmVe()
        {
            InitializeComponent();
        }

        public frmVe(eNhanVien nhanVien)
        {
            InitializeComponent();
            nv = nhanVien;
        }

        private void frmVe_Load(object sender, EventArgs e)
        {
            LoadNewForm();
        }

        public void LoadNewForm()
        {
            cli = new PhongChieuClient();
            hd = new eHoaDon();
            hd.MaHoaDon = cli.PhatSinhMaHoaDon();
            hd.MaNhanVien = nv.MaNhanVien;
            hd.NgayLap = DateTime.Now;
            hd.MaKhachHang = "KH000";
            xc = new eXuatChieu();
            vemua = new List<eVe>();
            dvmua = new List<eCT_HoaDon_DichVu>();
            ThemTatCaGiaiDoan();
            ViTriBuoc = 0;
            Thiet_Lap_Chuyen_Giai_Doan(ViTriBuoc);
        }

        #region Chuyển màn hình
        void Thiet_Lap_Chuyen_Giai_Doan(int a)
        {
            if (a == 0) //Chọn suất
            {
                for (int i = 0; i < this.pnlBuoc.Controls.Count; i++)
                {
                    if (this.pnlBuoc.Controls[i].Name.Equals("frmBanVe"))
                    {
                        this.pnlBuoc.Controls[i].Show();
                        this.pnlBuoc.Controls[i].BringToFront();
                    }
                }
            }
            else if (a == 1) //Chọn ghế
            {
                for (int i = 0; i < this.pnlBuoc.Controls.Count; i++)
                {
                    if (this.pnlBuoc.Controls[i].Name.Equals("frmSoDoPhongChieu"))
                    {
                        frmSoDoPhongChieu = new frmSoDoPhongChieu(this, xc, hd);
                        List<Control> l = new List<Control>();
                        for (int j = i + 1; j < this.pnlBuoc.Controls.Count; j++)
                        {
                            l.Add(this.pnlBuoc.Controls[j]);
                        }
                        while (this.pnlBuoc.Controls.Count > i)
                        {
                            this.pnlBuoc.Controls.RemoveAt(i);
                        }
                        ThemGiaiDoan(frmSoDoPhongChieu);
                        for (int o = 0; o < l.Count; o++)
                        {
                            if (l[o].Name.Equals("frmBanVe"))
                            {
                                ThemGiaiDoan(frmBanVe);
                            }
                            else if (l[o].Name.Equals("frmBanDichVu_BanVe"))
                            {
                                ThemGiaiDoan(frmBanDichVu);
                            }
                            else if (l[o].Name.Equals("frmHoaDon"))
                            {
                                ThemGiaiDoan(frmHoaDon);
                            }
                        }
                        this.pnlBuoc.Controls[i].Show();
                        this.pnlBuoc.Controls[i].BringToFront();
                    }
                }
            }
            else if (a == 2) //Dịch vụ
            {
                for (int i = 0; i < this.pnlBuoc.Controls.Count; i++)
                {
                    if (this.pnlBuoc.Controls[i].Name.Equals("frmBanDichVu_BanVe"))
                    {

                        frmBanDichVu = new frmBanDichVu_BanVe(this, hd, vemua, xc);
                        List<Control> l = new List<Control>();
                        for (int j = i + 1; j < this.pnlBuoc.Controls.Count; j++)
                        {
                            l.Add(this.pnlBuoc.Controls[j]);
                        }
                        while (this.pnlBuoc.Controls.Count > i)
                        {
                            this.pnlBuoc.Controls.RemoveAt(i);
                        }
                        ThemGiaiDoan(frmBanDichVu);
                        for (int o = 0; o < l.Count; o++)
                        {
                            if (l[o].Name.Equals("frmBanVe"))
                            {
                                ThemGiaiDoan(frmBanVe);
                            }
                            else if (l[o].Name.Equals("frmSoDoPhongChieu"))
                            {
                                ThemGiaiDoan(frmSoDoPhongChieu);
                            }
                            else if (l[o].Name.Equals("frmHoaDon"))
                            {
                                ThemGiaiDoan(frmHoaDon);
                            }
                        }
                        this.pnlBuoc.Controls[i].Show();
                        this.pnlBuoc.Controls[i].BringToFront();
                    }
                }
            }
            else //kết thúc
            {
                for (int i = 0; i < this.pnlBuoc.Controls.Count; i++)
                {
                    if (this.pnlBuoc.Controls[i].Name.Equals("frmHoaDon"))
                    {
                        frmHoaDon = new frmHoaDon(this, hd, vemua, dvmua, xc);
                        List<Control> l = new List<Control>();
                        for (int j = i + 1; j < this.pnlBuoc.Controls.Count; j++)
                        {
                            l.Add(this.pnlBuoc.Controls[j]);
                        }
                        while (this.pnlBuoc.Controls.Count > i)
                        {
                            this.pnlBuoc.Controls.RemoveAt(i);
                        }
                        ThemGiaiDoan(frmHoaDon);
                        for (int o = 0; o < l.Count; o++)
                        {
                            if (l[o].Name.Equals("frmBanVe"))
                            {
                                ThemGiaiDoan(frmBanVe);
                            }
                            else if (l[o].Name.Equals("frmSoDoPhongChieu"))
                            {
                                ThemGiaiDoan(frmSoDoPhongChieu);
                            }
                            else if (l[o].Name.Equals("frmBanDichVu_BanVe"))
                            {
                                ThemGiaiDoan(frmBanDichVu);
                            }
                        }
                        this.pnlBuoc.Controls[i].Show();
                        this.pnlBuoc.Controls[i].BringToFront();
                    }
                }
            }
        }
        #endregion

        #region Thêm các màn hình chức năng
        //Thêm tất cả giai đoạn
        void ThemTatCaGiaiDoan()
        {
            this.pnlBuoc.Controls.Clear();
            frmBanVe = new frmBanVe(this);
            frmSoDoPhongChieu = new frmSoDoPhongChieu(this, xc, hd);
            frmBanDichVu = new frmBanDichVu_BanVe(this, hd, vemua, xc);
            frmHoaDon = new frmHoaDon(this, hd, vemua, dvmua, xc);
            ThemGiaiDoan(frmBanVe);
            ThemGiaiDoan(frmSoDoPhongChieu);
            ThemGiaiDoan(frmBanDichVu);
            ThemGiaiDoan(frmHoaDon);
        }
        //Thêm từng giai đoạn
        void ThemGiaiDoan(Form frm)
        {
            frm.TopLevel = false;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.ShowInTaskbar = false;
            frm.Dock = DockStyle.Fill;
            this.pnlBuoc.Controls.Add(frm);
        }
        #endregion

        public void GoNext()
        {
            switch (ViTriBuoc)
            {
                case 0:
                    xc = frmBanVe.Suat;
                    ViTriBuoc++;
                    Thiet_Lap_Chuyen_Giai_Doan(ViTriBuoc);
                    break;
                case 1:
                    vemua = frmSoDoPhongChieu.lstVeChon;
                    ViTriBuoc++;
                    Thiet_Lap_Chuyen_Giai_Doan(ViTriBuoc);
                    break;
                case 2:
                    dvmua = frmBanDichVu.lstGioHang;
                    ViTriBuoc++;
                    Thiet_Lap_Chuyen_Giai_Doan(ViTriBuoc);
                    break;
                case 3:
                    LoadNewForm();
                    break;
            }
        }

        public void GoBack()
        {
            switch (ViTriBuoc)
            {
                case 1:
                    ViTriBuoc--;
                    Thiet_Lap_Chuyen_Giai_Doan(ViTriBuoc);
                    break;
                case 2:
                    ViTriBuoc--;
                    Thiet_Lap_Chuyen_Giai_Doan(ViTriBuoc);
                    break;
                case 3:
                    ViTriBuoc--;
                    Thiet_Lap_Chuyen_Giai_Doan(ViTriBuoc);
                    break;
            }
        }
    }
}
