using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [DataContract]
    public class eXuatChieu
    {
        [DataMember]
        public string MaXuat { get; set; }

        [DataMember]
        public DateTime? ThoiDiem { get; set; }

        [DataMember]
        public double GiaVe { get; set; }

        [DataMember]
        public string MaPhim { get; set; }

        [DataMember]
        public string MaPhong { get; set; }
    }
}
