﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class view
    {
        public void PrintEligible(Person person)
        {
            Console.WriteLine(person.firstname + " " + person.lastname  + " may qualify for a pension this year");
        }
        public void PrintIneligible(Person person)
        {
            Console.WriteLine(person.firstname + " " + person.lastname + " is not old enough");
        }
    }
}