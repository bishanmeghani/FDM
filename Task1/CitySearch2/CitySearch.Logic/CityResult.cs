using CitySearch.DataLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitySearch.Logic
{
    public class CityResult : ICityResult
    {
        private string searchString;

        public CityResult(string searchString)
        {
            this.searchString = searchString;
        }

        public ICollection<char> NextLetters { get => (Repository.GetCities().Where(r => (r.Name).StartsWith(searchString))).Select(item => item.Name.ToCharArray()[searchString.Count()]).ToList(); set => (Repository.GetCities().Where(r => (r.Name).StartsWith(searchString))).Select(item => item.Name.ToCharArray()[searchString.Count()]).ToList(); }
        public ICollection<string> NextCities { get => (Repository.GetCities().Where(r => (r.Name).StartsWith(searchString))).Select(item => item.Name).ToList(); set => (Repository.GetCities().Where(r => (r.Name).StartsWith(searchString))).Select(item => item.Name).ToList(); }
    }
}
    