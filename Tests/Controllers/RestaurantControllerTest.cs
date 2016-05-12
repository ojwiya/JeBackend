using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using Api;
using Api.Controllers;
using Moq;
using NUnit;
using JeBackend.Core.Interfaces;
using NUnit.Framework;
using JeBackend.Core.Models;
using Ploeh.AutoFixture.NUnit3;
using JeBackend.Core.Services;
using Ploeh.AutoFixture;
using Ploeh.AutoFixture.AutoMoq;

namespace Tests
{
    [TestFixture]
    public class RestaurantControllerTest
    {
        private IFixture _fixture;
        private Mock<IRestaurantService> _mockRestaurantService;
        private RestaurantSearchResult _restaurantResult;
        private RestaurantController _controller;
        
        [SetUp]
        public void SetupTests()
        {
            _fixture = new Fixture().Customize(new MultipleCustomization());
            
            _mockRestaurantService = new Mock<IRestaurantService>();

            _controller = new RestaurantController(_mockRestaurantService.Object);

            _restaurantResult = _fixture.Build<RestaurantSearchResult>()
                                .With(x => x.Restaurants, 
                                    _fixture.CreateMany<Restaurants>().ToList())
                                .Create();

            _mockRestaurantService.Setup(m => m.GetRestaurants(It.IsAny<string>()))
                .Returns((RestaurantSearchResult r) => { return _restaurantResult; });
        }
        
        [Test]
        public void GetRestaurant_ShouldReturn_Restaurants()
        {
            // Arrange
            // Act
            // Assert
            Assert.IsNotNull(_restaurantResult);
            Assert.AreNotEqual(0, _restaurantResult.Restaurants.Count());

        }

        
    }
}
