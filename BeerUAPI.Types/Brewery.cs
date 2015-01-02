namespace BeerUAPI.Types
{
    using System.Runtime.Serialization;

    [DataContract]
    public class Brewery
    {
        /// <summary>
        /// Gets or sets the id of Brewery. 
        /// </summary>
        [DataMember]
        public string id { get; set; }

        /// <summary>
        /// Gets or sets the description of Brewery.  
        /// </summary>
        [DataMember]
        public string description { get; set; }

        /// <summary>
        /// Gets or sets the name of Brewery.  
        /// </summary>
        [DataMember]
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the mailingListURl of Brewery. 
        /// </summary>
        [DataMember]
        public string mailingListURl { get; set; }

        /// <summary>
        /// Gets or sets the images of Brewery.  
        /// </summary>
        [DataMember]
        public Images images { get; set; }

        /// <summary>
        /// Gets or sets the website of Brewery.   
        /// </summary>
        [DataMember]
        public string website { get; set; }
    }
}