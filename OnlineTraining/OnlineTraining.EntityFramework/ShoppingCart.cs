using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineTraining.EntityFramework
{
    public interface IShoppingCart
    {
        List<Courses> GetAllItems();
        void AddToCart(Courses item);
        void RemoveFromCart(Courses item);
        void EmptyTheCart();
        int GetNumberOfItems();
        double GetTotalPrice();
        
    }

    public class ShoppingCart : IShoppingCart
    {
        List<Courses> myItems;
        int numberOfItems;
        double totalPrice;

        public ShoppingCart()
        {
            myItems = new List<Courses>();
            numberOfItems = 0;
            totalPrice = 0.0;    
        }

        public void AddToCart(Courses item)
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

        public void RemoveFromCart(Courses item)
        {
            myItems.Remove(item);
        }

        public void EmptyTheCart()
        {
            myItems.Clear();
        }

        public List<Courses> GetAllItems()
        {
            return myItems;
        }

        public int GetNumberOfItems()
        {
            numberOfItems = 0;
            foreach (Courses item in myItems)
            {
                numberOfItems = numberOfItems + 1;
            }
            return numberOfItems;
        }

        public double GetTotalPrice()
        {
            totalPrice = 0.0;
            foreach (Courses item in myItems)
            {
                totalPrice = totalPrice + item.GetCoursePrice();
            }
            return totalPrice;
        }
    }
}
