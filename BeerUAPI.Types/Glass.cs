using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BeerUAPI.Types
{
    [DataContract]
    public class Glass
    {
        /// <summary>
        /// Gets or sets the id of Glass.  
        /// </summary>
        [DataMember]
        public int id { get; set; }

        /// <summary>
        /// Gets or sets the name of Images.  
        /// </summary>
        [DataMember]
        public string name { get; set; }
    }
}
