namespace TutorOnline.web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addAccountStatus : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teachers", "DegreeImageUrl", c => c.String(nullable: false));
            AddColumn("dbo.Teachers", "currentAccountStatus", c => c.String());
            DropColumn("dbo.Teachers", "recentDegree");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Teachers", "recentDegree", c => c.String(nullable: false));
            DropColumn("dbo.Teachers", "currentAccountStatus");
            DropColumn("dbo.Teachers", "DegreeImageUrl");
        }
    }
}
