namespace Project.Migrations
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
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.CartBook",
                c => new
                    {
                        CartId = c.Int(nullable: false),
                        BookId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.CartId, t.BookId })
                .ForeignKey("dbo.Carts", t => t.CartId, cascadeDelete: true)
                .ForeignKey("dbo.Books", t => t.BookId, cascadeDelete: true)
                .Index(t => t.CartId)
                .Index(t => t.BookId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CartBook", "BookId", "dbo.Books");
            DropForeignKey("dbo.CartBook", "CartId", "dbo.Carts");
            DropIndex("dbo.CartBook", new[] { "BookId" });
            DropIndex("dbo.CartBook", new[] { "CartId" });
            DropTable("dbo.CartBook");
            DropTable("dbo.Carts");
            DropTable("dbo.Books");
        }
    }
}
