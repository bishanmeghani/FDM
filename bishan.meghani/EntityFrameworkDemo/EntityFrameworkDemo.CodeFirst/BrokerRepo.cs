using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo.CodeFirst
{
    public class BrokerRepo
    {
        CodeFirstModel _context;

        public BrokerRepo(CodeFirstModel context)
        {
            _context = context;
        }
        public virtual List<Broker> GetAllBrokers()
        {
            //CodeFirstModel context = new CodeFirstModel();
            return _context.brokers.ToList();
        }

        
    }
}
