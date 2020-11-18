using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [DataContract]
    public class eVe
    {
        [DataMember]
        public string MaHoaDon { get; set; }

        [DataMember]
        public string MaXuat { get; set; }

        [DataMember]
        public string VitriGhe { get; set; }
    }
}
