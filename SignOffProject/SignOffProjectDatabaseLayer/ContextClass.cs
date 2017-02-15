using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOffProjectDatabaseLayer
{
    public class ContextClass
    {
        DbSet<Book> books { get; set; }
        DbSet<Cart> carts { get; set; }

    }
}
