using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractandInterface
{
    class AdminController : UserController
    {
        public void SetPermissions(string username)
        {
            //set permissions for username
            Console.WriteLine("Setting permissions for " + username);
        }
    }
}
