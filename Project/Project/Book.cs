using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Project
{
    public class Book
    {
        public int id { get; set; }
        public string name { get; set; }

        public List<Cart> carts { get; set; }
    }
}
