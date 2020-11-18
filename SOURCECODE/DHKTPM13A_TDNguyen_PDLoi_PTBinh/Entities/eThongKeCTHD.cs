using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [DataContract]
    public class eThongKeCTHD
    {
        [DataMember]
        public string TenSanPham { get; set; }

        [DataMember]
        public int SoLuong { get; set; }

        [DataMember]
        public double DonGia { get; set; }

        [DataMember]
        public double TongCong { get; set; }
    }
}
