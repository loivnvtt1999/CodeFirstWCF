using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Entities
{
    [DataContract]
    public class ePhim
    {
        [DataMember]
        public string MaPhim { get; set; }

        [DataMember]
        public string TenPhim { get; set; }

        [DataMember]
        public DateTime? NgayCongChieu { get; set; }

        [DataMember]
        public string TheLoai { get; set; }

        [DataMember]
        public string DaoDien { get; set; }

        [DataMember]
        public string DienVienChinh { get; set; }

        [DataMember]
        public int ThoiLuong { get; set; }

        [DataMember]
        public string NgonNgu { get; set; }

        [DataMember]
        public string GioiHanDoTuoi { get; set; }

        [DataMember]
        public byte[] Poster { get; set; }

        [DataMember]
        public string MoTa { get; set; }

        [DataMember]
        public string MaNSX { get; set; }
    }
}
