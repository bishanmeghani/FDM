using System.Collections.Generic;

namespace CitySearch.Logic
{
    public interface ICityResult
    {
        ICollection<char> NextLetters { get; set; }
        ICollection<string> NextCities { get; set; }
    }
}