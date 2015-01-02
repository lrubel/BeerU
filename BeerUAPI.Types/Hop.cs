using System.Runtime.Serialization;

namespace BeerUAPI.Types


{
    [DataContract]
    public class Hop
    {
        [DataMember]
        public int id { get; set; }

        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string description { get; set; }

        [DataMember]
        public string countryOfOrigin { get; set; }

        [DataMember]
        public int alphaAcidMin { get; set; }

        [DataMember]
        public int AlphaAcidMax { get; set; }

        [DataMember]
        public int betaAcidMin { get; set; }

        [DataMember]
        public int betaAcidMax { get; set; }

        [DataMember]
        public int humleneMin { get; set; }

        [DataMember]
        public int humuleneMax { get; set; }

        [DataMember]
        public int caryophylleneMin { get; set; }

        [DataMember]
        public int caryophylleneMax { get; set; }

        [DataMember]
        public int cohumuloneMin { get; set; }

        [DataMember]
        public int cohumuloneMax { get; set; }

        [DataMember]
        public int myrceneMin { get; set; }

        [DataMember]
        public int myrcenMax { get; set; }

        [DataMember]
        public int farneseneMin { get; set; }

        [DataMember]
        public int farneseneMax { get; set; }

        [DataMember]
        public string isNoble { get; set; }

        [DataMember]
        public string forBittering { get; set; }

        [DataMember]
        public string forFlavor { get; set; }

        [DataMember]
        public string forAroma { get; set; }

        [DataMember]
        public string category { get; set; }

        [DataMember]
        public string cateroryDisplay { get; set; }

        [DataMember]
        public Country country { get; set; }
    }
}