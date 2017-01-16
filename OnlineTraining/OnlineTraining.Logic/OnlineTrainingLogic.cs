using log4net;
using System;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineTraining.EntityFramework;


namespace OnlineTraining.Logic
{
    public class ShoppingCart
    {
        public List<Courses> myItems { get; private set; };

        public List<Courses> ShoppingCart()
        {
            return myItems;
        }

        public void AddToCart(int courseId)
        {
            CartItem newItem = new CartItem();
            // if the item already exists, just add 1 to the quantity
            if (myItems.Contains(newItem))
            {
                foreach (CartItem item in myItems)
                {
                    if (item.Equals(newItem))
                    {
                        item.Quantity++;

                    }
                }
            }

            // if the item doesn't exist in the cart, add it to the cart
            else
            {
                newItem.Quantity++;
                myItems.Add(newItem);
            }
        }
    }
}