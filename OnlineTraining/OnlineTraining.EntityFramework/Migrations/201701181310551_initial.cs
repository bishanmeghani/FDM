namespace OnlineTraining.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Courses",
                c => new
                    {
                        courseId = c.Int(nullable: false, identity: true),
                        courseName = c.String(),
                        courseRating = c.String(),
                        courseDurationHours = c.Int(nullable: false),
                        coursePrice = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.courseId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        customerId = c.Int(nullable: false, identity: true),
                        customerAdmin = c.String(),
                        customerFirstName = c.String(),
                        customerLastName = c.String(),
                        customerAddress = c.String(),
                        customerPhone = c.String(),
                        customerEmail = c.String(),
                        customerPassword = c.String(),
                    })
                .PrimaryKey(t => t.customerId);
            
            CreateTable(
                "dbo.Performances",
                c => new
                    {
                        performanceId = c.Int(nullable: false, identity: true),
                        performancePercentage = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.performanceId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Performances");
            DropTable("dbo.Customers");
            DropTable("dbo.Courses");
        }
    }
}
