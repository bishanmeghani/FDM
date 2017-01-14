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
        void CheckItemExistsThenAddToCart(Item item);
    }


    public class ShoppingCart : IShoppingCart, IEnumerable
    {
        List<Item> myItems = new List<Item>();

        public ShoppingCart()
        {
            myItems = new List<Item>();    
        }

        public List<Item> GetAllItems()
        {
            return myItems;
        }

        public void CheckItemExistsThenAddToCart(Item item)
        {
            var cartItem = myItems.FirstOrDefault(ci => ci.ProductId == item.ProductId);
            if (cartItem == null)
            {
                AddToCart(item);
            }
            else
            {
                cartItem.Quantity = cartItem.Quantity + 1;
            }
        }

        public void AddToCart(Item item)
        {
            myItems.Add(item);
        }

        public IEnumerator GetEnumerator()
        {
            return (myItems as IEnumerable).GetEnumerator();
        }
    }
}
