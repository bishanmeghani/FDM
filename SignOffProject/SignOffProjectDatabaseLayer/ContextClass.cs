﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOffProjectDatabaseLayer
{
    public class ContextClass : DbContext
    {
        public DbSet<Book> books { get; set; }
        public DbSet<Cart> carts { get; set; }

    }
}
