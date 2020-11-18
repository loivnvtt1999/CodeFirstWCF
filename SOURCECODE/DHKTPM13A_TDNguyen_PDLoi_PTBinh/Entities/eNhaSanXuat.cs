using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Entities
{
    [DataContract]
    public class eNhaSanXuat
    {
        [DataMember]
        public string MaNSX { get; set; }

        [DataMember]
        public string TenNSX { get; set; }

        [DataMember]
        public string QuocGia { get; set; }
    }
}
