namespace BeerUAPI.Types
{
    using System.Runtime.Serialization;

    [DataContract]
    public class Srm
    {
        /// <summary>
        ///     Gets or sets the id of srm.
        /// </summary>
        [DataMember]
        public int id { get; set; }

        /// Gets or sets the name of srm.
        [DataMember]
        public string name { get; set; }

        /// <summary>
        ///     Gets or sets the hex of srm.
        /// </summary>
        [DataMember]
        public string hex { get; set; }
    }
}