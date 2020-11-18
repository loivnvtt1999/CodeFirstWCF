using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Entities;

namespace WcfServicePhongChieuPhim
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IPhongChieu
    {
        #region BUS_NhanVien
        [OperationContract]
        bool KiemTraNhanVien(String ma);

        [OperationContract]
        eNhanVien KiemTraDangNhap(string taikhoan, string matkhau);

        [OperationContract]
        int ThemNhanVien(eNhanVien nvmoi);

        [OperationContract]
        int SuaNhanVien(eNhanVien nvsua);

        [OperationContract]
        List<eNhanVien> LayDanhSachNhanVien();

        [OperationContract]
        string PhatSinhMaNhanVien();

        [OperationContract]
        eNhanVien TimNhanVienTheoMa(string manhanvien);

        [OperationContract]
        void DatLaiMatKhau(string maNV);
        #endregion

        #region BUS_KhachHang
        [OperationContract]
        int ThemKhachHang(eKhachHang kh);

        [OperationContract]
        int SuaKhachHang(eKhachHang kh);

        [OperationContract]
        List<eKhachHang> LayDanhSachKhachHang();

        [OperationContract]
        string PhatSinhMaKhachHang();

        [OperationContract]
        eKhachHang TimKhachHangTheoMa(String ma);

        [OperationContract]
        eKhachHang TimKhachHangTheoSDT(String sdt);

        [OperationContract]
        eKhachHang TimKhachHangTheoTen(String ten);
        #endregion

        #region BUS_HoaDon
        [OperationContract]
        int ThemHoaDon(eHoaDon hoadonmoi);

        [OperationContract]
        List<eHoaDon> LayDanhSachHoaDonTheoThang(int month, int year);

        [OperationContract]
        string PhatSinhMaHoaDon();
        #endregion

        #region BUS_CT_HoaDon_DichVu
        [OperationContract]
        int ThemCT_DichVu(eCT_HoaDon_DichVu ctDVmoi);

        [OperationContract]
        List<eCT_HoaDon_DichVu> LayDanhSachDichVuTheoHoaDon(string mahoadon);
        #endregion

        #region BUS_DichVu
        [OperationContract]
        int ThemDichVu(eDichVu dichvumoi);

        [OperationContract]
        int SuaDichVu(eDichVu dichvusua);

        [OperationContract]
        List<eDichVu> LayDanhSachDichVu();

        [OperationContract]
        eDichVu LayDichVuTheoMa(String ma);

        [OperationContract]
        string PhatSinhMaDichVu();
        #endregion

        #region BUS_Ve
        [OperationContract]
        int ThemVe(eVe xcmoi);

        [OperationContract]
        List<eVe> LayDanhSachVeTheoXuatChieu(string maxuat);
        #endregion

        #region BUS_XuatChieu
        [OperationContract]
        int ThemXuatChieu(eXuatChieu xcmoi);

        [OperationContract]
        int SuaXuatChieu(eXuatChieu xcsua);

        [OperationContract]
        int XoaXuatChieu(eXuatChieu xcxoa);

        [OperationContract]
        eXuatChieu LayXuatChieuTheoMa(String maXuat);

        [OperationContract]
        string PhatSinhMaSuat(List<eXuatChieu> eXuatChieus, string phong, DateTime ngay);

        [OperationContract]
        List<eXuatChieu> LayDanhSachXuatChieuTheoNgayTheoPhong(string maphong, DateTime day);

        [OperationContract]
        List<eXuatChieu> LayDanhSachXuatChieuCuaPhimTheoNgay(string maphim, int day, int month, int year);
        #endregion

        #region BUS_PhongChieu
        [OperationContract]
        int ThemPhong(ePhongChieu phongmoi);

        [OperationContract]
        ePhongChieu LayPhongChieuTheoMa(String ma);

        [OperationContract]
        List<ePhongChieu> LayDanhSachPhongChieu();

        [OperationContract]
        string PhatSinhMaPhong();
        #endregion

        #region BUS_GheNgoi
        [OperationContract]
        List<eGheNgoi> LayDanhSachGheNgoiTheoPhong(string maphong);

        [OperationContract]
        bool CapNhatTrangThaiGhe(eGheNgoi ghe, string maphong);
        #endregion

        #region BUS_Phim
        [OperationContract]
        int ThemPhim(ePhim phimmoi);

        [OperationContract]
        int SuaPhim(ePhim phimsua);

        [OperationContract]
        List<ePhim> LayDanhSachPhim();

        [OperationContract]
        string PhatSinhMaPhim();

        [OperationContract]
        ePhim TimPhimTheoMa(string maphim);
        #endregion

        #region BUS_NhaSanXuat
        [OperationContract]
        int ThemNhaSanXuat(eNhaSanXuat nsxmoi);

        [OperationContract]
        int SuaNhaSanXuat(eNhaSanXuat nsxsua);

        [OperationContract]
        List<eNhaSanXuat> LayDanhSachNhaSanXuat();

        [OperationContract]
        string PhatSinhMaNSX();

        [OperationContract]
        String LayQuocGiaTheoMaNSX(String mansx);
        #endregion

        #region Thống kê
        [OperationContract]
        List<eThongKeDoanhThuVe> thongKeDoanhThuVe(DateTime tuNgay, DateTime denNgay);

        [OperationContract]
        List<eThongKeCTHD> thongKeCTHD(eThongKeDoanhThuVe hd);
        #endregion

        // TODO: Add your service operations here
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "WcfServicePhongChieuPhim.ContractType".
}
