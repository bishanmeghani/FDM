using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            PriceTotaller priceTotaller = new PriceTotaller();
            FootballerDatabase footballerDB = new FootballerDatabase();

            Footballer footballer1 = new Footballer("Olivier Giroud", "Arsenal", 30.0, false);
            Footballer footballer2 = new Footballer("Wayne Rooney", "Man Utd", 10.0, false);
            Footballer footballer3 = new Footballer("Steph Houghton", "Man City", 100.0, true);
            Footballer footballer4 = new Footballer("Claire Basset", "Liverpool", 300.0, false);


            footballerDB.AddFootballer(footballer1);
            footballerDB.AddFootballer(footballer2);
            footballerDB.AddFootballer(footballer3);
            footballerDB.AddFootballer(footballer4);

            ProcessPlayerDelegate myTotallerDelegate = new ProcessPlayerDelegate(priceTotaller.AddFootballerPriceToTotal);
            footballerDB.ProcessInjuredPlayers(myTotallerDelegate);

            ProcessPlayerDelegate myPrintDelegate = new ProcessPlayerDelegate(priceTotaller.PrintFootballer);
            footballerDB.ProcessInjuredPlayers(myPrintDelegate);

          
        }
    }
}
