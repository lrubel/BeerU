using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;
using BeerUAPI.Types;
using Microsoft.Owin.Security.Provider;
using Newtonsoft.Json;

namespace BeerUAPI.Controllers
{
    public class BreweryDBController : BaseController
    {
        // GET: BreweryDB



        public Beer GetBeer(string name)
        {
            string url = "https://api.brewerydb.com/v2/beers?name="+name+"&key=8e74edb7320a50dc432315543c2de1f8";
            var myHttpWebRequest = (HttpWebRequest) WebRequest.Create(url);
            myHttpWebRequest.Method = "GET";
            myHttpWebRequest.ContentType = "application/json";
            myHttpWebRequest.Credentials = new NetworkCredential("jake_nyenhuis@live.com", "BeerU10");
            //Get Response
            var myHttpWebResponse = (HttpWebResponse) myHttpWebRequest.GetResponse();

            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Beer));
            object objResponse = jsonSerializer.ReadObject(myHttpWebResponse.GetResponseStream());
            Beer jsonResponse
            = objResponse as Beer;
            return jsonResponse;
            myHttpWebResponse.Close();

            return new Beer();
        }
    }
}