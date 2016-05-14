using JeBackend.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace Api.Controllers
{
    [AllowAnonymous]
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class RestaurantController : ApiController
    {
        private readonly IRestaurantService _restaurantService;

        public RestaurantController(IRestaurantService restaurantService) {
            _restaurantService = restaurantService;
        }

        [Route("api/restaurants/{outcode}")]
        public HttpResponseMessage Get(string outcode)
        {

           var restaurantSearchResult = _restaurantService.GetRestaurants(outcode);

            HttpResponseMessage response = Request.CreateResponse(HttpStatusCode.OK, restaurantSearchResult);
            return response;
            
        }

    }
}
