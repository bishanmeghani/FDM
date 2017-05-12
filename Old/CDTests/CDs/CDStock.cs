using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDs
{
    public class CDStock
    {
        public List<CD> cds = new List<CD>();

        public IEnumerable<CD> SearchByTitle(string titleWanted)
        {
            return cds.Where(c => c.title == titleWanted);
        }

        public IEnumerable<CD> SearchForTracksLessThan10()
        {
            return cds.Where(c => c.numberOfTracks < 10);
        }

        public IEnumerable<CD> SearchForLengthOfTracksMoreThan60Min()
        {
            return cds.Where(c => c.lengthOfTracks > 60);
        }

        public IEnumerable<CD> OrderByAlphabeticalOrder()
        {
            return cds.OrderBy(c => c.title);
        }

        public bool CheckIfArtistExists(string artistSearched)
        {
            if (cds.SingleOrDefault(c => c.artist == artistSearched) == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
