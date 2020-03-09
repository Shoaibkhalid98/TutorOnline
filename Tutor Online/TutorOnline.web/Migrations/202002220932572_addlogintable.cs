namespace TutorOnline.web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addlogintable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Logins",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Email = c.String(),
                        Password = c.String(),
                        Adress = c.String(),
                        phone = c.String(),
                        Description = c.String(),
                        imageUrl = c.String(),
                        userType = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Logins");
        }
    }
}
