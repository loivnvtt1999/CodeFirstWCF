using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst_DAL
{
    public class Ve
    {
        [Key]
        [Column(Order = 1)]
        public string MaHoaDon { get; set; }

        [Key]
        [Column(Order = 2)]
        public string MaXuat { get; set; }

        [Key]
        [Column(Order = 3)]
        public string VitriGhe { get; set; }

        public virtual HoaDon HoaDon { get; set; }
        public virtual XuatChieu XuatChieu { get; set; }
    }
}
