using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [DataContract]
    public class eGheNgoi
    {
        [DataMember]
        public string MaGhe { get; set; }

        [DataMember]
        public string Hang { get; set; }

        [DataMember]
        public string So { get; set; }

        [DataMember]
        public string TrangThai { get; set; }

        [DataMember]
        public string MaPhong { get; set; }
    }
}
