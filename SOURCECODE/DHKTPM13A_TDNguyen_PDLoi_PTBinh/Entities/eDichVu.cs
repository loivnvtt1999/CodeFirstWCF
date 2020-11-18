using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [DataContract]
    public class eDichVu
    {
        [DataMember]
        public string MaDichVu { get; set; }

        [DataMember]
        public string TenDichVu { get; set; }

        [DataMember]
        public double DonGia { get; set; }

        [DataMember]
        public byte[] Anh { get; set; }
    }
}
