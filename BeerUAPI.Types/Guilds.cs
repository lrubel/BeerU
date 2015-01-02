namespace BeerUAPI.Types
{
    using System.Runtime.Serialization;

    [DataContract]
    public class Guilds
    {
        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string website { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public Images images { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [DataMember]
        public string established { get; set; }
    }
}