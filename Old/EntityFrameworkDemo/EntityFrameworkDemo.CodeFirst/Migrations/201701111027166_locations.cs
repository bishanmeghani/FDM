namespace EntityFrameworkDemo.CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class locations : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.locations",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        postCode = c.String(),
                        name = c.String(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.locations");
        }
    }
}
