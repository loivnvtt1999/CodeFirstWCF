using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entities;
using CodeFirst_DAL;

namespace WcfServicePhongChieuPhim
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class QuanLyPhongChieuPhimService : IPhongChieu
    {
        QuanLyRapChieuPhimDataContext db = new QuanLyRapChieuPhimDataContext();

        #region BUS_NhanVien
        public bool KiemTraNhanVien(String ma)
        {
            NhanVien nv = db.NhanViens.Where(x => x.MaNhanVien == ma).FirstOrDefault();
            if (nv == null)
            {
                return false;
            }
            return true;
        }

        public int ThemNhanVien(eNhanVien nvmoi)
        {
            NhanVien nv1 = db.NhanViens.Where(x => x.MaNhanVien.Equals(nvmoi.MaNhanVien)).FirstOrDefault();
            if (nv1 != null)
            {
                return 0;
            }
            NhanVien nv = new NhanVien();
            nv.MaNhanVien = nvmoi.MaNhanVien;
            nv.TenNhanVien = nvmoi.TenNhanVien;
            nv.CMND = nvmoi.CMND;
            nv.NgaySinh = nvmoi.NgaySinh;
            nv.SDT = nvmoi.SDT;
            nv.Email = nvmoi.Email;
            nv.ChucVu = nvmoi.ChucVu;
            if (nvmoi.Anh != null)
            {
                nv.Anh = nvmoi.Anh.ToArray();
            }
            else nv.Anh = null;
            nv.MatKhau = nvmoi.MatKhau;
            db.NhanViens.Add(nv);
            db.SaveChanges();
            return 1;
        }

        public int SuaNhanVien(eNhanVien nvsua)
        {
            NhanVien nv = db.NhanViens.Where(x => x.MaNhanVien.Equals(nvsua.MaNhanVien)).FirstOrDefault();
            if (nv != null)
            {
                nv.TenNhanVien = nvsua.TenNhanVien;
                nv.CMND = nvsua.CMND;
                nv.NgaySinh = nvsua.NgaySinh;
                nv.SDT = nvsua.SDT;
                nv.Email = nvsua.Email;
                nv.ChucVu = nvsua.ChucVu;
                if (nvsua.Anh != null)
                {
                    nv.Anh = nvsua.Anh.ToArray();
                }
                else nv.Anh = null;
                nv.MatKhau = nvsua.MatKhau;
                db.SaveChanges();
                return 1;
            }
            return 0;
        }

        public void DatLaiMatKhau(string maNV)
        {
            NhanVien nv = db.NhanViens.Where(x => x.MaNhanVien.Equals(maNV)).FirstOrDefault();
            if (nv != null)
            {
                nv.MatKhau = "12345678";
                db.SaveChanges();
            }
        }

        public List<eNhanVien> LayDanhSachNhanVien()
        {
            var listnv = db.NhanViens.ToList();
            List<eNhanVien> listenv = new List<eNhanVien>();
            foreach (NhanVien nv in listnv)
            {
                eNhanVien env = new eNhanVien();
                env.MaNhanVien = nv.MaNhanVien;
                env.TenNhanVien = nv.TenNhanVien;
                env.CMND = nv.CMND;
                env.NgaySinh = nv.NgaySinh;
                env.SDT = nv.SDT;
                env.Email = nv.Email;
                env.ChucVu = nv.ChucVu;
                env.Anh = nv.Anh;
                env.MatKhau = nv.MatKhau;
                listenv.Add(env);
            }
            return listenv;
        }

        public string PhatSinhMaNhanVien()
        {
            List<NhanVien> nhanViens = db.NhanViens.ToList();
            NhanVien nhanVien = nhanViens.LastOrDefault();
            string ma = "NV";
            int so = int.Parse(nhanVien.MaNhanVien.Substring(2, 3));
            if ((so + 1) < 10)
            {
                ma += "00" + (so + 1).ToString();
            }
            else if ((so + 1) < 100)
            {
                ma += "0" + (so + 1).ToString();
            }
            else
            {
                ma += (so + 1).ToString();
            }
            return ma;
        }

        public eNhanVien TimNhanVienTheoMa(string manhanvien)
        {
            NhanVien nv = db.NhanViens.Where(x => x.MaNhanVien.Equals(manhanvien)).FirstOrDefault();
            if (nv == null)
            {
                return null;
            }
            else
            {
                eNhanVien env = new eNhanVien();
                env.MaNhanVien = nv.MaNhanVien;
                env.TenNhanVien = nv.TenNhanVien;
                env.CMND = nv.CMND;
                env.NgaySinh = nv.NgaySinh;
                env.SDT = nv.SDT;
                env.Email = nv.Email;
                env.ChucVu = nv.ChucVu;
                env.Anh = nv.Anh;
                env.MatKhau = nv.MatKhau;
                return env;
            }
        }

        public eNhanVien KiemTraDangNhap(string taikhoan, string matkhau)
        {
            NhanVien nv = db.NhanViens.Where(x => x.MaNhanVien.Equals(taikhoan) && x.MatKhau.Equals(matkhau)).FirstOrDefault();
            if (nv == null)
                return null;
            else
            {
                eNhanVien nv1 = new eNhanVien();
                nv1.Anh = nv.Anh;
                nv1.ChucVu = nv.ChucVu;
                nv1.CMND = nv.CMND;
                nv1.MaNhanVien = nv.MaNhanVien;
                nv1.MatKhau = nv.MatKhau;
                nv1.SDT = nv.SDT;
                nv1.TenNhanVien = nv.TenNhanVien;
                nv1.Email = nv.Email;
                nv1.NgaySinh = nv.NgaySinh;
                return nv1;
            }
        }
        #endregion

        #region BUS_KhachHang 
        private bool KiemTraKhachHang(String ma)
        {
            KhachHang kh = db.KhachHangs.Where(x => x.MaKhachHang.Equals(ma)).FirstOrDefault();
            if (kh != null)
                return true;
            return false;
        }

        public int ThemKhachHang(eKhachHang kh)
        {
            if (KiemTraKhachHang(kh.MaKhachHang))
                return 0;
            KhachHang khmoi = new KhachHang();
            khmoi.MaKhachHang = kh.MaKhachHang;
            khmoi.TenKhachHang = kh.TenKhachHang;
            khmoi.NgaySinh = kh.NgaySinh;
            khmoi.CMND = kh.CMND;
            khmoi.Email = kh.Email;
            khmoi.SDT = kh.SDT;
            db.KhachHangs.Add(khmoi);
            db.SaveChanges();
            return 1;
        }

        public int SuaKhachHang(eKhachHang kh)
        {
            if (!KiemTraKhachHang(kh.MaKhachHang))
                return 0;
            KhachHang khsua = db.KhachHangs.Where(x => x.MaKhachHang.Equals(kh.MaKhachHang)).FirstOrDefault();
            khsua.TenKhachHang = kh.TenKhachHang;
            khsua.SDT = kh.SDT;
            khsua.Email = kh.Email;
            khsua.CMND = kh.CMND;
            khsua.NgaySinh = kh.NgaySinh;
            db.SaveChanges();
            return 1;
        }

        public List<eKhachHang> LayDanhSachKhachHang()
        {
            List<eKhachHang> l = new List<eKhachHang>();
            foreach (KhachHang kh in db.KhachHangs)
            {
                eKhachHang khmoi = new eKhachHang();
                khmoi.MaKhachHang = kh.MaKhachHang;
                khmoi.TenKhachHang = kh.TenKhachHang;
                khmoi.CMND = kh.CMND;
                khmoi.SDT = kh.SDT;
                khmoi.Email = kh.Email;
                khmoi.NgaySinh = kh.NgaySinh;
                l.Add(khmoi);
            }
            return l;
        }

        public eKhachHang TimKhachHangTheoMa(String ma)
        {
            KhachHang kh = db.KhachHangs.Where(x => x.MaKhachHang.Equals(ma)).FirstOrDefault();
            if (kh == null)
                kh = db.KhachHangs.Where(x => x.MaKhachHang.Equals("KH000")).FirstOrDefault();
            eKhachHang khlay = new eKhachHang();
            khlay.MaKhachHang = kh.MaKhachHang;
            khlay.TenKhachHang = kh.TenKhachHang;
            khlay.CMND = kh.CMND;
            khlay.SDT = kh.SDT;
            khlay.Email = kh.Email;
            khlay.NgaySinh = kh.NgaySinh;
            return khlay;
        }

        public eKhachHang TimKhachHangTheoSDT(String sdt)
        {
            KhachHang kh = db.KhachHangs.Where(x => x.SDT.Equals(sdt)).FirstOrDefault();
            if (kh == null)
                kh = db.KhachHangs.Where(x => x.MaKhachHang.Equals("KH000")).FirstOrDefault();
            eKhachHang khlay = new eKhachHang();
            khlay.MaKhachHang = kh.MaKhachHang;
            khlay.TenKhachHang = kh.TenKhachHang;
            khlay.CMND = kh.CMND;
            khlay.SDT = kh.SDT;
            khlay.Email = kh.Email;
            khlay.NgaySinh = kh.NgaySinh;
            return khlay;
        }

        public string PhatSinhMaKhachHang()
        {
            List<KhachHang> khs = db.KhachHangs.ToList();
            KhachHang KhachHang = khs.LastOrDefault();
            string ma = "KH";
            int so = int.Parse(KhachHang.MaKhachHang.Substring(2, 3));
            if ((so + 1) < 10)
            {
                ma += "00" + (so + 1).ToString();
            }
            else if ((so + 1) < 100)
            {
                ma += "0" + (so + 1).ToString();
            }
            else
            {
                ma += (so + 1).ToString();
            }
            return ma;
        }

        public eKhachHang TimKhachHangTheoTen(String ten)
        {
            KhachHang kh = db.KhachHangs.Where(x => x.TenKhachHang.Equals(ten)).FirstOrDefault();
            if (kh == null)
                return null;
            eKhachHang khlay = new eKhachHang();
            khlay.MaKhachHang = kh.MaKhachHang;
            khlay.TenKhachHang = kh.TenKhachHang;
            khlay.CMND = kh.CMND;
            khlay.SDT = kh.SDT;
            khlay.Email = kh.Email;
            khlay.NgaySinh = kh.NgaySinh;
            return khlay;
        }
        #endregion

        #region BUS_HoaDon
        public int ThemHoaDon(eHoaDon hoadonmoi)
        {
            HoaDon hd1 = db.HoaDons.Where(x => x.MaHoaDon.Equals(hoadonmoi.MaHoaDon)).FirstOrDefault();
            if (hd1 != null)
            {
                return 0;
            }
            HoaDon hd = new HoaDon();
            hd.MaHoaDon = hoadonmoi.MaHoaDon;
            hd.MaNhanVien = hoadonmoi.MaNhanVien;
            hd.MaKhachHang = hoadonmoi.MaKhachHang;
            hd.NgayLap = hoadonmoi.NgayLap;
            db.HoaDons.Add(hd);
            db.SaveChanges();
            return 1;
        }

        public List<eHoaDon> LayDanhSachHoaDonTheoThang(int month, int year)
        {
            List<eHoaDon> le = new List<eHoaDon>();
            List<HoaDon> l = db.HoaDons.Where(x => x.NgayLap.Value.Year == year && x.NgayLap.Value.Month == month).ToList();
            foreach (HoaDon hoaDon in l)
            {
                eHoaDon hd = new eHoaDon();
                hd.MaHoaDon = hoaDon.MaHoaDon;
                hd.MaNhanVien = hoaDon.MaNhanVien;
                hd.MaKhachHang = hoaDon.MaKhachHang;
                hd.NgayLap = hoaDon.NgayLap;
                le.Add(hd);
            }
            return le;
        }

        public string PhatSinhMaHoaDon()
        {
            List<HoaDon> hds = db.HoaDons.ToList();
            HoaDon HoaDon = hds.LastOrDefault();
            if (HoaDon != null)
            {
                string ma = "HD_"+daytostring(DateTime.Today)+"_";
                int so = int.Parse(HoaDon.MaHoaDon.Substring(12, 4));
                if ((so + 1) < 10)
                {
                    ma += "000" + (so + 1).ToString();
                }
                else if ((so + 1) < 100)
                {
                    ma += "00" + (so + 1).ToString();
                }
                else if ((so + 1) < 1000)
                {
                    ma += "0" + (so + 1).ToString();
                }
                else
                {
                    ma += (so + 1).ToString();
                }
                return ma;
            }
            else
                return "HD_" + daytostring(DateTime.Today) + "_0001";
        }
        #endregion

        #region BUS_CT_HoaDon_DichVu
        public int ThemCT_DichVu(eCT_HoaDon_DichVu ctDVmoi)
        {
            CT_HoaDon_DichVu ct = db.CT_HoaDon_DichVus.Where(t => t.MaDichVu.Equals(ctDVmoi.MaDichVu) && t.MaHoaDon.Equals(ctDVmoi.MaHoaDon)).FirstOrDefault();
            if (ct != null)
                return 0;
            CT_HoaDon_DichVu ct1 = new CT_HoaDon_DichVu();
            ct1.MaDichVu = ctDVmoi.MaDichVu;
            ct1.MaHoaDon = ctDVmoi.MaHoaDon;
            ct1.SoLuong = ctDVmoi.SoLuong;
            db.CT_HoaDon_DichVus.Add(ct1);
            db.SaveChanges();
            return 1;
        }

        public List<eCT_HoaDon_DichVu> LayDanhSachDichVuTheoHoaDon(string mahoadon)
        {
            List<CT_HoaDon_DichVu> cts = db.CT_HoaDon_DichVus.Where(t => t.MaHoaDon.Equals(mahoadon)).ToList();
            List<eCT_HoaDon_DichVu> l = new List<eCT_HoaDon_DichVu>();
            foreach (CT_HoaDon_DichVu ct in cts)
            {
                eCT_HoaDon_DichVu ect = new eCT_HoaDon_DichVu();
                ect.MaDichVu = ct.MaDichVu;
                ect.MaHoaDon = ct.MaHoaDon;
                ect.SoLuong = ct.SoLuong;
                l.Add(ect);
            }
            return l;
        }
        #endregion

        #region BUS_DichVu
        public int ThemDichVu(eDichVu dichvumoi)
        {
            DichVu dv = new DichVu();
            dv.MaDichVu = dichvumoi.MaDichVu;
            dv.TenDichVu = dichvumoi.TenDichVu;
            dv.DonGia = dichvumoi.DonGia;
            if (dichvumoi.Anh != null)
            {
                dv.Anh = dichvumoi.Anh.ToArray();
            }
            else dv.Anh = null;
            db.DichVus.Add(dv);
            db.SaveChanges();
            return 1;
        }

        public int SuaDichVu(eDichVu dichvusua)
        {
            DichVu dv = db.DichVus.Where(x => x.MaDichVu.Equals(dichvusua.MaDichVu)).FirstOrDefault();
            dv.TenDichVu = dichvusua.TenDichVu;
            dv.DonGia = dichvusua.DonGia;
            if (dichvusua.Anh != null)
            {
                dv.Anh = dichvusua.Anh.ToArray();
            }
            else dv.Anh = null;
            db.SaveChanges();
            return 1;
        }

        public List<eDichVu> LayDanhSachDichVu()
        {
            List<DichVu> ldv = db.DichVus.ToList();
            List<eDichVu> ledv = new List<eDichVu>();
            foreach (DichVu dv in ldv)
            {
                eDichVu edv = new eDichVu();
                edv.MaDichVu = dv.MaDichVu;
                edv.TenDichVu = dv.TenDichVu;
                edv.DonGia = dv.DonGia;
                edv.Anh = dv.Anh;
                ledv.Add(edv);
            }
            return ledv;
        }

        public eDichVu LayDichVuTheoMa(String ma)
        {
            DichVu dv = db.DichVus.Where(x => x.MaDichVu.Equals(ma)).FirstOrDefault();
            eDichVu edv = new eDichVu();
            edv.MaDichVu = dv.MaDichVu;
            edv.TenDichVu = dv.TenDichVu;
            edv.DonGia = dv.DonGia;
            return edv;
        }

        public string PhatSinhMaDichVu()
        {
            List<DichVu> dvs = db.DichVus.ToList();
            DichVu DV = dvs.LastOrDefault();
            string ma = "DV";
            int so = int.Parse(DV.MaDichVu.Substring(2, 3));
            if ((so + 1) < 10)
            {
                ma += "00" + (so + 1).ToString();
            }
            else if ((so + 1) < 100)
            {
                ma += "0" + (so + 1).ToString();
            }
            else
            {
                ma += (so + 1).ToString();
            }
            return ma;
        }
        #endregion

        #region BUS_Ve
        public int ThemVe(eVe xcmoi)
        {
            Ve ve = db.Ves.Where(t => t.MaHoaDon.Equals(xcmoi.MaHoaDon) 
                                && t.MaXuat.Equals(xcmoi.MaXuat)
                                && t.VitriGhe.Equals(xcmoi.VitriGhe)).FirstOrDefault();
            if (ve != null)
                return 0;
            Ve v = new Ve();
            v.MaXuat = xcmoi.MaXuat;
            v.MaHoaDon = xcmoi.MaHoaDon;
            v.VitriGhe = xcmoi.VitriGhe;
            db.Ves.Add(v);
            db.SaveChanges();
            return 1;
        }

        public List<eVe> LayDanhSachVeTheoXuatChieu(string maxuat)
        {
            List<Ve> l = db.Ves.Where(x => x.MaXuat.Equals(maxuat)).ToList();
            List<eVe> l1 = new List<eVe>();
            foreach (Ve ve in l)
            {
                eVe eve = new eVe();
                eve.MaHoaDon = ve.MaHoaDon;
                eve.MaXuat = ve.MaXuat;
                eve.VitriGhe = ve.VitriGhe;
                l1.Add(eve);
            }
            return l1;
        }
        #endregion

        #region BUS_XuatChieu
        public int ThemXuatChieu(eXuatChieu xcmoi)
        {
            XuatChieu x = db.XuatChieus.Where(c => c.MaXuat.Equals(xcmoi.MaXuat)).FirstOrDefault();
            if (x != null)
            {
                return 0;
            }
            else
            {
                XuatChieu xuat = new XuatChieu();
                xuat.MaPhim = xcmoi.MaPhim;
                xuat.MaPhong = xcmoi.MaPhong;
                xuat.GiaVe = xcmoi.GiaVe;
                xuat.MaXuat = xcmoi.MaXuat;
                xuat.ThoiDiem = xcmoi.ThoiDiem;
                db.XuatChieus.Add(xuat);
                db.SaveChanges();
                return 1;
            }
        }

        public int SuaXuatChieu(eXuatChieu xcsua)
        {
            XuatChieu x = db.XuatChieus.Where(c => c.MaXuat.Equals(xcsua.MaXuat)).FirstOrDefault();
            if (x != null)
            {
                x.GiaVe = xcsua.GiaVe;
                db.SaveChanges();
                return 1;
            }
            return 0;
        }

        public int XoaXuatChieu(eXuatChieu xcxoa)
        {
            XuatChieu x = db.XuatChieus.Where(c => c.MaXuat.Equals(xcxoa.MaXuat)).FirstOrDefault();
            if (x != null)
            {
                db.XuatChieus.Remove(x);
                db.SaveChanges();
                return 1;
            }
            return 0;
        }

        public string PhatSinhMaSuat(List<eXuatChieu> eXuatChieus, string phong, DateTime ngay)
        {
            if (eXuatChieus.Count > 0)
            {
                string s = eXuatChieus.Last().MaXuat.Substring(21, 2);
                int a = 0;
                if (int.TryParse(s, out a))
                {
                    if ((a + 1) < 10)
                    {
                        return phong + "_" + daytostring(ngay) + "_" + "Suat0" + (a + 1).ToString();
                    }
                    else
                    {
                        return phong + "_" + daytostring(ngay) + "_" + "Suat" + (a + 1).ToString();
                    }
                }
                else
                    return "";
            }
            else
            {
                return phong + "_" + daytostring(ngay) + "_" + "Suat01";
            }
        }

        private string daytostring(DateTime ngay)
        {
            string s = "";
            if (ngay.Day < 10)
            {
                s += "0" + ngay.Day;
            }
            else
            {
                s += ngay.Day;
            }
            if (ngay.Month < 10)
            {
                s += "0" + ngay.Month;
            }
            else
            {
                s += ngay.Month;
            }
            if (ngay.Year < 10)
            {
                s += "000" + ngay.Year;
            }
            else if (ngay.Year < 100)
            {
                s += "00" + ngay.Year;
            }
            else if (ngay.Year < 1000)
            {
                s += "0" + ngay.Year;
            }
            else
            {
                s += ngay.Year;
            }
            return s;
        }

        public eXuatChieu LayXuatChieuTheoMa(String maXuat)
        {
            XuatChieu xc = db.XuatChieus.Where(x => x.MaXuat.Equals(maXuat)).FirstOrDefault();
            eXuatChieu exc = new eXuatChieu();
            exc.MaXuat = xc.MaXuat;
            exc.MaPhim = xc.MaPhim;
            exc.MaPhong = xc.MaPhong;
            exc.ThoiDiem = xc.ThoiDiem;
            exc.GiaVe = xc.GiaVe;
            return exc;
        }

        public List<eXuatChieu> LayDanhSachXuatChieuTheoNgayTheoPhong(string maphong, DateTime day)
        {
            List<eXuatChieu> le = new List<eXuatChieu>();
            List<XuatChieu> l = db.XuatChieus.Where(c => c.MaPhong.Equals(maphong)
                                                    && c.ThoiDiem.Value.Year == day.Year
                                                    && c.ThoiDiem.Value.Month == day.Month
                                                    && c.ThoiDiem.Value.Day == day.Day).ToList();
            foreach (XuatChieu xuat in l)
            {
                eXuatChieu exuat = new eXuatChieu();
                exuat.MaPhim = xuat.MaPhim;
                exuat.MaPhong = xuat.MaPhong;
                exuat.GiaVe = xuat.GiaVe;
                exuat.MaXuat = xuat.MaXuat;
                exuat.ThoiDiem = xuat.ThoiDiem;
                le.Add(exuat);
            }
            return le;
        }

        public List<eXuatChieu> LayDanhSachXuatChieuCuaPhimTheoNgay(string maphim, int day, int month, int year)
        {
            List<eXuatChieu> l1 = new List<eXuatChieu>();
            List<XuatChieu> Lxc = db.XuatChieus.Where(x => x.MaPhim.Equals(maphim)
             && x.ThoiDiem.Value.Day == day
             && x.ThoiDiem.Value.Month == month
             && x.ThoiDiem.Value.Year == year).ToList();
            if (Lxc == null)
            {
                return null;
            }
            else
            {
                foreach (XuatChieu xc in Lxc)
                {
                    eXuatChieu exc = new eXuatChieu();
                    exc.GiaVe = xc.GiaVe;
                    exc.ThoiDiem = xc.ThoiDiem;
                    exc.MaXuat = xc.MaXuat;
                    exc.MaPhim = xc.MaPhim;
                    exc.MaPhong = xc.MaPhong;
                    l1.Add(exc);
                }
                return l1;
            }
        }
        #endregion

        #region BUS_PhongChieu
        public int ThemPhong(ePhongChieu phongmoi)
        {
            PhongChieu pc = new PhongChieu();
            pc.MaPhong = phongmoi.MaPhong;
            pc.TenPhong = phongmoi.TenPhong;
            db.PhongChieus.Add(pc);
            ThemGheVaoPhong(pc.MaPhong);
            db.SaveChanges();
            return 1;
        }

        private void ThemGheVaoPhong(string phong)
        {
            for (int j = 0; j < 10; j++)
            {
                GheNgoi tam;
                switch (j)
                {
                    case 0:
                        for (int k = 0; k < 15; k++)
                        {
                            tam = new GheNgoi();
                            tam.MaPhong = phong;
                            tam.Hang = "A";
                            tam.So = (k + 1).ToString();
                            tam.MaGhe = tam.MaPhong + tam.Hang + tam.So;
                            tam.TrangThai = "Có";
                            db.GheNgois.Add(tam);
                        }
                        break;
                    case 1:
                        for (int k = 0; k < 15; k++)
                        {
                            tam = new GheNgoi();
                            tam.MaPhong = phong;
                            tam.Hang = "B";
                            tam.So = (k + 1).ToString();
                            tam.MaGhe = tam.MaPhong + tam.Hang + tam.So;
                            tam.TrangThai = "Có";
                            db.GheNgois.Add(tam);
                        }
                        break;
                    case 2:
                        for (int k = 0; k < 15; k++)
                        {
                            tam = new GheNgoi();
                            tam.MaPhong = phong;
                            tam.Hang = "C";
                            tam.So = (k + 1).ToString();
                            tam.MaGhe = tam.MaPhong + tam.Hang + tam.So;
                            tam.TrangThai = "Có";
                            db.GheNgois.Add(tam);
                        }
                        break;
                    case 3:
                        for (int k = 0; k < 15; k++)
                        {
                            tam = new GheNgoi();
                            tam.MaPhong = phong;
                            tam.Hang = "D";
                            tam.So = (k + 1).ToString();
                            tam.MaGhe = tam.MaPhong + tam.Hang + tam.So;
                            tam.TrangThai = "Có";
                            db.GheNgois.Add(tam);
                        }
                        break;
                    case 4:
                        for (int k = 0; k < 15; k++)
                        {
                            tam = new GheNgoi();
                            tam.MaPhong = phong;
                            tam.Hang = "E";
                            tam.So = (k + 1).ToString();
                            tam.MaGhe = tam.MaPhong + tam.Hang + tam.So;
                            tam.TrangThai = "Có";
                            db.GheNgois.Add(tam);
                        }
                        break;
                    case 5:
                        for (int k = 0; k < 15; k++)
                        {
                            tam = new GheNgoi();
                            tam.MaPhong = phong;
                            tam.Hang = "F";
                            tam.So = (k + 1).ToString();
                            tam.MaGhe = tam.MaPhong + tam.Hang + tam.So;
                            tam.TrangThai = "Có";
                            db.GheNgois.Add(tam);
                        }
                        break;
                    case 6:
                        for (int k = 0; k < 15; k++)
                        {
                            tam = new GheNgoi();
                            tam.MaPhong = phong;
                            tam.Hang = "G";
                            tam.So = (k + 1).ToString();
                            tam.MaGhe = tam.MaPhong + tam.Hang + tam.So;
                            tam.TrangThai = "Có";
                            db.GheNgois.Add(tam);
                        }
                        break;
                    case 7:
                        for (int k = 0; k < 15; k++)
                        {
                            tam = new GheNgoi();
                            tam.MaPhong = phong;
                            tam.Hang = "H";
                            tam.So = (k + 1).ToString();
                            tam.MaGhe = tam.MaPhong + tam.Hang + tam.So;
                            tam.TrangThai = "Có";
                            db.GheNgois.Add(tam);
                        }
                        break;
                    case 8:
                        for (int k = 0; k < 15; k++)
                        {
                            tam = new GheNgoi();
                            tam.MaPhong = phong;
                            tam.Hang = "I";
                            tam.So = (k + 1).ToString();
                            tam.MaGhe = tam.MaPhong + tam.Hang + tam.So;
                            tam.TrangThai = "Có";
                            db.GheNgois.Add(tam);
                        }
                        break;
                    case 9:
                        for (int k = 0; k < 15; k++)
                        {
                            tam = new GheNgoi();
                            tam.MaPhong = phong;
                            tam.Hang = "J";
                            tam.So = (k + 1).ToString();
                            tam.MaGhe = tam.MaPhong + tam.Hang + tam.So;
                            tam.TrangThai = "Có";
                            db.GheNgois.Add(tam);
                        }
                        break;
                }
            }
        }

        public ePhongChieu LayPhongChieuTheoMa(String ma)
        {
            ePhongChieu epc = new ePhongChieu();
            PhongChieu pc = db.PhongChieus.Where(x => x.MaPhong.Equals(ma)).FirstOrDefault();
            epc.MaPhong = pc.MaPhong;
            epc.TenPhong = pc.TenPhong;
            return epc;
        }

        public List<ePhongChieu> LayDanhSachPhongChieu()
        {
            List<PhongChieu> lphong = db.PhongChieus.ToList();
            List<ePhongChieu> l = new List<ePhongChieu>();
            foreach (PhongChieu phong in lphong)
            {
                ePhongChieu p = new ePhongChieu();
                p.MaPhong = phong.MaPhong;
                p.TenPhong = phong.TenPhong;
                l.Add(p);
            }
            return l;
        }

        public string PhatSinhMaPhong()
        {
            List<PhongChieu> phongs = db.PhongChieus.ToList();
            PhongChieu phong = phongs.LastOrDefault();
            if (phong != null)
            {
                string ma = "Phong";
                int so = int.Parse(phong.MaPhong.Substring(5, 2));
                if ((so + 1) < 10)
                {
                    ma += "0" + (so + 1).ToString();
                }
                else
                {
                    ma += (so + 1).ToString();
                }
                return ma;
            }
            else
                return "Phong01";
        }
        #endregion

        #region BUS_GheNgoi
        public List<eGheNgoi> LayDanhSachGheNgoiTheoPhong(string maphong)
        {
            List<GheNgoi> lphong = db.GheNgois.Where(g => g.MaPhong.Equals(maphong)).ToList();
            List<eGheNgoi> l = new List<eGheNgoi>();
            foreach (GheNgoi ghe in lphong)
            {
                eGheNgoi g = new eGheNgoi();
                g.MaPhong = ghe.MaPhong;
                g.MaGhe = ghe.MaGhe;
                g.Hang = ghe.Hang;
                g.So = ghe.So;
                g.TrangThai = ghe.TrangThai;
                l.Add(g);
            }
            return l;
        }

        public bool CapNhatTrangThaiGhe(eGheNgoi ghe, string maphong)
        {
            bool kq = false;
            GheNgoi gheNgoi = db.GheNgois.Where(c => c.MaPhong.Equals(maphong) && c.Hang.Equals(ghe.Hang) && c.So.Equals(ghe.So)).FirstOrDefault();
            if (gheNgoi != null)
            {
                if (gheNgoi.TrangThai.Equals("Có"))
                {
                    gheNgoi.TrangThai = "Không";
                }
                else
                {
                    gheNgoi.TrangThai = "Có";
                }
                db.SaveChanges();
                kq = true;
            }
            return kq;
        }
        #endregion

        #region BUS_Phim
        public int ThemPhim(ePhim phimmoi)
        {
            Phim p1 = db.Phims.Where(x => x.MaPhim.Equals(phimmoi.MaPhim)).FirstOrDefault();
            if (p1 != null)
            {
                return 0;
            }
            Phim p = new Phim();
            p.MaPhim = phimmoi.MaPhim;
            p.TenPhim = phimmoi.TenPhim;
            p.NgayCongChieu = phimmoi.NgayCongChieu;
            p.DaoDien = phimmoi.DaoDien;
            p.TheLoai = phimmoi.TheLoai;
            p.ThoiLuong = phimmoi.ThoiLuong;
            p.DienVienChinh = phimmoi.DienVienChinh;
            p.NgonNgu = phimmoi.NgonNgu;
            p.GioiHanDoTuoi = phimmoi.GioiHanDoTuoi;
            if (phimmoi.Poster != null)
            {
                p.Poster = phimmoi.Poster.ToArray();
            }
            else p.Poster = null;
            if (phimmoi.MoTa != null)
            {
                p.MoTa = phimmoi.MoTa;
            }
            else p.MoTa = "";
            p.MaNSX = phimmoi.MaNSX;
            db.Phims.Add(p);
            db.SaveChanges();
            return 1;
        }

        public int SuaPhim(ePhim phimsua)
        {
            Phim p = db.Phims.Where(x => x.MaPhim.Equals(phimsua.MaPhim)).FirstOrDefault();
            if (p != null)
            {
                p.TenPhim = phimsua.TenPhim;
                p.NgayCongChieu = phimsua.NgayCongChieu;
                p.DaoDien = phimsua.DaoDien;
                p.TheLoai = phimsua.TheLoai;
                p.ThoiLuong = phimsua.ThoiLuong;
                p.DienVienChinh = phimsua.DienVienChinh;
                p.NgonNgu = phimsua.NgonNgu;
                p.GioiHanDoTuoi = phimsua.GioiHanDoTuoi;
                if (phimsua.Poster != null)
                {
                    p.Poster = phimsua.Poster.ToArray();
                }
                else p.Poster = null;
                if (phimsua.MoTa != null)
                {
                    p.MoTa = phimsua.MoTa;
                }
                else p.MoTa = "";
                p.MaNSX = phimsua.MaNSX;
                db.SaveChanges();
                return 1;
            }
            return 0;
        }

        public List<ePhim> LayDanhSachPhim()
        {
            List<Phim> phims = db.Phims.ToList();
            List<ePhim> ePs = new List<ePhim>();
            foreach (Phim phim in phims)
            {
                ePhim eP = new ePhim();
                eP.MaPhim = phim.MaPhim;
                eP.MoTa = phim.MoTa;
                eP.TenPhim = phim.TenPhim;
                eP.NgayCongChieu = phim.NgayCongChieu;
                eP.TheLoai = phim.TheLoai;
                eP.NgonNgu = phim.NgonNgu;
                eP.ThoiLuong = phim.ThoiLuong;
                eP.GioiHanDoTuoi = phim.GioiHanDoTuoi;
                eP.DaoDien = phim.DaoDien;
                eP.DienVienChinh = phim.DienVienChinh;
                eP.Poster = phim.Poster;
                eP.MaNSX = phim.MaNSX;
                ePs.Add(eP);
            }
            return ePs;
        }

        public ePhim TimPhimTheoMa(string maphim)
        {
            Phim p = db.Phims.Where(x => x.MaPhim.Equals(maphim)).FirstOrDefault();
            if (p == null)
            {
                return null;
            }
            else
            {
                ePhim ep = new ePhim();
                ep.MaPhim = p.MaPhim;
                ep.TenPhim = p.TenPhim;
                ep.NgayCongChieu = p.NgayCongChieu;
                ep.TheLoai = p.TheLoai;
                ep.DaoDien = p.DaoDien;
                ep.DienVienChinh = p.DienVienChinh;
                ep.ThoiLuong = p.ThoiLuong;
                ep.NgonNgu = p.NgonNgu;
                ep.GioiHanDoTuoi = p.GioiHanDoTuoi;
                ep.Poster = p.Poster;
                ep.MoTa = p.MoTa;
                ep.MaNSX = p.MaNSX;
                return ep;
            }
        }

        public string PhatSinhMaPhim()
        {
            List<Phim> phims = db.Phims.ToList();
            Phim phim = phims.LastOrDefault();
            if (phim != null)
            {
                string ma = "Phim";
                int so = int.Parse(phim.MaPhim.Substring(4, 3));
                if ((so + 1) < 10)
                {
                    ma += "00" + (so + 1).ToString();
                }
                else if ((so + 1) < 100)
                {
                    ma += "0" + (so + 1).ToString();
                }
                else
                {
                    ma += (so + 1).ToString();
                }
                return ma;
            }
            else
                return "Phim001";
        }
        #endregion

        #region BUS_NhaSanXuat
        private bool KiemTraTrungMaNSX(string ma)
        {
            NhaSanXuat n = db.NhaSanXuats.Where(c => c.MaNSX.Equals(ma)).FirstOrDefault();
            if (n != null)
                return true;
            return false;
        }

        public int ThemNhaSanXuat(eNhaSanXuat nsxmoi)
        {
            if (KiemTraTrungMaNSX(nsxmoi.MaNSX))
            {
                return 0;
            }
            else
            {
                NhaSanXuat nsx = new NhaSanXuat();
                nsx.MaNSX = nsxmoi.MaNSX;
                nsx.TenNSX = nsxmoi.TenNSX;
                nsx.QuocGia = nsxmoi.QuocGia;
                db.NhaSanXuats.Add(nsx);
                db.SaveChanges();
                return 1;
            }
        }

        public int SuaNhaSanXuat(eNhaSanXuat nsxsua)
        {
            NhaSanXuat nsx = db.NhaSanXuats.Where(x => x.MaNSX.Equals(nsxsua.MaNSX)).FirstOrDefault();
            if (nsx != null)
            {
                nsx.TenNSX = nsxsua.TenNSX;
                nsx.QuocGia = nsxsua.QuocGia;
                db.SaveChanges();
                return 1;
            }
            return 0;
        }

        public List<eNhaSanXuat> LayDanhSachNhaSanXuat()
        {
            var listnsx = db.NhaSanXuats.ToList();
            List<eNhaSanXuat> listensx = new List<eNhaSanXuat>();
            foreach (NhaSanXuat nsx in listnsx)
            {
                eNhaSanXuat ensx = new eNhaSanXuat();
                ensx.MaNSX = nsx.MaNSX;
                ensx.TenNSX = nsx.TenNSX;
                ensx.QuocGia = nsx.QuocGia;
                listensx.Add(ensx);

            }
            return listensx;
        }

        public string PhatSinhMaNSX()
        {
            List<NhaSanXuat> NSXs = db.NhaSanXuats.ToList();
            NhaSanXuat nsx = NSXs.LastOrDefault();
            if (nsx != null)
            {
                string ma = "NSX";
                int so = int.Parse(nsx.MaNSX.Substring(3, 3));
                if ((so + 1) < 10)
                {
                    ma += "00" + (so + 1).ToString();
                }
                else if ((so + 1) < 100)
                {
                    ma += "0" + (so + 1).ToString();
                }
                else
                {
                    ma += (so + 1).ToString();
                }
                return ma;
            }
            else
                return "NSX001";
        }

        public String LayQuocGiaTheoMaNSX(String mansx)
        {
            NhaSanXuat nsx = db.NhaSanXuats.Where(x => x.MaNSX.Equals(mansx)).FirstOrDefault();
            if (nsx != null)
            {
                return nsx.QuocGia;
            }
            return "";
        }
        #endregion

        #region Thống kê
        public List<eThongKeDoanhThuVe> thongKeDoanhThuVe(DateTime tuNgay, DateTime denNgay)
        {

            var thongke = (from hd in db.HoaDons
                           where hd.NgayLap.Value >= tuNgay && hd.NgayLap.Value <= denNgay
                           select new
                           {
                               hd.MaHoaDon,
                               hd.NgayLap
                           }).ToList();
            List<eThongKeDoanhThuVe> listDT = new List<eThongKeDoanhThuVe>();
            foreach (var tk in thongke)
            {
                List<CT_HoaDon_DichVu> lCT = db.CT_HoaDon_DichVus.Where(c => c.MaHoaDon.Equals(tk.MaHoaDon)).ToList();
                List<Ve> lVe = db.Ves.Where(c => c.MaHoaDon.Equals(tk.MaHoaDon)).ToList();
                double tien = 0;
                if (lVe.Count > 0)
                    tien += lVe.Count * LayXuatChieuTheoMa(lVe[0].MaXuat).GiaVe;
                if (lCT.Count > 0)
                {
                    foreach (CT_HoaDon_DichVu ct in lCT)
                    {
                        tien += ct.SoLuong * LayDichVuTheoMa(ct.MaDichVu).DonGia;
                    }
                }
                eThongKeDoanhThuVe etkve = new eThongKeDoanhThuVe();
                etkve.MaHoaDon = tk.MaHoaDon;
                etkve.NgayLap = tk.NgayLap.Value;
                etkve.TongTien = tien;
                listDT.Add(etkve);
            }
            return listDT;
        }

        public List<eThongKeCTHD> thongKeCTHD(eThongKeDoanhThuVe hd)
        {
            List<eThongKeCTHD> listCT = new List<eThongKeCTHD>();
            List<CT_HoaDon_DichVu> lCT = db.CT_HoaDon_DichVus.Where(c => c.MaHoaDon.Equals(hd.MaHoaDon)).ToList();
            List<Ve> lVe = db.Ves.Where(c => c.MaHoaDon.Equals(hd.MaHoaDon)).ToList();
            if (lVe.Count > 0)
            {
                eThongKeCTHD ctve = new eThongKeCTHD();
                ctve.TenSanPham = TimPhimTheoMa(LayXuatChieuTheoMa(lVe[0].MaXuat).MaPhim).TenPhim;
                ctve.DonGia = LayXuatChieuTheoMa(lVe[0].MaXuat).GiaVe;
                ctve.SoLuong = lVe.Count;
                ctve.TongCong = lVe.Count * LayXuatChieuTheoMa(lVe[0].MaXuat).GiaVe;
                listCT.Add(ctve);
            }
            if (lCT.Count > 0)
            {
                foreach (CT_HoaDon_DichVu ct in lCT)
                {
                    eThongKeCTHD ctve = new eThongKeCTHD();
                    ctve.TenSanPham = LayDichVuTheoMa(ct.MaDichVu).TenDichVu;
                    ctve.DonGia = LayDichVuTheoMa(ct.MaDichVu).DonGia;
                    ctve.SoLuong = ct.SoLuong;
                    ctve.TongCong = ct.SoLuong * LayDichVuTheoMa(ct.MaDichVu).DonGia;
                    listCT.Add(ctve);
                }
            }
            return listCT;
        }
        #endregion
    }
}
