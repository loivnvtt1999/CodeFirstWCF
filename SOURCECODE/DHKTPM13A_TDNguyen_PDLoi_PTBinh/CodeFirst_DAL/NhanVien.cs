using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_DAL
{
    public class NhanVien
    {
        [Key]
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string CMND { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string SDT { get; set; }
        public string Email { get; set; }
        public string ChucVu { get; set; }
        public byte[] Anh { get; set; }
        public string MatKhau { get; set; }
    }
}
