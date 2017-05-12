using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Client
    {
        public static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.firstname = "John";
            person1.lastname = "Smith";
            person1.dateOfBirth = "28/06/1993";

            Person person2 = new Person();
            person2.firstname = "Jane";
            person2.lastname = "Doe";
            person2.dateOfBirth = "05/01/1950";

            Person person3 = new Person();
            person3.firstname = "Fred";
            person3.lastname = "Bloggs";
            person3.dateOfBirth = "12/12/1949";
        
            Person[] people = {person1,person2,person3};
            PensionController Control = new PensionController();
            Control.HandlePensions(people);
            Console.ReadLine();
        }
    }
}
