using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using JeBackend.Core.Interfaces;
using JeBackend.Core.Models;
using JeBackend.Infrastructure.Repositories.Dto;


namespace JeBackend.Infrastructure.Repositories
{
    public class RestaurantRepository : IRestaurantRepository
    {

        private string URL = " https://public.je-apis.com/restaurants";
        private string urlParameters;

        public RestaurantSearchResult GetRestaurants(string outcode)
        {

            urlParameters = "?q=" + outcode;
            RestaurantSearchResult restaurantSearchResult = new RestaurantSearchResult();

            HttpClient client = InitializeConnection();

            SetHeaders(client);

            // List data response.
            HttpResponseMessage response = client.GetAsync(urlParameters).Result;  // Blocking call!
            if (response.IsSuccessStatusCode)
            {
                return ParseResponse(restaurantSearchResult, response);
            }
            else
            {
                //Ideally should only one return
                return null;
            }

        }

        private HttpClient InitializeConnection()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(URL);
            return client;
        }

        private static RestaurantSearchResult ParseResponse(RestaurantSearchResult restaurantSearchResult, HttpResponseMessage response)
        {
            // Parse the response body. Blocking!
            GetRestaurantResult responseResult = response.Content.ReadAsAsync<GetRestaurantResult>().Result;

            restaurantSearchResult.Restaurants = responseResult.Restaurants;
            restaurantSearchResult.ShortResultText = responseResult.ShortResultText;
            restaurantSearchResult.HasErrors = responseResult.HasErrors;

            return restaurantSearchResult;
        }

        private static void SetHeaders(HttpClient client)
        {
            // Add an Accept header for JSON format.
            client.DefaultRequestHeaders.Accept.Add(
            new MediaTypeWithQualityHeaderValue("application/json"));
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", "VGVjaFRlc3RBUEk6dXNlcjI=");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Tenant", "uk");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Language", "en-GB");
            client.DefaultRequestHeaders.TryAddWithoutValidation("Host", "public.je-apis.com");
        }

    }
}