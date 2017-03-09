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
            Item newItem = new Item { ProductId = 1, Name = "Apple", Price = 2.00, Quantity = 7 };
            Item newItem2 = new Item { ProductId = 1, Name = "Apple", Price = 2.00, Quantity = 7 };
            Item newItem3 = new Item { ProductId = 1, Name = "Apple", Price = 2.00, Quantity = 7 };
            IShoppingCart shoppingCart = new ShoppingCart();
            shoppingCart.AddToCart(newItem);
            shoppingCart.AddToCart(newItem2);
            shoppingCart.AddToCart(newItem3);
            Console.WriteLine(shoppingCart.GetNumberOfItems());
            Console.WriteLine(shoppingCart.GetTotalPrice());

            shoppingCart.RemoveFromCart(newItem3);
            Console.WriteLine(shoppingCart.GetNumberOfItems());
            Console.WriteLine(shoppingCart.GetTotalPrice());

            shoppingCart.EmptyTheCart();
            Console.WriteLine(shoppingCart.GetNumberOfItems());
            Console.ReadLine();
        }
    }
}
