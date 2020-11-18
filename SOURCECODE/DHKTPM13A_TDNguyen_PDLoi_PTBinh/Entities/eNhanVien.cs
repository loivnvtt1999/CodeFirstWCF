using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [DataContract]
    public class eNhanVien
    {
        [DataMember]
        public string MaNhanVien { get; set; }

        [DataMember]
        public string TenNhanVien { get; set; }

        [DataMember]
        public string CMND { get; set; }

        [DataMember]
        public DateTime? NgaySinh { get; set; }

        [DataMember]
        public string SDT { get; set; }

        [DataMember]
        public string Email { get; set; }

        [DataMember]
        public string ChucVu { get; set; }

        [DataMember]
        public byte[] Anh { get; set; }

        [DataMember]
        public string MatKhau { get; set; }
    }
}
