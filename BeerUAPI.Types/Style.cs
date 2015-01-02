using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BeerUAPI.Types
{
    [DataContract]
    public class Style
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public int categoryId { get; set; }

        [DataMember]
        public Category category { get; set; }
    }
}
