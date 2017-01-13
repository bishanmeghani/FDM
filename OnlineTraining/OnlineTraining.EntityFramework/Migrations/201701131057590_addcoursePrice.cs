namespace OnlineTraining.EntityFramework.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addcoursePrice : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Courses", "coursePrice", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Courses", "coursePrice");
        }
    }
}
