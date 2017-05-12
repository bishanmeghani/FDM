using CitySearch.DataLayer;
using CitySearch.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            CityFinder cf = new CityFinder();
            ICityResult cres = cf.Search("Bang");

            foreach (var item in cres.NextCities)
            {
                Console.WriteLine(item.ToString());
            }

            foreach (var item in cres.NextLetters)
            {
                Console.WriteLine(item.ToString());
            }

            Console.Read();
        }
    }
}
