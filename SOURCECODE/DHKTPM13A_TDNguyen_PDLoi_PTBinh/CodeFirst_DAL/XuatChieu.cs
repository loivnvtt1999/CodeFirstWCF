using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst_DAL
{
    public class XuatChieu
    {
        [Key]
        public string MaXuat { get; set; }
        public DateTime? ThoiDiem { get; set; }
        public double GiaVe { get; set; }

        public string MaPhim { get; set; }
        public string MaPhong { get; set; }

        public virtual Phim Phim { get; set; }
        public virtual PhongChieu PhongChieu { get; set; }

    }
}
