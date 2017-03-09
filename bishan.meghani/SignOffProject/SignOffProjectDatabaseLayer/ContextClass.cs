using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignOffProjectDatabaseLayer
{
    public class ContextClass : DbContext
    {
        public ContextClass()
            : base("name=SignOffDatabase")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public DbSet<Book> books { get; set; }
        public DbSet<Cart> carts { get; set; }

    }
}
