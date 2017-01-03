using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesExample
{
    public class PriceTotaller
    {
        double totalPrice = 0.0;

        public void AddFootballerPriceToTotal(Footballer footballer)
        {
            totalPrice = totalPrice + footballer.price;
        }

        public void PrintFootballer(Footballer footballer)
        {
            Console.WriteLine(footballer.name);
        }

    }
}
