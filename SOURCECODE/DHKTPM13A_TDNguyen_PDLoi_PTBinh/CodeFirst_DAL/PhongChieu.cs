using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CodeFirst_DAL
{
    public class PhongChieu
    {
        public PhongChieu()
        {
            XuatChieus = new HashSet<XuatChieu>();
            GheNgois = new HashSet<GheNgoi>();
        }
        [Key]
        public string MaPhong { get; set; }
        public string TenPhong { get; set; }

        public virtual ICollection<XuatChieu> XuatChieus { get; set; }
        public virtual ICollection<GheNgoi> GheNgois { get; set; }
    }
}
