using EntityFrameworkDemo.CodeFirst;
using EntityFrameworkDemo.Databasefirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is for DB First
            //EFDemoDBFirstEntities context = new EFDemoDBFirstEntities();
            //foreach (Broker broker in context.brokers)
            //{
            //    Console.WriteLine(broker.name); 
            //}
            //Console.ReadLine();

            //This is for CodeFirst
            CodeFirstModel context = new CodeFirstModel();
            //Broker newBroker = new Broker() { name = "Bishan", companyId = 1 };
            //context.brokers.Add(newBroker);
            //context.SaveChanges();

            //Broker brokerToUpdate = context.brokers.Find(1);
           // brokerToUpdate.name = "Superman";
            

            //foreach (Broker broker in context.brokers)
            //{
            //    if (broker.id == 3)
            //    {
            //        context.brokers.Remove(broker);
            //    }
            //}

            //context.SaveChanges();



            //foreach (Broker broker in context.brokers)
            //{
            //     Console.WriteLine(broker.name); 
            //}

            var query = from b in context.brokers where b.companyId == 1 select b;
            foreach (var broker in query)
            {
                Console.WriteLine(broker.name);
            }
            Console.ReadLine();
        }
    }
}
