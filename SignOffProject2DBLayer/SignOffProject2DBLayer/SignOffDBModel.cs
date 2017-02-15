namespace SignOffProject2DBLayer
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class SignOffDBModel : DbContext
    {
        public SignOffDBModel()
            : base("name=SignOffDBModel")
        {
        }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public DbSet<Book> books { get; set; }
        public DbSet<Cart> carts { get; set; }
    }
}
