using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_DAL
{
    public class DichVu
    {
        [Key]
        public string MaDichVu { get; set; }
        public string TenDichVu { get; set; }
        public double DonGia { get; set; }
        public byte[] Anh { get; set; }
    }
}
