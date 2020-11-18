using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst_DAL
{
    public class GheNgoi
    {
        [Key]
        public string MaGhe { get; set; }
        public string Hang { get; set; }
        public string So { get; set; }
        public string TrangThai { get; set; }

        public string MaPhong { get; set; }

        public virtual PhongChieu PhongChieu { get; set; }
    }
}
