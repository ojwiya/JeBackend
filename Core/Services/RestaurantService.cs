using System.Collections.Generic;
using JeBackend.Core.Interfaces;
using JeBackend.Core.Models;

namespace JeBackend.Core.Services
{
    public class RestaurantService : IRestaurantService
    {
        private readonly IRestaurantRepository _restaurantRepository;

        public RestaurantService(IRestaurantRepository restaurantRepository)
        {
            _restaurantRepository = restaurantRepository;
        }

        public RestaurantSearchResult GetRestaurants(string outcode)
        {
            return _restaurantRepository.GetRestaurants(outcode);
        }
    }
}