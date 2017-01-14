using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    class Program
    {
        static void Main(string[] args)
        {
            Item newItem = new Item { ProductId = 1, Name = "Apple", Price = "0.10", Quantity = 1 };
            IShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddToCart(newItem);

            Console.WriteLine(shoppingCart.GetAllItems().Count);
            Console.ReadLine();
        }
    }
}
