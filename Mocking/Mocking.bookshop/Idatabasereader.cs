using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mocking.bookshop
{
    public interface Idatabasereader
    {
        int readquantity(string isbn);
    }

    public class databasereader:Idatabasereader
    {
        public int readquantity(string isbn)
        {
            return 0;
        }
    }
}
