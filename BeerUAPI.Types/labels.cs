using System.Runtime.Serialization;

namespace BeerUAPI.Types
{
    [DataContract]
    public class labels
    {
        [DataMember]
        public string icon { get; set; }

        [DataMember]
        public string medium { get; set; }

        [DataMember]
        public string large { get; set; }
    }
}