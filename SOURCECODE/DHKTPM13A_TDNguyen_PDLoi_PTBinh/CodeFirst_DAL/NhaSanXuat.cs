using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_DAL
{
    public class NhaSanXuat
    {
        [Key]
        public string MaNSX { get; set; }
        public string TenNSX { get; set; }
        public string QuocGia { get; set; }
    }
}
