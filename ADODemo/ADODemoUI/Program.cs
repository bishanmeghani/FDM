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
            //IBrokerRepository _brokerRepo = new MicrosoftSqlServerBrokerRepository(connectionString);
            //brokerRepo.AddNewBroker(new Broker() { id = 4, firstName = "Ned", lastName = "Stark" }); commented so it doesnt add it again
            //_brokerRepo.UpdateBroker(4, new Broker() { firstName = "Tywin", lastName = "Lannister" }); // modified Ned to Tywin
            //_brokerRepo.RemoveBroker(4); // remove Tywin

            //List<Broker> allBrokers = _brokerRepo.GetAllBrokers();

            IBrokerDisconnected _brokerRepo = new BrokerRepositoryDisconnected(connectionString);
            List<Broker> allBrokers = _brokerRepo.GetAllBrokers();
            foreach (Broker broker in allBrokers)
            {
                Console.WriteLine(broker.firstName + " " + broker.lastName);
            }
            Console.ReadLine();
        }
    }
}
