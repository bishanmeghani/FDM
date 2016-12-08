using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDbookshop
{
    public class Checkout
    {
        public double calculatePrice(Basket basket)
        {
            double cost = 0.0;
            int discount = 0; 
            for (int i = 0; i < basket.getBooksInBasket().Count; i++)
            {
                cost = cost + basket.getBooksInBasket()[i].price;
            }

            discount = basket.getBooksInBasket().Count / 3;
            if (basket.getBooksInBasket().Count >= 10)
            {
                discount = discount + 10;
            }
            
            cost = cost * (1 - discount / 100.0);

            return cost;
            
        }
    }
}
