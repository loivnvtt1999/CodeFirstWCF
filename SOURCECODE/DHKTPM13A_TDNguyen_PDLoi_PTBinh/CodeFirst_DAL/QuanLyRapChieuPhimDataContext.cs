namespace CodeFirst_DAL
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class QuanLyRapChieuPhimDataContext : DbContext
    {
        // Your context has been configured to use a 'QuanLyRapChieuPhimDataContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CodeFirst_DAL.QuanLyRapChieuPhimDataContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'QuanLyRapChieuPhimDataContext' 
        // connection string in the application configuration file.
        public QuanLyRapChieuPhimDataContext()
            : base("QuanLyRapChieuPhim")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<DichVu> DichVus { get; set; }
        public virtual DbSet<NhaSanXuat> NhaSanXuats { get; set; }
        public virtual DbSet<PhongChieu> PhongChieus { get; set; }
        public virtual DbSet<Phim> Phims { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<XuatChieu> XuatChieus { get; set; }
        public virtual DbSet<GheNgoi> GheNgois { get; set; }
        public virtual DbSet<Ve> Ves { get; set; }
        public virtual DbSet<CT_HoaDon_DichVu> CT_HoaDon_DichVus { get; set; }

    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}