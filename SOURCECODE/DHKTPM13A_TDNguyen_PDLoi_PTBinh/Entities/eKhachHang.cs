using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Entities
{
    [DataContract]
    public class eKhachHang
    {
        [DataMember]
        public string MaKhachHang { get; set; }

        [DataMember]
        public string TenKhachHang { get; set; }

        [DataMember]
        public string CMND { get; set; }

        [DataMember]
        public DateTime? NgaySinh { get; set; }

        [DataMember]
        public string SDT { get; set; }

        [DataMember]
        public string Email { get; set; }
    }
}
