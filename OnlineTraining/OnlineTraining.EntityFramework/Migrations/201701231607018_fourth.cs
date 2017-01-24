namespace OnlineTraining.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class fourth : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Carts",
                c => new
                    {
                        cartId = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.cartId);
            
            AddColumn("dbo.Courses", "Cart_cartId", c => c.Int());
            CreateIndex("dbo.Courses", "Cart_cartId");
            AddForeignKey("dbo.Courses", "Cart_cartId", "dbo.Carts", "cartId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Courses", "Cart_cartId", "dbo.Carts");
            DropIndex("dbo.Courses", new[] { "Cart_cartId" });
            DropColumn("dbo.Courses", "Cart_cartId");
            DropTable("dbo.Carts");
        }
    }
}
