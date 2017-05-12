using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitySearch.Logic
{
    public class CityFinder : ICityFinder
    {
        public ICityResult Search(string searchString)
        {
            CityResult cr = new CityResult(searchString);
            return cr;
        }
    }
}
