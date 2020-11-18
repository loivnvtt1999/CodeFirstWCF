using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_DAL
{
    public class CT_HoaDon_DichVu
    {
        [Key]
        [Column(Order = 1)]
        public string MaHoaDon { get; set; }

        [Key]
        [Column(Order = 2)]
        public string MaDichVu { get; set; }
        public int SoLuong { get; set; }

        public virtual HoaDon HoaDon { get; set; }
        public virtual DichVu DichVu { get; set; }
    }
}
