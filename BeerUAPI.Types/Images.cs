namespace BeerUAPI.Types
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Threading.Tasks;

    [DataContract]
    public class Images
    {
        /// <summary>
        /// Gets or sets the medium of Images. 
        /// </summary>
        [DataMember]
        public string medium { get; set; }

        /// <summary>
        /// Gets or sets the large of Images. 
        /// </summary>
        [DataMember]
        public string large { get; set; }

        /// <summary>
        /// Gets or sets the icon of Images. 
        /// </summary>
        [DataMember]
        public string icon { get; set; }
    }
}
