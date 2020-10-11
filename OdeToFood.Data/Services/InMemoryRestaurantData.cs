using OdeToFood.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data.Services
{
    public class InMemoryRestaurantData : IRestaurantData
    {
        IEnumerable<Restaurant> restaurant;

        public InMemoryRestaurantData()
        {
            restaurant = new List<Restaurant>()
            {
                new Restaurant { Id=1, Name="Mamma Mia", Cuisine=CuisineType.Italian },
                new Restaurant { Id=2, Name="Best Mangal", Cuisine=CuisineType.Indian },
                new Restaurant { Id=3, Name="Petit Auberge", Cuisine=CuisineType.French }
            };
        }

        public IEnumerable<Restaurant> GetAll()
        {
            return restaurant;
        }
    }
}
