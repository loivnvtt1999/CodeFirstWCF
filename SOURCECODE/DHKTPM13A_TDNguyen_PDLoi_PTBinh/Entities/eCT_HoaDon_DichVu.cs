using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    [DataContract]
    public class eCT_HoaDon_DichVu
    {
        [DataMember]
        public string MaHoaDon { get; set; }

        [DataMember]
        public string MaDichVu { get; set; }

        [DataMember]
        public int SoLuong { get; set; }
    }
}
