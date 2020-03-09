namespace TutorOnline.web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDegreeColumninTeacher : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "recentDegree", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teachers", "recentDegree");
        }
    }
}
