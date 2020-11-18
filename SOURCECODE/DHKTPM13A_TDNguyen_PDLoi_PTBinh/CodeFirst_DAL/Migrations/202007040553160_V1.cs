namespace CodeFirst_DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class V1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CT_HoaDon_DichVu",
                c => new
                    {
                        MaHoaDon = c.String(nullable: false, maxLength: 128),
                        MaDichVu = c.String(nullable: false, maxLength: 128),
                        SoLuong = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.MaHoaDon, t.MaDichVu })
                .ForeignKey("dbo.DichVus", t => t.MaDichVu, cascadeDelete: true)
                .ForeignKey("dbo.HoaDons", t => t.MaHoaDon, cascadeDelete: true)
                .Index(t => t.MaHoaDon)
                .Index(t => t.MaDichVu);
            
            CreateTable(
                "dbo.DichVus",
                c => new
                    {
                        MaDichVu = c.String(nullable: false, maxLength: 128),
                        TenDichVu = c.String(),
                        DonGia = c.Double(nullable: false),
                        Anh = c.Binary(),
                    })
                .PrimaryKey(t => t.MaDichVu);
            
            CreateTable(
                "dbo.HoaDons",
                c => new
                    {
                        MaHoaDon = c.String(nullable: false, maxLength: 128),
                        NgayLap = c.DateTime(),
                        MaKhachHang = c.String(maxLength: 128),
                        MaNhanVien = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.MaHoaDon)
                .ForeignKey("dbo.KhachHangs", t => t.MaKhachHang)
                .ForeignKey("dbo.NhanViens", t => t.MaNhanVien)
                .Index(t => t.MaKhachHang)
                .Index(t => t.MaNhanVien);
            
            CreateTable(
                "dbo.KhachHangs",
                c => new
                    {
                        MaKhachHang = c.String(nullable: false, maxLength: 128),
                        TenKhachHang = c.String(),
                        CMND = c.String(),
                        NgaySinh = c.DateTime(),
                        SDT = c.String(),
                        Email = c.String(),
                    })
                .PrimaryKey(t => t.MaKhachHang);
            
            CreateTable(
                "dbo.NhanViens",
                c => new
                    {
                        MaNhanVien = c.String(nullable: false, maxLength: 128),
                        TenNhanVien = c.String(),
                        CMND = c.String(),
                        NgaySinh = c.DateTime(),
                        SDT = c.String(),
                        Email = c.String(),
                        ChucVu = c.String(),
                        Anh = c.Binary(),
                        MatKhau = c.String(),
                    })
                .PrimaryKey(t => t.MaNhanVien);
            
            CreateTable(
                "dbo.GheNgois",
                c => new
                    {
                        MaGhe = c.String(nullable: false, maxLength: 128),
                        Hang = c.String(),
                        So = c.String(),
                        TrangThai = c.String(),
                        MaPhong = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.MaGhe)
                .ForeignKey("dbo.PhongChieux", t => t.MaPhong)
                .Index(t => t.MaPhong);
            
            CreateTable(
                "dbo.PhongChieux",
                c => new
                    {
                        MaPhong = c.String(nullable: false, maxLength: 128),
                        TenPhong = c.String(),
                    })
                .PrimaryKey(t => t.MaPhong);
            
            CreateTable(
                "dbo.XuatChieux",
                c => new
                    {
                        MaXuat = c.String(nullable: false, maxLength: 128),
                        ThoiDiem = c.DateTime(),
                        GiaVe = c.Double(nullable: false),
                        MaPhim = c.String(maxLength: 128),
                        MaPhong = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.MaXuat)
                .ForeignKey("dbo.Phims", t => t.MaPhim)
                .ForeignKey("dbo.PhongChieux", t => t.MaPhong)
                .Index(t => t.MaPhim)
                .Index(t => t.MaPhong);
            
            CreateTable(
                "dbo.Phims",
                c => new
                    {
                        MaPhim = c.String(nullable: false, maxLength: 128),
                        TenPhim = c.String(),
                        NgayCongChieu = c.DateTime(),
                        TheLoai = c.String(),
                        DaoDien = c.String(),
                        DienVienChinh = c.String(),
                        ThoiLuong = c.Int(nullable: false),
                        NgonNgu = c.String(),
                        GioiHanDoTuoi = c.String(),
                        Poster = c.Binary(),
                        MoTa = c.String(),
                        MaNSX = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.MaPhim)
                .ForeignKey("dbo.NhaSanXuats", t => t.MaNSX)
                .Index(t => t.MaNSX);
            
            CreateTable(
                "dbo.NhaSanXuats",
                c => new
                    {
                        MaNSX = c.String(nullable: false, maxLength: 128),
                        TenNSX = c.String(),
                        QuocGia = c.String(),
                    })
                .PrimaryKey(t => t.MaNSX);
            
            CreateTable(
                "dbo.Ves",
                c => new
                    {
                        MaHoaDon = c.String(nullable: false, maxLength: 128),
                        MaXuat = c.String(nullable: false, maxLength: 128),
                        VitriGhe = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.MaHoaDon, t.MaXuat, t.VitriGhe })
                .ForeignKey("dbo.HoaDons", t => t.MaHoaDon, cascadeDelete: true)
                .ForeignKey("dbo.XuatChieux", t => t.MaXuat, cascadeDelete: true)
                .Index(t => t.MaHoaDon)
                .Index(t => t.MaXuat);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ves", "MaXuat", "dbo.XuatChieux");
            DropForeignKey("dbo.Ves", "MaHoaDon", "dbo.HoaDons");
            DropForeignKey("dbo.XuatChieux", "MaPhong", "dbo.PhongChieux");
            DropForeignKey("dbo.XuatChieux", "MaPhim", "dbo.Phims");
            DropForeignKey("dbo.Phims", "MaNSX", "dbo.NhaSanXuats");
            DropForeignKey("dbo.GheNgois", "MaPhong", "dbo.PhongChieux");
            DropForeignKey("dbo.CT_HoaDon_DichVu", "MaHoaDon", "dbo.HoaDons");
            DropForeignKey("dbo.HoaDons", "MaNhanVien", "dbo.NhanViens");
            DropForeignKey("dbo.HoaDons", "MaKhachHang", "dbo.KhachHangs");
            DropForeignKey("dbo.CT_HoaDon_DichVu", "MaDichVu", "dbo.DichVus");
            DropIndex("dbo.Ves", new[] { "MaXuat" });
            DropIndex("dbo.Ves", new[] { "MaHoaDon" });
            DropIndex("dbo.Phims", new[] { "MaNSX" });
            DropIndex("dbo.XuatChieux", new[] { "MaPhong" });
            DropIndex("dbo.XuatChieux", new[] { "MaPhim" });
            DropIndex("dbo.GheNgois", new[] { "MaPhong" });
            DropIndex("dbo.HoaDons", new[] { "MaNhanVien" });
            DropIndex("dbo.HoaDons", new[] { "MaKhachHang" });
            DropIndex("dbo.CT_HoaDon_DichVu", new[] { "MaDichVu" });
            DropIndex("dbo.CT_HoaDon_DichVu", new[] { "MaHoaDon" });
            DropTable("dbo.Ves");
            DropTable("dbo.NhaSanXuats");
            DropTable("dbo.Phims");
            DropTable("dbo.XuatChieux");
            DropTable("dbo.PhongChieux");
            DropTable("dbo.GheNgois");
            DropTable("dbo.NhanViens");
            DropTable("dbo.KhachHangs");
            DropTable("dbo.HoaDons");
            DropTable("dbo.DichVus");
            DropTable("dbo.CT_HoaDon_DichVu");
        }
    }
}
