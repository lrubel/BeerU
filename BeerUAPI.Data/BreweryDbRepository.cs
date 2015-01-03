using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using BeerUAPI.Types;
using Newtonsoft.Json;

namespace BeerUAPI.Data
{
    public class BreweryDbRepository : BaseRepository, IBreweryDbRepository
    {
        public RootObject GetBeerByName(string name)
        {
            string url = BaseUrl + "beers?name="+name+ QueryStringKey;
            var myHttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            myHttpWebRequest.Method = Get;
            myHttpWebRequest.ContentType = ContentType;
            myHttpWebRequest.Credentials = new NetworkCredential(UserName, Password);
            //Get Response
            var myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(RootObject));
            object objResponse = jsonSerializer.ReadObject(myHttpWebResponse.GetResponseStream());
            RootObject jsonResponse
            = objResponse as RootObject;
            return jsonResponse;
        }

        public RootObject GetBeerByAbv(string abv)
        {
            string url = BaseUrl + "beers?abv=" + abv + QueryStringKey;
            var myHttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            myHttpWebRequest.Method = Get;
            myHttpWebRequest.ContentType = ContentType;
            myHttpWebRequest.Credentials = new NetworkCredential(UserName, Password);
            //Get Response
            var myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(RootObject));
            object objResponse = jsonSerializer.ReadObject(myHttpWebResponse.GetResponseStream());
            RootObject jsonResponse
            = objResponse as RootObject;
            return jsonResponse;
        }

        public RootObject GetBeerByYear(string year)
        {
            string url = BaseUrl + "beers?year=" + year + QueryStringKey;
            var myHttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            myHttpWebRequest.Method = Get;
            myHttpWebRequest.ContentType = ContentType;
            myHttpWebRequest.Credentials = new NetworkCredential(UserName, Password);
            //Get Response
            var myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(RootObject));
            object objResponse = jsonSerializer.ReadObject(myHttpWebResponse.GetResponseStream());
            RootObject jsonResponse
            = objResponse as RootObject;
            return jsonResponse;
        }

        public List<Beer> GetBeerByStyle(string styleId)
        {
            var beers = new List<Beer>();
            string url = BaseUrl + "beers?styleId=" + styleId + QueryStringKey;
            var myHttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            myHttpWebRequest.Method = Get;
            myHttpWebRequest.ContentType = ContentType;
            myHttpWebRequest.Credentials = new NetworkCredential(UserName, Password);
            //Get Response
            var myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(RootObject));
            object objResponse = jsonSerializer.ReadObject(myHttpWebResponse.GetResponseStream());
            RootObject jsonResponse
            = objResponse as RootObject;


            foreach (var dataModel in jsonResponse.data.Where(x => x.labels != null))
            {
                beers.Add(new Beer
                {
                    abv = dataModel.abv,
                    name = dataModel.name,
                    isOrganic = dataModel.isOrganic,
                    labels = new labels
                    {
                        icon = dataModel.labels.icon,
                        large = dataModel.labels.large,
                        medium = dataModel.labels.medium
                    }
                });
            }
            return beers;
        }


        public RootObject GetBeerByPageNumber(string p)
        {
            string url = BaseUrl + "beers?p=" + p + QueryStringKey;
            var myHttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            myHttpWebRequest.Method = Get;
            myHttpWebRequest.ContentType = ContentType;
            myHttpWebRequest.Credentials = new NetworkCredential(UserName, Password);
            //Get Response
            var myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(RootObject));
            object objResponse = jsonSerializer.ReadObject(myHttpWebResponse.GetResponseStream());
            RootObject jsonResponse
            = objResponse as RootObject;
            return jsonResponse;
        }

    }
}
