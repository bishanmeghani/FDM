using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineTraining.EntityFramework;


namespace OnlineTraining.Logic
{
    public interface IShoppingCart
    {
        List<CartItem> GetAllItems();
        void AddToCart(CartItem item);
        void RemoveFromCart(CartItem item);
        void EmptyTheCart();
        int GetNumberOfItems();
        double GetTotalPrice();
    }
    
    
    public class ShoppingCart : IShoppingCart
    {
        List<CartItem> myItems;
        int numberOfItems;
        double totalPrice;
        
        public ShoppingCart()
        {
            myItems = new List<CartItem>();
            numberOfItems = 0;
            totalPrice = 0.0;
        }

        public void AddToCart(CartItem item)
        {
            myItems.Add(item);
        }

        public void RemoveFromCart(CartItem item)
        {
            myItems.Remove(item);
        }

        public void EmptyTheCart()
        {
            myItems.Clear();
        }

        public List<CartItem> GetAllItems()
        {
            return myItems;
        }

        public int GetNumberOfItems()
        {
            numberOfItems = 0;
            foreach (CartItem item in myItems)
            {
                numberOfItems = numberOfItems + item.getProductQuantity();
            }
            return numberOfItems;
        }

        public double GetTotalPrice()
        {
            totalPrice = 0.0;
            foreach (CartItem item in myItems)
            {
                totalPrice = totalPrice + item.getProductPrice() * item.getProductQuantity();
            }
            return totalPrice;
        }
    }
}