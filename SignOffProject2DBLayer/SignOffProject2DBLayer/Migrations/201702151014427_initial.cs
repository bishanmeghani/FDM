namespace SignOffProject2DBLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        bookId = c.Int(nullable: false, identity: true),
                        title = c.String(),
                        price = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.bookId);
            
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        cartId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.cartId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Carts");
            DropTable("dbo.Books");
        }
    }
}
