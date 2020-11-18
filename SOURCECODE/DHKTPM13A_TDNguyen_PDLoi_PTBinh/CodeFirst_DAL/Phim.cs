using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst_DAL
{
    public class Phim
    {
        public Phim()
        {
            XuatChieus = new HashSet<XuatChieu>();
        }
        [Key]
        public string MaPhim { get; set; }
        public string TenPhim { get; set; }
        public DateTime? NgayCongChieu { get; set; }
        public string TheLoai { get; set; }
        public string DaoDien { get; set; }
        public string DienVienChinh { get; set; }
        public int ThoiLuong { get; set; }
        public string NgonNgu { get; set; }
        public string GioiHanDoTuoi { get; set; }
        public byte[] Poster { get; set; }
        public string MoTa { get; set; }

        public string MaNSX { get; set; }

        public virtual NhaSanXuat NhaSanXuat { get; set; }
        public virtual ICollection<XuatChieu> XuatChieus { get; set; }
    }
}
