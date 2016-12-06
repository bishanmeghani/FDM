using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Person
    {
        private string _firstname;
        public string firstname
        {
            get {return _firstname;}
            set {_firstname = value;}
        }

        private string _lastname;
        public string lastname
        {
            get {return _lastname;}
            set {_lastname = value;}
        }

        private string _dateOfBirth;
        public string dateOfBirth
        {
            get {return _dateOfBirth;}
            set {_dateOfBirth = value;}
        }

    }
}
