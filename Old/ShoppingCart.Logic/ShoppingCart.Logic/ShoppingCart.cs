using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping
{
    public interface IShoppingCart
    {
        List<Item> GetAllItems();
        void AddToCart(Item item);
        void RemoveFromCart(Item item);
        void EmptyTheCart();
        int GetNumberOfItems();
        double GetTotalPrice();
        
    }

    public class ShoppingCart : IShoppingCart
    {
        List<Item> myItems;
        int numberOfItems;
        double totalPrice;

        public ShoppingCart()
        {
            myItems = new List<Item>();
            numberOfItems = 0;
            totalPrice = 0.0;    
        }

        public void AddToCart(Item item)
        {
            //foreach (Item i in myItems)
            //{
            //    if (i.getProductId() == item.getProductId())
            //    {
            //        isNewItem = false;
            //        i.IncrementQuantity();
            //    }
                    
            //}
            myItems.Add(item);
        }

        public void RemoveFromCart(Item item)
        {
            myItems.Remove(item);
        }

        public void EmptyTheCart()
        {
            myItems.Clear();
        }
        
        public List<Item> GetAllItems()
        {
            return myItems;
        }

        public int GetNumberOfItems()
        {
            numberOfItems = 0;
            foreach (Item item in myItems)
            {
                numberOfItems = numberOfItems + item.getQuantity();
            }
            return numberOfItems;
        }

        public double GetTotalPrice()
        {
            totalPrice = 0.0;
            foreach (Item item in myItems)
            {
                totalPrice = totalPrice + item.getPrice()*item.getQuantity();
            }
            return totalPrice;
        }
    }
}
