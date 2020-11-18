using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_DAL
{
    public class KhachHang
    {
        [Key]
        public string MaKhachHang { get; set; }
        public string TenKhachHang { get; set; }
        public string CMND { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
    }
}
