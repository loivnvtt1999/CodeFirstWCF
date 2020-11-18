using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_DAL
{
    class DuLieuBanDau
    {
        #region Nhập dữ liệu

        //        #region Nhập dữ liệu Nhà sản xuất
        //        context.NhaSanXuats.Add(new NhaSanXuat()
        //        {
        //            MaNSX = "NSX001",
        //                TenNSX = "Cailleach Production",
        //                QuocGia = "Mỹ"
        //            });

        //            context.NhaSanXuats.Add(new NhaSanXuat()
        //        {
        //            MaNSX = "NSX002",
        //                TenNSX = "Kadokawa",
        //                QuocGia = "Nhật Bản"
        //            });

        //            context.NhaSanXuats.Add(new NhaSanXuat()
        //        {
        //            MaNSX = "NSX003",
        //                TenNSX = "CJ Major Entertainment",
        //                QuocGia = "Thái Lan"
        //            });

        //            context.NhaSanXuats.Add(new NhaSanXuat()
        //        {
        //            MaNSX = "NSX004",
        //                TenNSX = "Shochiku",
        //                QuocGia = "Nhật Bản"
        //            });

        //            context.NhaSanXuats.Add(new NhaSanXuat()
        //        {
        //            MaNSX = "NSX005",
        //                TenNSX = "Dreamin’Dolphin Film",
        //                QuocGia = "Đức"
        //            });

        //            context.NhaSanXuats.Add(new NhaSanXuat()
        //        {
        //            MaNSX = "NSX006",
        //                TenNSX = "Moon & Deal Films",
        //                QuocGia = "Pháp"
        //            });

        //            context.NhaSanXuats.Add(new NhaSanXuat()
        //        {
        //            MaNSX = "NSX007",
        //                TenNSX = "Create NSW",
        //                QuocGia = "Úc"
        //            });
        //            #endregion

        //            #region Nhập dữ liệu Phim
        //            context.Phims.Add(new Phim()
        //        {
        //            MaPhim = "Phim001",
        //                TenPhim = "Mẹ Quỷ",
        //                NgayCongChieu = new DateTime(2020, 06, 19),
        //                TheLoai = "Kinh Dị",
        //                DaoDien = "Brett Pierce, Drew T. Pierce",
        //                DienVienChinh = "John-Paul Howard, Piper Curda, Jamison Jones,...",
        //                ThoiLuong = 95,
        //                NgonNgu = "Tiếng Anh - Phụ đề Tiếng Việt",
        //                GioiHanDoTuoi = "C18",
        //                Poster = null,
        //                MoTa = "The Wretched kể về câu chuyện của Ben – một thiếu niên đang cố gắng vượt qua nỗi mất mát sau cuộc ly dị của bố mẹ mình." +
        //                " Trong kỳ nghỉ hè cùng bố, Ben chạm trán với một mụ phù thủy chuyên bắt cóc trẻ con, hiện đang rình rập gia đình cậu bằng vẻ ngoài của một cô hàng xóm hiền lành." +
        //                " Là người duy nhất nhận ra sự bất thường từ người phụ nữ ấy, làm thế nào để Ben có thể tìm ra cách chống lại quỷ dữ?",
        //                MaNSX = "NSX001"
        //            });

        //            context.Phims.Add(new Phim()
        //        {
        //            MaPhim = "Phim002",
        //                TenPhim = "Fukushima50",
        //                NgayCongChieu = new DateTime(2020, 06, 12),
        //                TheLoai = "Tâm Lý",
        //                DaoDien = "Wakamatsu Setsuro",
        //                DienVienChinh = "Watanabe Ken, Sato Koichi,...",
        //                ThoiLuong = 121,
        //                NgonNgu = "Tiếng Nhật - Phụ đề Tiếng Việt",
        //                GioiHanDoTuoi = "C13",
        //                Poster = null,
        //                MoTa = "Năm 2011, trận động đất kinh hoàng 9.0 độ richter xảy ra tại Fukushima, theo sau đó là cơn sóng thần với độ cao khủng khiếp." +
        //                " Hai thảm họa kép phá hủy nhà máy điện hạt nhân Daiichi. Trong tình thế ngàn cân treo sợi tóc ấy, 50 công nhân tại nhà máy Daiichi đã bất chấp nguy hiểm ở lại," +
        //                " tìm cách làm nguội các lò phản ứng nhằm ngăn chặn sự cố hạt nhân kinh khủng trong lịch sử nhân loại",
        //                MaNSX = "NSX002"
        //            });

        //            context.Phims.Add(new Phim()
        //        {
        //            MaPhim = "Phim003",
        //                TenPhim = "Cơn mưa tình đầu",
        //                NgayCongChieu = new DateTime(2020, 06, 17),
        //                TheLoai = "Tình Cảm",
        //                DaoDien = "Thatchaphong Suphasri",
        //                DienVienChinh = "Thitipoom Techaapaikhun, Suttirak Subvijtra,...",
        //                ThoiLuong = 121,
        //                NgonNgu = "Tiếng Thái - Phụ đề Tiếng Việt",
        //                GioiHanDoTuoi = "C16",
        //                Poster = null,
        //                MoTa = "Thái Lan tiếp tục đem đến một câu chuyện tình yêu đầy lãng mạn, được tái hiện lại dựa trên bộ phim The Classic kinh điển của điện ảnh Hàn Quốc." +
        //                " Cơn Mưa Tình Đầu hứa hẹn sẽ đưa khán giả trải qua nhiều cung bậc khác nhau cùng những kỷ niệm đẹp nhất về mối tình đầu",
        //                MaNSX = "NSX003"
        //            });

        //            context.Phims.Add(new Phim()
        //        {
        //            MaPhim = "Phim004",
        //                TenPhim = "Lời nguyền Shirai",
        //                NgayCongChieu = new DateTime(2020, 06, 19),
        //                TheLoai = "Kinh Dị",
        //                DaoDien = "Otsuichi",
        //                DienVienChinh = "Manami Enosawa,Marie Iitoyo,...",
        //                ThoiLuong = 98,
        //                NgonNgu = "Tiếng Nhật - Phụ đề Tiếng Việt",
        //                GioiHanDoTuoi = "C16",
        //                Poster = null,
        //                MoTa = "Một lời nguyền bí ẩn khiến cho các nạn nhân mắc phải đều bị nổ tim và vỡ tan nhãn cầu. Thứ dịch bệnh này sẽ dần lây lan rộng hơn," +
        //                " liệu có cách nào để hóa giải lời nguyền hay không?",
        //                MaNSX = "NSX004"
        //            });

        //            context.Phims.Add(new Phim()
        //        {
        //            MaPhim = "Phim005",
        //                TenPhim = "Nhím, Sóc và viên đá thần kỳ",
        //                NgayCongChieu = new DateTime(2020, 06, 19),
        //                TheLoai = "Hoạt Hình",
        //                DaoDien = "Regina Welker, Mimi Maynard",
        //                DienVienChinh = "Danny Fehsenfeld, Asheley Bornancin,...",
        //                ThoiLuong = 82,
        //                NgonNgu = "Tiếng Anh - Phụ đề Tiếng Việt",
        //                GioiHanDoTuoi = "Không",
        //                Poster = null,
        //                MoTa = "Dựa trên tác phẩm ăn khách dành cho các độc giả nhí của tác giả Sebastian Lybeck," +
        //                " phim hoạt hình Latte & The Magic Waterstone mở ra không gian thiên nhiên đầy ắp những nhiệm màu cùng chuyến phiêu lưu đầy thử thách của đôi bạn Nhím Latte và Sóc Tjum vô cùng đáng yêu." +
        //                " Hành trình đi tìm viên đá thần kỳ này hứa hẹn sẽ vô cùng hấp dẫn.",
        //                MaNSX = "NSX005"
        //            });

        //            context.Phims.Add(new Phim()
        //        {
        //            MaPhim = "Phim006",
        //                TenPhim = "Ông Kẹ",
        //                NgayCongChieu = new DateTime(2020, 06, 26),
        //                TheLoai = "Kinh Dị",
        //                DaoDien = "Talal Selhami",
        //                DienVienChinh = "Sofiia Manousha, Younes Bouab,...",
        //                ThoiLuong = 78,
        //                NgonNgu = "Tiếng Anh - Phụ đề Tiếng Việt",
        //                GioiHanDoTuoi = "C18",
        //                Poster = null,
        //                MoTa = "Bốn người bạn thời thơ ấu có dịp hội ngộ sau hơn 20 năm." +
        //                " Tuy nhiên lần này thử thách mà họ gặp chính là đối đầu với một con quái vật khủng khiếp vốn được nhắc đến trong các truyền thuyết từ thời xa xưa.",
        //                MaNSX = "NSX006"
        //            });

        //            context.Phims.Add(new Phim()
        //        {
        //            MaPhim = "Phim007",
        //                TenPhim = "Sói 100%",
        //                NgayCongChieu = new DateTime(2020, 06, 26),
        //                TheLoai = "Hoạt Hình",
        //                DaoDien = "Alexs Stadermann",
        //                DienVienChinh = "IIai Swindells, Jai Courtney,...",
        //                ThoiLuong = 96,
        //                NgonNgu = "Tiếng Anh - Phụ đề Tiếng Việt",
        //                GioiHanDoTuoi = "Không",
        //                Poster = null,
        //                MoTa = "Một cậu bé có nhiệm vụ thừa kế và trở thành thú lĩnh của dòng sói quý tộc. Tuy nhiên một tai nạn tình cờ biến cậu thành chú chó lông xù." +
        //                " Nguy hiểm càng tăng khi giờ đây xuất hiện gã thợ săn người sói, liệu đàn sói và thủ lĩnh của chúng sẽ ra sao trước mối đe dọa này?",
        //                MaNSX = "NSX007"
        //            });
        //            #endregion

        //            #region Nhập dữ liệu Phòng chiếu
        //            context.PhongChieus.Add(new PhongChieu()
        //        {
        //            MaPhong = "Phong01",
        //                TenPhong = "Phòng 01"
        //            });

        //            context.PhongChieus.Add(new PhongChieu()
        //        {
        //            MaPhong = "Phong02",
        //                TenPhong = "Phòng 02"
        //            });
        //            #endregion

        //            #region Nhập dữ liệu Ghế ngồi
        //            GheNgoi tam = null;
        //            for (int i = 0; i< 2; i++)
        //            {
        //                for (int j = 0; j< 10; j++)
        //                {
        //                    switch (i)
        //                    {
        //                        case 0:
        //                            switch (j)
        //                            {
        //                                case 0:
        //                                    for (int k = 0; k< 15; k++)
        //                                    {
        //                                        tam = new GheNgoi();
        //        tam.MaPhong = "Phong01";
        //                                        tam.Hang = "A";
        //                                        tam.So = (k + 1).ToString();
        //        tam.MaGhe = tam.MaPhong + tam.Hang + tam.So;
        //                                        tam.TrangThai = "Có";
        //                                        context.GheNgois.Add(tam);
        //                                    }
        //                                    break;
        //                                case 1:
        //                                    for (int k = 0; k< 15; k++)
        //                                    {
        //                                        tam = new GheNgoi();
        //    tam.MaPhong = "Phong01";
        //                                        tam.Hang = "B";
        //                                        tam.So = (k + 1).ToString();
        //    tam.MaGhe = tam.MaPhong + tam.Hang + tam.So;
        //                                        tam.TrangThai = "Có";
        //                                        context.GheNgois.Add(tam);
        //                                    }
        //                                    break;
        //                                case 2:
        //                                    for (int k = 0; k< 15; k++)
        //                                    {
        //                                        tam = new GheNgoi();
        //tam.MaPhong = "Phong01";
        //                                        tam.Hang = "C";
        //                                        tam.So = (k + 1).ToString();
        //tam.MaGhe = tam.MaPhong + tam.Hang + tam.So;
        //                                        tam.TrangThai = "Có";
        //                                        context.GheNgois.Add(tam);
        //                                    }
        //                                    break;
        //                                case 3:
        //                                    for (int k = 0; k< 15; k++)
        //                                    {
        //                                        tam = new GheNgoi();
        //tam.MaPhong = "Phong01";
        //                                        tam.Hang = "D";
        //                                        tam.So = (k + 1).ToString();
        //tam.MaGhe = tam.MaPhong + tam.Hang + tam.So;
        //                                        tam.TrangThai = "Có";
        //                                        context.GheNgois.Add(tam);
        //                                    }
        //                                    break;
        //                                case 4:
        //                                    for (int k = 0; k< 15; k++)
        //                                    {
        //                                        tam = new GheNgoi();
        //tam.MaPhong = "Phong01";
        //                                        tam.Hang = "E";
        //                                        tam.So = (k + 1).ToString();
        //tam.MaGhe = tam.MaPhong + tam.Hang + tam.So;
        //                                        tam.TrangThai = "Có";
        //                                        context.GheNgois.Add(tam);
        //                                    }
        //                                    break;
        //                                case 5:
        //                                    for (int k = 0; k< 15; k++)
        //                                    {
        //                                        tam = new GheNgoi();
        //tam.MaPhong = "Phong01";
        //                                        tam.Hang = "F";
        //                                        tam.So = (k + 1).ToString();
        //tam.MaGhe = tam.MaPhong + tam.Hang + tam.So;
        //                                        tam.TrangThai = "Có";
        //                                        context.GheNgois.Add(tam);
        //                                    }
        //                                    break;
        //                                case 6:
        //                                    for (int k = 0; k< 15; k++)
        //                                    {
        //                                        tam = new GheNgoi();
        //tam.MaPhong = "Phong01";
        //                                        tam.Hang = "G";
        //                                        tam.So = (k + 1).ToString();
        //tam.MaGhe = tam.MaPhong + tam.Hang + tam.So;
        //                                        tam.TrangThai = "Có";
        //                                        context.GheNgois.Add(tam);
        //                                    }
        //                                    break;
        //                                case 7:
        //                                    for (int k = 0; k< 15; k++)
        //                                    {
        //                                        tam = new GheNgoi();
        //tam.MaPhong = "Phong01";
        //                                        tam.Hang = "H";
        //                                        tam.So = (k + 1).ToString();
        //tam.MaGhe = tam.MaPhong + tam.Hang + tam.So;
        //                                        tam.TrangThai = "Có";
        //                                        context.GheNgois.Add(tam);
        //                                    }
        //                                    break;
        //                                case 8:
        //                                    for (int k = 0; k< 15; k++)
        //                                    {
        //                                        tam = new GheNgoi();
        //tam.MaPhong = "Phong01";
        //                                        tam.Hang = "I";
        //                                        tam.So = (k + 1).ToString();
        //tam.MaGhe = tam.MaPhong + tam.Hang + tam.So;
        //                                        tam.TrangThai = "Có";
        //                                        context.GheNgois.Add(tam);
        //                                    }
        //                                    break;
        //                                case 9:
        //                                    for (int k = 0; k< 15; k++)
        //                                    {
        //                                        tam = new GheNgoi();
        //tam.MaPhong = "Phong01";
        //                                        tam.Hang = "J";
        //                                        tam.So = (k + 1).ToString();
        //tam.MaGhe = tam.MaPhong + tam.Hang + tam.So;
        //                                        tam.TrangThai = "Có";
        //                                        context.GheNgois.Add(tam);
        //                                    }
        //                                    break;
        //                            }
        //                            break;
        //                        case 1:
        //                            switch (j)
        //                            {
        //                                case 0:
        //                                    for (int k = 0; k< 15; k++)
        //                                    {
        //                                        tam = new GheNgoi();
        //tam.MaPhong = "Phong02";
        //                                        tam.Hang = "A";
        //                                        tam.So = (k + 1).ToString();
        //tam.MaGhe = tam.MaPhong + tam.Hang + tam.So;
        //                                        tam.TrangThai = "Có";
        //                                        context.GheNgois.Add(tam);
        //                                    }
        //                                    break;
        //                                case 1:
        //                                    for (int k = 0; k< 15; k++)
        //                                    {
        //                                        tam = new GheNgoi();
        //tam.MaPhong = "Phong02";
        //                                        tam.Hang = "B";
        //                                        tam.So = (k + 1).ToString();
        //tam.MaGhe = tam.MaPhong + tam.Hang + tam.So;
        //                                        tam.TrangThai = "Có";
        //                                        context.GheNgois.Add(tam);
        //                                    }
        //                                    break;
        //                                case 2:
        //                                    for (int k = 0; k< 15; k++)
        //                                    {
        //                                        tam = new GheNgoi();
        //tam.MaPhong = "Phong02";
        //                                        tam.Hang = "C";
        //                                        tam.So = (k + 1).ToString();
        //tam.MaGhe = tam.MaPhong + tam.Hang + tam.So;
        //                                        tam.TrangThai = "Có";
        //                                        context.GheNgois.Add(tam);
        //                                    }
        //                                    break;
        //                                case 3:
        //                                    for (int k = 0; k< 15; k++)
        //                                    {
        //                                        tam = new GheNgoi();
        //tam.MaPhong = "Phong02";
        //                                        tam.Hang = "D";
        //                                        tam.So = (k + 1).ToString();
        //tam.MaGhe = tam.MaPhong + tam.Hang + tam.So;
        //                                        tam.TrangThai = "Có";
        //                                        context.GheNgois.Add(tam);
        //                                    }
        //                                    break;
        //                                case 4:
        //                                    for (int k = 0; k< 15; k++)
        //                                    {
        //                                        tam = new GheNgoi();
        //tam.MaPhong = "Phong02";
        //                                        tam.Hang = "E";
        //                                        tam.So = (k + 1).ToString();
        //tam.MaGhe = tam.MaPhong + tam.Hang + tam.So;
        //                                        tam.TrangThai = "Có";
        //                                        context.GheNgois.Add(tam);
        //                                    }
        //                                    break;
        //                                case 5:
        //                                    for (int k = 0; k< 15; k++)
        //                                    {
        //                                        tam = new GheNgoi();
        //tam.MaPhong = "Phong02";
        //                                        tam.Hang = "F";
        //                                        tam.So = (k + 1).ToString();
        //tam.MaGhe = tam.MaPhong + tam.Hang + tam.So;
        //                                        tam.TrangThai = "Có";
        //                                        context.GheNgois.Add(tam);
        //                                    }
        //                                    break;
        //                                case 6:
        //                                    for (int k = 0; k< 15; k++)
        //                                    {
        //                                        tam = new GheNgoi();
        //tam.MaPhong = "Phong02";
        //                                        tam.Hang = "G";
        //                                        tam.So = (k + 1).ToString();
        //tam.MaGhe = tam.MaPhong + tam.Hang + tam.So;
        //                                        tam.TrangThai = "Có";
        //                                        context.GheNgois.Add(tam);
        //                                    }
        //                                    break;
        //                                case 7:
        //                                    for (int k = 0; k< 15; k++)
        //                                    {
        //                                        tam = new GheNgoi();
        //tam.MaPhong = "Phong02";
        //                                        tam.Hang = "H";
        //                                        tam.So = (k + 1).ToString();
        //tam.MaGhe = tam.MaPhong + tam.Hang + tam.So;
        //                                        tam.TrangThai = "Có";
        //                                        context.GheNgois.Add(tam);
        //                                    }
        //                                    break;
        //                                case 8:
        //                                    for (int k = 0; k< 15; k++)
        //                                    {
        //                                        tam = new GheNgoi();
        //tam.MaPhong = "Phong02";
        //                                        tam.Hang = "I";
        //                                        tam.So = (k + 1).ToString();
        //tam.MaGhe = tam.MaPhong + tam.Hang + tam.So;
        //                                        tam.TrangThai = "Có";
        //                                        context.GheNgois.Add(tam);
        //                                    }
        //                                    break;
        //                                case 9:
        //                                    for (int k = 0; k< 15; k++)
        //                                    {
        //                                        tam = new GheNgoi();
        //tam.MaPhong = "Phong02";
        //                                        tam.Hang = "J";
        //                                        tam.So = (k + 1).ToString();
        //tam.MaGhe = tam.MaPhong + tam.Hang + tam.So;
        //                                        tam.TrangThai = "Có";
        //                                        context.GheNgois.Add(tam);
        //                                    }
        //                                    break;
        //                            }
        //                            break;
        //                    }
        //                }
        //            }
        //            #endregion

        //            #region Nhập dữ liệu Khách hàng
        //            context.KhachHangs.Add(new KhachHang()
        //{
        //    MaKhachHang = "KH000",
        //                TenKhachHang = "Khách vãng lai",
        //                CMND = "",
        //                NgaySinh = new DateTime(2020, 06, 25),
        //                SDT = "",
        //                Email = ""
        //            });

        //            context.KhachHangs.Add(new KhachHang()
        //{
        //    MaKhachHang = "KH001",
        //                TenKhachHang = "Phạm Văn Hùng",
        //                CMND = "879900443",
        //                NgaySinh = new DateTime(1982, 05, 29),
        //                SDT = "0123456654",
        //                Email = "hungdouma@gmail.com"
        //            });

        //            context.KhachHangs.Add(new KhachHang()
        //{
        //    MaKhachHang = "KH002",
        //                TenKhachHang = "Lê Quang Trung",
        //                CMND = "123245987",
        //                NgaySinh = new DateTime(1999, 10, 10),
        //                SDT = "0125867674",
        //                Email = "trungrengoku@gmail.com"
        //            });

        //            context.KhachHangs.Add(new KhachHang()
        //{
        //    MaKhachHang = "KH003",
        //                TenKhachHang = "Nguyễn Đình Trí",
        //                CMND = "567388905",
        //                NgaySinh = new DateTime(1999, 12, 04),
        //                SDT = "0435645634",
        //                Email = "triakaza@gmail.com"
        //            });

        //            context.KhachHangs.Add(new KhachHang()
        //{
        //    MaKhachHang = "KH004",
        //                TenKhachHang = "Nguyễn Quang Đại",
        //                CMND = "907545334",
        //                NgaySinh = new DateTime(1993, 11, 06),
        //                SDT = "0881265745",
        //                Email = "daimuzan@gmail.com"
        //            });

        //            context.KhachHangs.Add(new KhachHang()
        //{
        //    MaKhachHang = "KH005",
        //                TenKhachHang = "Trần Minh Hằng",
        //                CMND = "234657635",
        //                NgaySinh = new DateTime(1997, 02, 12),
        //                SDT = "0116788799",
        //                Email = "hangshinobu@gmail.com"
        //            });

        //            context.KhachHangs.Add(new KhachHang()
        //{
        //    MaKhachHang = "KH006",
        //                TenKhachHang = "Phan Tấn Trung",
        //                CMND = "123456778",
        //                NgaySinh = new DateTime(1996, 11, 05),
        //                SDT = "0914549801",
        //                Email = "baroibeo@gmail.com"
        //            });
        //            #endregion

        //            #region Nhập dữ liệu Nhân viên
        //            context.NhanViens.Add(new NhanVien()
        //{
        //    MaNhanVien = "admin",
        //                TenNhanVien = "Quản Lý",
        //                CMND = "385757502",
        //                NgaySinh = new DateTime(1984, 02, 25),
        //                SDT = "0858899001",
        //                Email = "QuanLy@gmail.com",
        //                ChucVu = "Quản Lý",
        //                Anh = null,
        //                MatKhau = "admin"
        //            });

        //            context.NhanViens.Add(new NhanVien()
        //{
        //    MaNhanVien = "NV001",
        //                TenNhanVien = "Phạm Bình",
        //                CMND = "385757502",
        //                NgaySinh = new DateTime(1999, 04, 28),
        //                SDT = "0858899001",
        //                Email = "phambinh104855@gmail.com",
        //                ChucVu = "Bán vé",
        //                Anh = null,
        //                MatKhau = "12345678"
        //            });

        //            context.NhanViens.Add(new NhanVien()
        //{
        //    MaNhanVien = "NV002",
        //                TenNhanVien = "Phạm Đức Lợi",
        //                CMND = "123345678",
        //                NgaySinh = new DateTime(1999, 10, 04),
        //                SDT = "0937485768",
        //                Email = "loiphamducCNTT@gmail.com",
        //                ChucVu = "Bán vé",
        //                Anh = null,
        //                MatKhau = "12345678"
        //            });

        //            context.NhanViens.Add(new NhanVien()
        //{
        //    MaNhanVien = "NV003",
        //                TenNhanVien = "Trương Đình Nguyên",
        //                CMND = "385757502",
        //                NgaySinh = new DateTime(1999, 11, 28),
        //                SDT = "0983747586",
        //                Email = "nguyenrec1@gmail.com",
        //                ChucVu = "Dịch vụ",
        //                Anh = null,
        //                MatKhau = "12345678"
        //            });
        //            #endregion

        //            #region Nhập dữ liệu Dịch vụ
        //            context.DichVus.Add(new DichVu()
        //{
        //    MaDichVu = "DV001",
        //                TenDichVu = "Bắp",
        //                DonGia = 35000,
        //                Anh = null
        //            });

        //            context.DichVus.Add(new DichVu()
        //{
        //    MaDichVu = "DV002",
        //                TenDichVu = "Coca",
        //                DonGia = 30000,
        //                Anh = null
        //            });

        //            context.DichVus.Add(new DichVu()
        //{
        //    MaDichVu = "DV003",
        //                TenDichVu = "Pepsi",
        //                DonGia = 30000,
        //                Anh = null
        //            });

        //            context.DichVus.Add(new DichVu()
        //{
        //    MaDichVu = "DV004",
        //                TenDichVu = "Fanta",
        //                DonGia = 30000,
        //                Anh = null
        //            });
        //            #endregion

        //            #region Nhập dữ liệu xuất chiếu
        //            context.XuatChieus.Add(new XuatChieu()
        //{
        //    MaPhim = "Phim001",
        //                MaPhong = "Phong01",
        //                MaXuat = "Phong01_04072020_Suat01",
        //                GiaVe = 55000,
        //                ThoiDiem = new DateTime(2020, 07, 04, 10, 00, 00)
        //            });
        //            #endregion

        //            #region Nhập dữ liệu Hóa đơn
        //            context.HoaDons.Add(new HoaDon()
        //{
        //    MaHoaDon = "HD_04072020_0001",
        //                MaKhachHang = "KH000",
        //                MaNhanVien = "admin",
        //                NgayLap = new DateTime(2020, 07, 04, 09, 00, 00)
        //            });
        //            #endregion

        //            #region Nhập dữ liệu CT Dịch vụ
        //            context.CT_HoaDon_DichVus.Add(new CT_HoaDon_DichVu()
        //{
        //    MaHoaDon = "HD_04072020_0001",
        //                MaDichVu = "DV001",
        //                SoLuong = 2
        //            });
        //            #endregion

        //            #region Nhập dữ liệu vé
        //            context.Ves.Add(new Ve()
        //{
        //    MaHoaDon = "HD_04072020_0001",
        //                MaXuat = "Phong01_04072020_Suat01",
        //                VitriGhe = "G5"
        //            });

        //            context.Ves.Add(new Ve()
        //{
        //    MaHoaDon = "HD_04072020_0001",
        //                MaXuat = "Phong01_04072020_Suat01",
        //                VitriGhe = "G6"
        //            });
        //            #endregion

        #endregion
    }
}
