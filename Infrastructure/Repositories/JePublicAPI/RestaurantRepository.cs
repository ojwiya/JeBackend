using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using JeBackend.Core.Interfaces;
using JeBackend.Core.Models;
using JeBackend.Core.Models;

namespace JeBackend.Infrastructure.Repositories
{
    public class RestaurantRepository : IRestaurantRepository
    {

        private string URL = " https://public.je-apis.com/restaurants";
        private string urlParameters;

        //public void Add(Restaurant entry)
        //{
        //    entry.DateCreated = DateTime.Now;
        //    DbContext.RestaurantEntries.Add(Guid.NewGuid(), entry);
        //}

        public GetRestaurantResult GetRestaurants(string outcode)
        {

            urlParameters = "?q=" + outcode;

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);

            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));

            // List data response.
            HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                // Parse the response body. Blocking!
                GetRestaurantResult responseResult = response.Content.ReadAsAsync<GetRestaurantResult>().Result;
                return responseResult;
            }
            else
            {
                //Ideally should only one return
                return null;
            }

        }

    }
}