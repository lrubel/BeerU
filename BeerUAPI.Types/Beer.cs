using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BeerUAPI.Types
{
    [DataContract]
    public class Beer
    {
        [DataMember]
        public string name { get; set; }

        [DataMember]
        public string description { get; set; }

        [DataMember]
        public Style style { get; set; }

        public int Upc { get; set; }

        public string Brewery { get; set; }

        public int Standard { get; set; }

        public int UserRating { get; set; }

        [DataMember]
        public string currentPage { get; set; }

        [DataMember]
        public labels labels { get; set; }

        [DataMember]
        public string abv { get; set; }

       [DataMember]
        public List<Beer> data { get; set; }

        
    }
}
