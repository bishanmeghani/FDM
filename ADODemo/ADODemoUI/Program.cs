using ADODemo.Connection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADODemoUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Data Source=TRNLON11663;Initial Catalog=DemoDB;Integrated Security=True";
            IBrokerRepository _brokerRepo = new MicrosoftSqlServerBrokerRepository(connectionString);
            List<Broker> allBrokers = _brokerRepo.GetAllBrokers();
            foreach (Broker broker in allBrokers)
            {
                Console.WriteLine(broker.firstName + " " + broker.lastName);
            }
            Console.ReadLine();
        }
    }
}
