using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOffProject2DBLayer
{
    public class Cart
    {
        [Key]
        public int cartId { get; set; }

        public List<Book> cartItems { get; set; }
    }
}
