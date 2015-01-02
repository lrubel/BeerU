namespace BeerUAPI.Types
{
    using System.Runtime.Serialization;

    [DataContract]
    public class FluidSize
    {
        /// <summary>
        /// Gets or sets the volume of Fluidsize. 
        /// </summary>
        [DataMember]
        public string volume { get; set; }
        
        /// <summary>
        /// Gets or sets the quantity of Fluidsize. 
        /// </summary>
        [DataMember]
        public string quantity { get; set; }

        /// <summary>
        /// Gets or sets the id of Fluidsize. 
        /// </summary>
        [DataMember]
        public int id { get; set; }

        /// <summary>
        /// Gets or sets the volumeDisplay of Fluidsize. 
        /// </summary>
        [DataMember]
        public string volumeDisplay { get; set; }
    }
}