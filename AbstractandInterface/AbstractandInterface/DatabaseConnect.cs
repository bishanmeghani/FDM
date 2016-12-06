using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractandInterface
{
    interface DatabaseConnect
    {
        bool openconnection(string databaseaddress);
    }
    class microsoftconnection : DatabaseConnect
    {

        public bool openconnection(string databaseaddress)
        {
            return true;
        }
    }
    class oracleconnection : DatabaseConnect
    {

        public bool openconnection(string databaseaddress)
        {
            return false;
        }
    }
}
