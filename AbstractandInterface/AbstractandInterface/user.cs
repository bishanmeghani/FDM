using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractandInterface
{
    abstract class user
    {
        public string firstname;
        public string lastname;
        public string role;
    }
    class buyer : user
    {

    }
    class seller: user
    {

    }
    class admin : user 
    {
    
    }
}
