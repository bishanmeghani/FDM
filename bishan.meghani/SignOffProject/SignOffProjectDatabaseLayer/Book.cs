using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOffProjectDatabaseLayer
{
    public class Book
    {
        [Key]
        public int bookId { get; set; }

        public string name { get; set; }
        public double price { get; set; }
    }
}
