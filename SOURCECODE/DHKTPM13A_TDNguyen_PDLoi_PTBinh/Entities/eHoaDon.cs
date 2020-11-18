using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [DataContract]
    public class eHoaDon
    {
        [DataMember]
        public string MaHoaDon { get; set; }

        [DataMember]
        public DateTime? NgayLap { get; set; }

        [DataMember]
        public string MaKhachHang { get; set; }

        [DataMember]
        public string MaNhanVien { get; set; }
    }
}
