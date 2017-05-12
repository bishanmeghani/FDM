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
 
        ICollection<char> ICityResult.NextLetters
        {
	        get 
	        { 
		        return (Repository.GetCities().Where(r => (r.Name).StartsWith(searchString))).Select(item => item.Name.ToCharArray()[searchString.Count()]).ToList(); 
	        }
	        set 
	        { 
		        throw new NotImplementedException(); 
	        }
        }

        ICollection<string> ICityResult.NextCities
        {
	        get 
	        { 
		        return (Repository.GetCities().Where(r => (r.Name).StartsWith(searchString))).Select(item => item.Name).ToList();
	        }
	        set 
	        { 
		        throw new NotImplementedException(); 
	        }
        }
    }
}
