using System.Runtime.Serialization;

namespace BeerUAPI.Types
{
    [DataContract]
    public class Beer
    {
        /// <summary>
        /// Gets or sets the Id of Beer.
        /// </summary>
        [DataMember]
        public int id { get; set; }

        /// <summary>
        /// Gets or sets the Name of Beer.
        /// </summary>
        [DataMember]
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the Description of Beer.
        /// </summary>
        [DataMember]
        public string description { get; set; }

        /// <summary>
        /// Gets or sets the FoodPairings of Beer.
        /// </summary>
        [DataMember]
        public string foodPairings { get; set; }

        /// <summary>
        /// Gets or sets the OriginalGravity of Beer. 
        /// </summary>
        [DataMember]
        public string originalGravity { get; set; }
        
        /// <summary>
        /// Gets or sets the Style of Beer. 
        /// </summary>
        [DataMember]
        public Style style { get; set; }

        /// <summary>
        /// Gets or sets the Abv of Beer.
        /// </summary>
        public string abv { get; set; }

        /// <summary>
        /// Gets or sets the Id of Beer. 
        /// </summary>
        [DataMember]
        public string ibu { get; set; }

        /// <summary>
        /// Gets or sets the Glass of Beer.  
        /// </summary>
        [DataMember]
        public Glass glass { get; set; }

        /// <summary>
        /// Gets or sets the IsOrganic of Beer. 
        /// </summary>
        [DataMember]
        public string isOrganic { get; set; }

        /// <summary>
        /// Gets or sets the ServingTemperature of Beer.  
        /// </summary>
        [DataMember]
        public string servingTemperature { get; set; }

        /// <summary>
        /// Gets or sets the ServingTemperatureDisplay of Beer.   
        /// </summary>
        [DataMember]
        public string servingTemperatureDisplay { get; set; }

        /// <summary>
        /// Gets or sets the Status of Beer.    
        /// </summary>
        [DataMember]
        public string status { get; set; }

        /// <summary>
        /// Gets or sets the StatusDisplay of Beer.     
        /// </summary>
        [DataMember]
        public string statusDisplay { get; set; }

        /// <summary>
        /// Gets or sets the Available of Beer.      
        /// </summary>
        //[DataMember]
        //public available available { get; set; }

        ///// <summary>
        ///// Gets or sets the BeerVariation of Beer.     
        ///// </summary>
        //[DataMember]
        //public beerVariation beerVariation { get; set; }

        /// <summary>
        /// Gets or sets the Year of Beer.      
        /// </summary>
        [DataMember]
        public string year { get; set; }

        /// <summary>
        /// Gets or sets the Labels of Beer.       
        /// </summary>
        [DataMember]
        public labels labels { get; set; }
    }
}