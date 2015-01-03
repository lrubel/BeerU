using System.Collections.Generic;
using BeerUAPI.Types;

namespace BeerUAPI.Data
{
    public interface IBreweryDbRepository
    {
        RootObject GetBeerByName(string name);
        RootObject GetBeerByAbv(string abv);
        RootObject GetBeerByYear(string year);
        List<Beer> GetBeerByStyle(string styleId);
        RootObject GetBeerByPageNumber(string p);
    }
}