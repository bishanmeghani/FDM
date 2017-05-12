using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class PersonLogic
    {
        public bool IsPensionable(Person person, String year) 
        {
            int y=Convert.ToInt32(year);
            string dob = person.dateOfBirth;
            string year1 = dob.Substring(dob.Length - 4);
            int year2 = Convert.ToInt32(year1);
            if (y-year2 >= 65)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }
    }
}
