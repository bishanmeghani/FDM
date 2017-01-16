using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OnlineTraining.Logic
{
    public class CartItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int ProductQuantity { get; set; }

        public int getProductId()
        {
            return ProductId;
        }

        public string getProductName()
        {
            return ProductName;
        }

        public double getProductPrice()
        {
            return ProductPrice;
        }

        public int getProductQuantity()
        {
            return ProductQuantity;
        }
    }
}
