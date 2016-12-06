using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FourPillars.Encapsulation
{
    class student
    {
        //encapsulation: grouping relevant stuff together
        public string name { get; set; }
        public int id { get; set; }
        public string gender { get; set; }
        public DateTime dateofbirth { get; set; }
        public decimal debt { get; set; }

        //These are not relevant for a student:
        //public int StudentUnionPhoneNumber { get; set; }
        //public DateTime TermDates { get; set; }

        //Variables encapsulate pieces of data
        //Methods encapsulate logic
        //Objects encapsulate variables and methods
        //projects encapsulate classes
        //Solutions encapsulate projects
    }
}
