namespace BeerUAPI.Types {

    using System.Runtime.Serialization;

    [DataContract]
    public class Adjunct
    {
        /// <summary>
        /// Gets or sets the Id of Adjunct.
        /// </summary>
        [DataMember] 
        public int id { get; set; }

        /// <summary>
        /// Gets or sets the Name of Adjunct.
        /// </summary>
        [DataMember]
        public string name { get; set; }

        /// <summary>
        /// Gets or sets the Description of Adjunct.
        /// </summary>
        [DataMember]
        public string description { get; set; }

        /// <summary>
        /// Gets or sets the Category of Adjunct.
        /// </summary>
        [DataMember]
        public string category { get; set; }

        /// <summary>
        /// Gets or sets the CategoryDisplay of Adjunct.
        /// </summary>
        [DataMember]
        public string categoryDisplay { get; set; }
    }
}