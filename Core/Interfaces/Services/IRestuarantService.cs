using System.Collections.Generic;
using Core.Models;
using JeBackend.Core.Models;

namespace JeBackend.Core.Interfaces
{
    public interface IRestaurantService
    {
        RestaurantSearchResult GetRestaurants(string outcode);

    }
}