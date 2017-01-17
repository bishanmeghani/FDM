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

        public int GetProductId()
        {
            return ProductId;
        }

        public string GetProductName()
        {
            return ProductName;
        }

        public double GetProductPrice()
        {
            return ProductPrice;
        }

        public int GetProductQuantity()
        {
            return ProductQuantity;
        }
    }
}
