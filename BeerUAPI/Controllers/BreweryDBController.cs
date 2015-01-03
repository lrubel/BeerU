using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Web.Script.Serialization;
using BeerUAPI.Data;
using BeerUAPI.Types;
using Microsoft.Owin.Security.Provider;
using Newtonsoft.Json;

namespace BeerUAPI.Controllers
{
    public class BreweryDBController : BaseController
    {
        private readonly IBreweryDbRepository breweryDbRepository;

        public BreweryDBController(IBreweryDbRepository breweryDbRepository)
        {
            this.breweryDbRepository = breweryDbRepository;
        }


        public RootObject GetBeerByName(string name)
        {
           return breweryDbRepository.GetBeerByName(name);
        }

        public RootObject GetBeerByAbv(string abv)
        {
            return breweryDbRepository.GetBeerByAbv(abv);
        }

        public List<Beer> GetBeerByStyle(string styleId)
        {
            return breweryDbRepository.GetBeerByStyle(styleId);
        }

        public RootObject GetBeerByPageNumber(string p)
        {
            return breweryDbRepository.GetBeerByPageNumber(p);
        }
    }
}