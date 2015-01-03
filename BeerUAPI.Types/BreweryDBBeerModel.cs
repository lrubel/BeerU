using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerUAPI.Types
{
    public class Labels
    {
        public string medium { get; set; }
        public string large { get; set; }
        public string icon { get; set; }
    }

    public class Available
    {
        public string description { get; set; }
        public string name { get; set; }
    }


    public class Datum
    {
        public string servingTemperatureDisplay { get; set; }
        public Labels labels { get; set; }
        public Style style { get; set; }
        public string status { get; set; }
        public string srmId { get; set; }
        public string beerVariationId { get; set; }
        public string statusDisplay { get; set; }
        public string foodPairings { get; set; }
        public List<object> srm { get; set; }
        public string updateDate { get; set; }
        public string servingTemperature { get; set; }
        public int availableId { get; set; }
        public List<object> beerVariation { get; set; }
        public string abv { get; set; }
        public string year { get; set; }
        public string name { get; set; }
        public string id { get; set; }
        public string originalGravity { get; set; }
        public int styleId { get; set; }
        public string ibu { get; set; }
        public int glasswareId { get; set; }
        public string isOrganic { get; set; }
        public string createDate { get; set; }
        public Available available { get; set; }
        public Glass glass { get; set; }
        public string description { get; set; }
    }

    public class RootObject
    {
        public string status { get; set; }
        public int numberOfPages { get; set; }
        public List<Datum> data { get; set; }
        public int currentPage { get; set; }
    }
}
