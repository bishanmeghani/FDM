using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractandInterface
{
    class UserController
    {
        public bool Login(string username,string password)
        {
            // Do some logic to work out if they should be logged in
            Console.WriteLine("Logging in " + username);
            return true;
        }
    }
}
