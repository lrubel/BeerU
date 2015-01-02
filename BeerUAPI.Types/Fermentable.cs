using System.Runtime.Serialization;

namespace BeerUAPI.Types
{
    [DataContract]
    public class Fermentable
    {
        /// <summary>
        ///     Gets or sets the id of Fermentable. 
        /// </summary>
        [DataMember]
        public int id { get; set; }

        /// <summary>
        ///     Gets or sets the name of Fermentable.  
        /// </summary>
        [DataMember]
        public string name { get; set; }

        /// <summary>
        ///     Gets or sets the description of Fermentable.  
        /// </summary>
        [DataMember]
        public string description { get; set; }

        /// <summary>
        ///     Gets or sets the countryOfOrigin of Fermentable.  
        /// </summary>
        [DataMember]
        public string countryOfOrigin { get; set; }

        /// <summary>
        ///     Gets or sets the srmId of Fermentable.  
        /// </summary>
        [DataMember]
        public int srmId { get; set; }

        /// <summary>
        ///     Gets or sets the srmPrecise of Fermentable.  
        /// </summary>
        [DataMember]
        public int srmPrecise { get; set; }

        /// <summary>
        ///     Gets or sets the moistureContent of Fermentable.  
        /// </summary>
        [DataMember]
        public int moistureContent { get; set; }

        /// <summary>
        ///     Gets or sets the dryYield of Fermentable. 
        /// </summary>
        [DataMember]
        public int dryYield { get; set; }

        /// <summary>
        ///     Gets or sets the potential of Fermentable.  
        /// </summary>
        [DataMember]
        public int potential { get; set; }

        /// <summary>
        ///     Gets or sets the protein of Fermentable. 
        /// </summary>
        [DataMember]
        public int protein { get; set; }

        /// <summary>
        ///     Gets or sets the maxInBatch of Fermentable. 
        /// </summary>
        [DataMember]
        public int maxInBatch { get; set; }

        /// <summary>
        ///     Gets or sets the requiresMashing of Fermentable. 
        /// </summary>
        [DataMember]
        public string requiresMashing { get; set; }

        /// <summary>
        ///     Gets or sets the category of Fermentable.  
        /// </summary>
        [DataMember]
        public string category { get; set; }

        /// <summary>
        ///     Gets or sets the country of Fermentable. 
        /// </summary>
        [DataMember]
        public Country country { get; set; }

        /// <summary>
        ///     Gets or sets the characteristics of Fermentable. 
        /// </summary>
        [DataMember]
        public string characteristics { get; set; }
    }
}