namespace BeerUAPI.Types
{
    using System.Runtime.Serialization;

    [DataContract]
    public class Country
    {
        /// <summary>
        ///     Gets or sets the isoCode of country. 
        /// </summary>
        [DataMember]
        public string isoCode { get; set; }

        /// <summary>
        ///     Gets or sets the name of country.  
        /// </summary>
        [DataMember]
        public string name { get; set; }

        /// <summary>
        ///     Gets or sets the displayName of country.  
        /// </summary>
        [DataMember]
        public string displayName { get; set; }

        /// <summary>
        ///     Gets or sets the isoThree of country.  
        /// </summary>
        [DataMember]
        public string isoThree { get; set; }

        /// <summary>
        ///     Gets or sets the numberCode of country.  
        /// </summary>
        [DataMember]
        public int numberCode { get; set; }
    }
}