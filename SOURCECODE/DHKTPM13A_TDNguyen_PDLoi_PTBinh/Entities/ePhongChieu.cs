using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [DataContract]
    public class ePhongChieu
    {
        [DataMember]
        public string MaPhong { get; set; }

        [DataMember]
        public string TenPhong { get; set; }
    }
}
