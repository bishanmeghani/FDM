using System;
using System.Collections.Generic;
using System.Text;

namespace CitySearch.DataLayer
{
    public class Repository
    {
        public static List<City> GetCities()
        {
            List<City> cities = new List<City>
            {
                new City { Name = "Bangkok" },
                new City { Name = "Bandung" },
                new City { Name = "Bangalore" },
                new City { Name = "Bangui" },
                new City { Name = "La Paz" },
                new City { Name = "La Plata" },
                new City { Name = "Lagos" },
                new City { Name = "Leeds" },
                new City { Name = "Zaria" },
                new City { Name = "Zhughai" },
                new City { Name = "Zibo" }
            };
            
            return cities;
        }

    }
}
