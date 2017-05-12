using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDs
{
    public class CD
    {
        public string title { get; set; }
        public string artist { get; set; }
        public double lengthOfTracks { get; set; }
        public int numberOfTracks { get; set; }

        public CD(string Title, string Artist, double LengthofTracks, int NumberOfTracks)
        {
            title = Title;
            artist = Artist;
            lengthOfTracks = LengthofTracks;
            numberOfTracks = NumberOfTracks;
        }
           
         
    }
}
