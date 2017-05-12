namespace Project
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DatabaseLayer : DbContext
    {
        public DatabaseLayer()
            : base("name=DatabaseLayer")
        {
        }

        public DbSet<Book> books { get; set; }

        public DbSet<Cart> carts { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cart>()
            .HasMany<Book>(s => s.books)
            .WithMany(c => c.carts)
            .Map(cs =>
            {
                cs.MapLeftKey("CartId");
                cs.MapRightKey("BookId");
                cs.ToTable("CartBook");
            });
        }


    }
}
