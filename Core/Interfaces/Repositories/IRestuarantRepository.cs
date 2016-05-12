using System;
using System.Collections.Generic;
using Core.Models;
using JeBackend.Core.Models;

namespace JeBackend.Core.Interfaces
{
    public interface IRestaurantRepository
    {
        RestaurantSearchResult GetRestaurants(string outcode); //Func<Restaurant, bool> filter = null);
    }
}
