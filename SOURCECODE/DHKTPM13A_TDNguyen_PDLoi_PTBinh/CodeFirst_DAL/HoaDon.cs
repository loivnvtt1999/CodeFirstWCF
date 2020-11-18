using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_DAL
{
    public class HoaDon
    {
        [Key]
        public string MaHoaDon { get; set; }
        public DateTime? NgayLap { get; set; }

        public string MaKhachHang { get; set; }
        public string MaNhanVien { get; set; }

        public virtual KhachHang KhachHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
